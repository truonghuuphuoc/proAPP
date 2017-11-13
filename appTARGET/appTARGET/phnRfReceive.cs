using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace appTARGET
{
    public delegate void phnRfReceiveDelegate(int type, int value);

    public class MessageType
    {
        public const int TYPE_CONTROL_1 = 1;
        public const int TYPE_CONTROL_2 = 2;
        public const int TYPE_CONTROL_3 = 3;
    }

    class phnRfReceive
    {
        public static int MESG_BUFFER_SIZE = 200;

        private System.IO.Ports.SerialPort  mRfSerialPort;
        private Thread                      mRfRecvThread;



        byte mRf_IsStartFrame  = 0;
        byte mRf_IsEndFrame    = 0;
        byte mRf_IsFisrtNibble = 0;

        byte mRf_CurrentByte   = 0;
        byte mRf_IsMessageRecv = 0;


        byte [] mRf_MessageData = new byte[MESG_BUFFER_SIZE];
        UInt16  mRf_DataPosition = 0;

        public phnRfReceiveDelegate mRfReceiveEvent;


        public int phnRfReceive_IntializePort(string rfSerialCom)
        {
            try
            {
                mRfSerialPort           = new System.IO.Ports.SerialPort();
                mRfSerialPort.PortName  = rfSerialCom;
                mRfSerialPort.BaudRate  = 9600;
                mRfSerialPort.DataBits  = 8;
                mRfSerialPort.StopBits  = System.IO.Ports.StopBits.One;
                mRfSerialPort.Parity    = System.IO.Ports.Parity.None;

                mRfSerialPort.Open();


                Console.WriteLine("RF serial port is opened");
            }
            catch
            {
                Console.WriteLine("RF serial port opened failed");
                return 1;
            }

            mRfRecvThread = new Thread(new ThreadStart(phnRfReceive_ReadWriteThread));
            mRfRecvThread.IsBackground = true;
            mRfRecvThread.Priority = ThreadPriority.Highest;
            mRfRecvThread.Start();
            return 0;
        }

        private void phnRfReceive_ReadWriteThread()
        {
            byte[] dataSend = new byte[MESG_BUFFER_SIZE];
            byte[] dataCommand = new byte[] { 0x1E, 0x2D, 0x3C, 0x4B, 0x5A, 0x69, 0x78, 0x87, 0x96, 0xA5, 0xB4, 0xC3, 0xD2, 0xE1 };
            UInt16 sendLength = 0;

            int index = 0;
            while (true)
            { 
                phnMessage.phnMessage_GetMessageFormat(dataCommand, (UInt16)dataCommand.Length, ref dataSend, ref sendLength);


                phnRfReceive_SendMessage(dataSend, sendLength);

                phRfReceive_ReceiveMessage();

                if (mRf_IsMessageRecv == 1)
                {
                    index++;
                    mRfReceiveEvent(MessageType.TYPE_CONTROL_1, index);
                }
                else
                {
                    index = 0;
                    mRfReceiveEvent(MessageType.TYPE_CONTROL_1, index);
                }

                mRf_IsMessageRecv = 0;

                Thread.Sleep(1000);
            }
        }

        private void phnRfReceive_Reset()
        {
            mRf_IsStartFrame    = 0;
            mRf_IsEndFrame      = 0;
            mRf_DataPosition    = 0;
            mRf_IsFisrtNibble   = 0;
            mRf_IsMessageRecv   = 0;
        }

        private void phnRfReceive_MessageHandler(byte data)
        {

            switch (data)
            {
                case phnMessage.MESG_STX:   // start of text
                    phnRfReceive_Reset();

                    mRf_IsStartFrame = 1;
                    mRf_IsFisrtNibble = 1;
                    break;

                case phnMessage.MESG_ETX:   // end of text

                    // have end frame
                    mRf_IsEndFrame = 1;
                    break;

                default:
                    // wait until packet officially starts
                    if (mRf_IsStartFrame == 0)
                    {
                        break;
                    }

                    // check byte is in valid form (4 bits followed by 4 bits complemented)
                    if ((data >> 4) != ((data & 0x0F) ^ 0x0F))
                    {
                        // bad character
                        phnRfReceive_Reset();
                        break;
                    }
                    // convert back
                    data >>= 4;

                    // high-order nibble?
                    if (mRf_IsFisrtNibble == 1)
                    {
                        mRf_CurrentByte = data;
                        mRf_IsFisrtNibble = 0;
                        break;
                    }

                    // low-order nibble
                    mRf_CurrentByte <<= 4;
                    mRf_CurrentByte |= data;
                    mRf_IsFisrtNibble = 1;

                    // if we have the ETX this must be the CRC
                    if (mRf_IsEndFrame == 1)
                    {
                        byte crc = phnMessage.phnMessage_CrcCalculate(mRf_MessageData, mRf_DataPosition);
                        if (crc != mRf_CurrentByte)
                        {
                            phnRfReceive_Reset();
                        }
                        else
                        {
                            //have message
                            mRf_IsMessageRecv = 1;
                        }

                        break;
                    }  // end if have ETX already

                    // keep adding if not full
                    mRf_MessageData[mRf_DataPosition++] = mRf_CurrentByte;
                    break;
            }
        }

        private void phnRfReceive_SendMessage(byte[] data, UInt16 length)
        {
            if (mRfSerialPort.IsOpen == false)
            {
                return;
            }

            mRfSerialPort.DiscardInBuffer();
            mRfSerialPort.Write(data, 0, length);
        }

        private void phRfReceive_ReceiveMessage()
        {
            int timeout;
            byte[] recv = new byte[2];

            timeout = 50;
            while (mRfSerialPort.BytesToRead == 0 && timeout > 0)
            {
                timeout--;
                Thread.Sleep(10);
            }

            if(mRfSerialPort.BytesToRead == 0)
            {
                return;
            }


            do
            {
                mRfSerialPort.Read(recv, 0, 1);

                phnRfReceive_MessageHandler(recv[0]);

                if(mRf_IsMessageRecv == 1)
                {
                    break;
                }

                timeout = 5;
                while (mRfSerialPort.BytesToRead == 0 && timeout > 0)
                {
                    timeout--;
                    Thread.Sleep(10);
                }

                if (mRfSerialPort.BytesToRead == 0)
                {
                    phnRfReceive_Reset();
                    return;
                }

            } while (mRf_IsMessageRecv == 0);
        }
    }
}
