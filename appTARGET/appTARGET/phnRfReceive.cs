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



        private byte mRf_IsStartFrame  = 0;
        private byte mRf_IsEndFrame    = 0;
        private byte mRf_IsFisrtNibble = 0;

        private byte mRf_CurrentByte   = 0;
        private byte mRf_IsMessageRecv = 0;


        private byte mRf_StartAddress       = 0;
        private byte mRf_DestinationAddress = 0;


        private byte[] mRf_MessageData = new byte[MESG_BUFFER_SIZE];
        private UInt16 mRf_DataPosition = 0;

        public phnRfReceiveDelegate mRfReceiveEvent;


        private Queue<phnEvent> mEvent = new Queue<phnEvent>();

        public int phnRfReceive_IntializePort(string rfSerialCom, byte startAddress, byte desAddress)
        {
            

            try
            {
                mRf_StartAddress = startAddress;
                mRf_DestinationAddress = desAddress;

                mRfSerialPort = new System.IO.Ports.SerialPort();
                mRfSerialPort.PortName = rfSerialCom;
                mRfSerialPort.BaudRate = 9600;
                mRfSerialPort.DataBits = 8;
                mRfSerialPort.StopBits = System.IO.Ports.StopBits.One;
                mRfSerialPort.Parity = System.IO.Ports.Parity.None;

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

        public void updateValue(byte _be, byte _bia, byte _value)
        {
            mEvent.Enqueue(new phnEvent(_be, _bia, _value));
        }

        private void phnRfReceive_ReadWriteThread()
        {
            byte[] recv  = new byte[2];

            byte[] dataSend = new byte[MESG_BUFFER_SIZE];
            byte[] messSend = new byte[MESG_BUFFER_SIZE];
            UInt16 messLength = 0;

            while (true)
            {
                if(mRfSerialPort.IsOpen && mRfSerialPort.BytesToRead > 0)
                {
                    mRfSerialPort.Read(recv, 0, 1);

                    phnRfReceive_MessageHandler(recv[0]);

                }
                else
                {
                    Thread.Sleep(100);
                }

                if (mRf_IsMessageRecv == 0)
                {
                    continue;
                }

                mRf_IsMessageRecv = 0;

                dataSend[0] = mRf_MessageData[1];

                //set its address
                dataSend[1] = mRf_MessageData[0];

                //set ACK
                dataSend[2] = mRf_MessageData[2];

                if(mEvent.Count > 0)
                {
                    phnEvent _event = mEvent.Dequeue();

                    if(_event.Be == 0)
                    {
                        switch (_event.Bia)
                        {
                            case 0:
                                //set value of slave 1
                                dataSend[3] = _event.Diem;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            case 1:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = _event.Diem;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            default:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = _event.Diem;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;
                        }
                    }
                    else if(_event.Be == 1)
                    {
                        switch (_event.Bia)
                        {
                            case 0:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = _event.Diem;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            case 1:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = _event.Diem;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            default:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = _event.Diem;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;
                        }
                    }
                    else
                    {
                        switch (_event.Bia)
                        {
                            case 0:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = _event.Diem;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            case 1:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = _event.Diem;

                                //set value of slave 9
                                dataSend[11] = 0xFF;
                                break;

                            default:
                                //set value of slave 1
                                dataSend[3] = 0xFF;

                                //set value of slave 2
                                dataSend[4] = 0xFF;

                                //set value of slave 3
                                dataSend[5] = 0xFF;

                                /******* BE 2 ******/

                                //set value of slave 4
                                dataSend[6] = 0xFF;

                                //set value of slave 5
                                dataSend[7] = 0xFF;

                                //set value of slave 6
                                dataSend[8] = 0xFF;

                                /******* BE 3 ******/

                                //set value of slave 7
                                dataSend[9] = 0xFF;

                                //set value of slave 8
                                dataSend[10] = 0xFF;

                                //set value of slave 9
                                dataSend[11] = _event.Diem;
                                break;
                        }
                    }

                }
                else
                {

                    /******* BE 1 ******/

                    //set value of slave 1
                    dataSend[3] = 0xFF;

                    //set value of slave 2
                    dataSend[4] = 0xFF;

                    //set value of slave 3
                    dataSend[5] = 0xFF;


                    /******* BE 2 ******/

                    //set value of slave 4
                    dataSend[6] = 0xFF;

                    //set value of slave 5
                    dataSend[7] = 0xFF;

                    //set value of slave 6
                    dataSend[8] = 0xFF;

                    /******* BE 3 ******/

                    //set value of slave 7
                    dataSend[9] = 0xFF;

                    //set value of slave 8
                    dataSend[10] = 0xFF;

                    //set value of slave 9
                    dataSend[11] = 0xFF;
                }


                //send message reponse to host
                phnMessage.phnMessage_GetMessageFormat(dataSend, 12, ref messSend, ref messLength);
                phnRfReceive_SendMessage(messSend, messLength);
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
