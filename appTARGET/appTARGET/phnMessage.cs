using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appTARGET
{
    class phnMessage
    {
        /*Start message*/
        public const byte MESG_STX = 0x02;

        /*End message*/
        public const byte MESG_ETX = 0x03;	


        public static byte phnMessage_CrcCalculate(byte[] data, UInt16 length)
        {
            byte crc = 0;
            byte inbyte;
            byte i, mix;

            UInt16 index;

            for (index = 0; index < length; index++)
            {
                inbyte = data[index];

                for (i = 8; i > 0; i--)
                {
                    mix = (byte)((byte)(crc ^ inbyte) & (byte)0x01);
                    crc >>= 1;

                    if (mix > 0)
                    {
                        crc ^= 0x8C;
                    }

                    inbyte >>= 1;
                }
            }

            return crc;
        }


        public static void phnMessage_GetMessageFormat(byte[] data, UInt16 inLength, ref byte[] message, ref UInt16 outLength)
        {
            byte value, crc;
            byte index;
            byte position = 0;

            //Start message
            message[position] = MESG_STX;
            position++;

            //Data
            for (index = 0; index < inLength; index++)
            {
                //Data first nibble
                value = (byte)(data[index] >> 4);
                message[position] = (byte)((value << 4) | (value ^ 0x0F));
                position++;

                //Data second nibble
                value = (byte)(data[index] & 0x0F);
                message[position] = (byte)((value << 4) | (value ^ 0x0F));
                position++;
            }

            //End message
            message[position] = MESG_ETX;
            position++;

            //Crc
            crc = phnMessage_CrcCalculate(data, inLength);

            //Crc first nibble
            value = (byte)(crc >> 4);
            message[position] = (byte)((value << 4) | (value ^ 0x0F));
            position++;

            //Crc second nibble
            value = (byte)(crc & 0x0F);
            message[position] = (byte)((value << 4) | (value ^ 0x0F));
            position++;

            outLength = position;
        }
    }
}
