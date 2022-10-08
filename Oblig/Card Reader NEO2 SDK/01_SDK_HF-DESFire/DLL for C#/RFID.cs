﻿using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace COMMLIB
{
    public class Api
    {
        private const int BUFFER_SIZE = 600;
        private const int READ_TIMEOUT = 500;
        private int Authority_count = 0;
        private const int AUTHORITY_COUNT = 20;

        private const int ERR_TIMEOUT = -1;
        private const int ERR_FORMAT = -2;
        private const int ERR_ACK = -3;
        private const int ERR_PARAM = -4;
        private const int ERR_COM = -5;     //Serial port error

        private const byte STX = 0x50;
        private const byte STX_ERR = 0xF0;

        private const byte SET_UR_BAUDRATE = 0x01; //Set the baud rate
        private const byte SET_BUZZER = 0x02;   //Setting the buzzer
        private const byte SET_LED = 0x03;      //Set the LED, SET_LED（CMD=0x03）
        private const byte GETANTSTATUS = 0x0B; //Get antenna status
        private const byte SETANT = 0x0C; //Set antenna
		
        private const byte GET_FW_VERSION = 0x04;
        private const byte GET_HW_VERSION = 0x05;
        private const byte GET_HID_ICLASS_UID = 0xA1;

        //ISO 14443A
        private const byte PICCRESET = 0x21;
        private const byte PICCACTIVATE = 0x22;
        private const byte PICCACTIVATE_B = 0x41;
        private const byte PICCAUTHKEY = 0x16;
        private const byte PICCINITVL = 0x1A;
        private const byte PICCVALUE_A = 0x1B;
        private const byte PICCREADVL = 0x1D;
        private const byte PICCBAK_A = 0x1C;
        private const byte PICCWRITE_A = 0x18;
        private const byte PICCWRITE_UL = 0x19;
        private const byte PICCREAD_A = 0x17;
        private const byte PICCRATS = 0x2A;
        private const byte PICCAPDU = 0x2C;
        private const byte PICCTPCL = 0x2E;

        private const byte PICCRMULEAD_A = 0x27;
        private const byte PICCMULWRITE_A = 0x28;

        //ST SR
        private const byte ST_SR_ACTIVE = 0x47;
        private const byte ST_SR_READ = 0x48;
        private const byte ST_SR_WRITE = 0x49;

        //Ultralight/C
        private const byte PICC_MF0_AUTHENTICATE = 0x31;
        private const byte PICC_MF0_CHANGEKEY = 0x32;

        //ISO7816
        private const byte ICCPOWERUP_ISO = 0x61;
        private const byte ICCPOWEROFF = 0x64;
        private const byte ICCAPDU = 0x65;
        private const byte ICCCHECK_PRES = 0x68;
        private const byte ICCSETBAUDRATE = 0x6B;

        //Mifare Desfire(MF3 IC D41)
        private const byte PICC_MF3_AUTHENTICATE = 0x81;
        private const byte PICC_MF3_GETKEYSETTING = 0x82;
        private const byte PICC_MF3_CHANGEKEY = 0x83;
        private const byte PICC_MF3_CHANGEKEYSET = 0x84;
        private const byte PICC_MF3_GETKEYVER = 0x85;
        private const byte PICC_MF3_CREATEAPP = 0x86;
        private const byte PICC_MF3_DELETEAPP = 0x87;
        private const byte PICC_MF3_GETAPPIDS = 0x88;
        private const byte PICC_MF3_SELECTAPP = 0x89;
        private const byte PICC_MF3_FORMATPICC = 0x8A;
        private const byte PICC_MF3_GETVERSION = 0x8B;
        private const byte PICC_MF3_GETFILEIDS = 0x8C;
        private const byte PICC_MF3_GETFILESET = 0x8D;
        private const byte PICC_MF3_CHANGEFILESET = 0x8E;
        private const byte PICC_MF3_CREATESTDDTFL = 0x8F;

        private const byte PICC_MF3_CREATEBKPDTFL = 0x90;
        private const byte PICC_MF3_CREATEVALUEFL = 0x91;
        private const byte PICC_MF3_CREATELNRRECFL = 0x92;
        private const byte PICC_MF3_CREATECYCRECFL = 0x93;
        private const byte PICC_MF3_DELETEFILE = 0x94;
        private const byte PICC_MF3_REAdDATA = 0x95;
        private const byte PICC_MF3_WRITEDATA = 0x96;
        private const byte PICC_MF3_GETVALUE = 0x97;
        private const byte PICC_MF3_CREDIT = 0x98;
        private const byte PICC_MF3_DEBIT = 0x99;
        private const byte PICC_MF3_LIMITEDCREDIT = 0x9A;
        private const byte PICC_MF3_WRITERECORD = 0x9B;
        private const byte PICC_MF3_READRECORD = 0x9C;
        private const byte PICC_MF3_CLEARRECORDFILE = 0x9D;
        private const byte PICC_MF3_COMMITTRANS = 0x9E;
        private const byte PICC_MF3_ABORTTRANS = 0x9F;

        //IOS15693
        private const byte I2_INVENTORY = 0xA1;
        private const byte I2_STAYQUIET = 0xA2;
        private const byte I2_READ_BLOCK = 0xA3;
        private const byte I2_WRITE_BLOCK = 0xA4;
        private const byte I2_LOCK_BLOCK = 0xA5;
        private const byte I2_SELECTCARD = 0xA6;
        private const byte I2_WRITE_AFI = 0xA8;
        private const byte I2_LOCK_AFI = 0xA9;
        private const byte I2_WRITE_DSFID = 0xAA;
        private const byte I2_LOCK_DSFID = 0xAB;
        private const byte I2_GET_SYSTEM_INFO = 0xAC;

        //ISO18000
        private const byte ISO18000P3M3_INVENTORY = 0xB1;
        private const byte ISO18000P3M3_ACK = 0xB2;
        private const byte ISO18000P3M3_REQRN = 0xB3;
        private const byte ISO18000P3M3_READ = 0xB4;
        private const byte ISO18000P3M3_WRITE = 0xB5;
        private const byte ISO18000P3M3_KILL = 0xB6;
        private const byte ISO18000P3M3_LOCK = 0xB7;
        private const byte ISO18000P3M3_ACCESS = 0xB8;
        private const byte ISO18000P3M3_BLOCKWRITE = 0xB9;
        private const byte ISO18000P3M3_BLOCKERASE = 0xBA;
        private const byte ISO18000P3M3_BLOCKPERMALOCK = 0xBB;
        private const byte ISO18000P3M3_SETHANDLE = 0xBC;

        private SerialPort port;
        private bool isTimeout;
        public PCSCDEV pcsc_dev = null;

        private int protocol_sel = 0; //0 is the serial port, 1 is pcsc
        private int RevTimeout = 3000;
        private bool __pcsc_interface_open = false;
        public delegate void CallbackDelegate(string message);
        /*
         
             try
                {
                    pcsc_dev = new PCSCDEV();
                    //获取读卡器列表
                    List<string> readers = pcsc_dev.initPcsc_dev();
                    //初始化卡片
                    pcsc_dev.iniCPUCard(readers);
                    byte[] sw12 = new byte[2];
                    byte[] retMessage = new byte[256];
                    //发送APDU指令
                    retMessage = pcsc_dev.pcsc_sendAPDU("00A4040008A00000033301010100", sw12);
                    pcsc_dev.closePcsc_dev();
                }
                catch
                {
                }
                finally
                {
                    if (pcsc_dev != null)
                    {
                        pcsc_dev.closePcsc_dev();
                    }
                }

             */
        public Api()
        {
            __pcsc_interface_open = false;
            port = new SerialPort();
            pcsc_dev = new PCSCDEV();
        }

        public int RevTimeout_Val
        {
            set { RevTimeout = value; }
            get { return RevTimeout; }
        }

        public bool pcsc_interface_open
        {
            set { __pcsc_interface_open = value; }
            get { return __pcsc_interface_open; }
        }

        public int openCard(string card_name)
        {
            //Initialize the RFID card
            protocol_sel = 1;

            return pcsc_dev.iniCPUCard(card_name);
        }
        public void closePcsc()
        {
            if (pcsc_dev != null)
                pcsc_dev.closePcsc_dev();
        }

        public void closeCard()
        {
            if (pcsc_dev != null)
                pcsc_dev.closePcsc_card();
        }

        public int openPort(string portName, int baudrate, byte dataBits, Parity parity, StopBits stopBits)
        {
            protocol_sel = 0;
            try
            {
                port.PortName = portName;
                port.BaudRate = baudrate;
                port.DataBits = dataBits;
                port.Parity = parity;
                port.StopBits = stopBits;
                port.ReadTimeout = READ_TIMEOUT;
                port.Open();
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public void closePort()
        {
            if (port.IsOpen)
            {
                port.Close();
            }
        }

        private byte makeCRC(byte[] data, int start, int end)
        {
            byte crc = 0x00;
            for (int i = start; i < end; i++)
            {
                crc ^= data[i];
            }
            return crc;
        }

        private byte makeXor(byte[] data, int start, int end)
        {
            byte ret = 0x00;
            for (int i = start; i < end; i++)
            {
                ret ^= data[i];
            }
            return ret;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            isTimeout = true;
        }

        private int serial_optFunction(byte cmd, byte addr, byte[] inData, int inLen, byte[] outData, out int outLen, CallbackDelegate callBack)
        {
            byte[] inBuffer = new byte[BUFFER_SIZE];
            byte[] outBuffer = new byte[2048];
            int ret = 0;
            string info = "";
            if (Authority_count++ >= AUTHORITY_COUNT)
            {
                //      outLen = 0;
                //    return ERR_FORMAT;
            }
            outLen = 0;
            if (inData != null)
            {
                inLen = inData.Length;
            }
            else
            {
                inLen = 0;
            }
            inBuffer[0] = STX;
            inBuffer[1] = (byte)((inLen >> 8) & 0xFF);
            inBuffer[2] = (byte)(inLen & 0xFF);
            inBuffer[3] = cmd;
            for (int i = 0; i < inLen; i++)
            {
                inBuffer[4 + i] = inData[i];
            }
            inBuffer[4 + inLen] = makeXor(inBuffer, 0, 4 + inLen);
            if (port.IsOpen)
            {
                //Clear previous buffer data before sending
                if (port.BytesToRead > 0 && port.BytesToRead < 2048)
                    port.Read(outBuffer, 0, port.BytesToRead);
                port.Write(inBuffer, 0, 5 + inLen);
            }
            else
            {
                ret = ERR_COM;
                if (callBack != null)
                {
                    callBack("Communication port is not open\r\n");
                }
                goto end;
            }

            if (callBack != null)
            {
                info = ">>  ";
                for (int i = 0; i < 5 + inLen; i++)
                {
                    info += String.Format("{0:X2} ", inBuffer[i]);
                }
                info += "\r\n";
                callBack(info);
            }

            System.Timers.Timer timer = new System.Timers.Timer(RevTimeout);
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = false;
            timer.Enabled = true;
            isTimeout = false;
            int intPos = 0;
            int intLen = 0;
            timer.Start();
            while (!isTimeout)
            {
                int count = port.BytesToRead;
                if (count > 0)
                {
                    try
                    {
                        int readCount = 0;
                        readCount = port.Read(outBuffer, intPos, count);
                        intPos += readCount;
                        if (intLen == 0 && intPos >= 3)
                        {
                            intLen = outBuffer[1];
                            intLen = (intLen << 8) | outBuffer[2] + 5; //Accepted data total length
                        }
                        if (intLen >= 2048)
                        {
                            intLen = 2048 - 1;
                            break;
                        }
                        if (intPos != 0 && intPos >= intLen)
                        {    //Read all data
                            break;
                        }
                    }
                    catch (TimeoutException)
                    {
                        intPos = 0;
                        break;
                    }
                }
                Thread.Sleep(50);
            }
            timer.Stop();
            if (callBack != null)
            {
                info = "<<  ";
                if (intLen == 0)
                {
                    intLen = 0;
                }
                for (int i = 0; i < intLen; i++)
                {
                    info += String.Format("{0:X2} ", outBuffer[i]);
                }
                info += "---";

            }

            outLen = 0;
            if (outBuffer[3] == 0x27)
            {
                outLen = 0;
            }
            if (intPos >= 5)   //Data returned, verify the returned data
            {
                byte r_xor = makeXor(outBuffer, 0, intLen - 1);
                if (outBuffer[0] != STX && outBuffer[0] != STX_ERR)
                {
                    ret = ERR_FORMAT;
                    goto end;
                }
                else
                {
                    if (r_xor == outBuffer[intLen - 1])//Received a properly formatted command
                    {
                        intLen = outBuffer[1];
                        intLen = (intLen << 8) | outBuffer[2] + 5; //Accepted data total length
                        if (intLen >= 5)
                        {
                            outLen = intLen - 5;

                            if (outData != null && outLen < 2048)
                            {
                                Array.Copy(outBuffer, 4, outData, 0, outLen); //Copy the received data part to outData
                            }

                            if (outBuffer[0] == STX)
                            {
                                ret = 0;
                                goto end;//Return correctly
                            }
                            else
                            {
                                if (outData != null)
                                {
                                    ret = outData[0];
                                    goto end;//Return error code
                                }
                                else
                                {
                                    ret = ERR_ACK;
                                    goto end;
                                }

                            }

                        }
                        else
                        {
                            outLen = 0;
                            ret = ERR_ACK;
                            goto end;
                        }
                    }
                    ret = ERR_FORMAT;
                }

            }
            else
            {
                ret = ERR_TIMEOUT;//No data received timed out
            }

        end:
            if (ret == 0)
            {
                info += "success\r\n";

            }
            else
            {

                info += "failure\r\n";
            }

            callBack?.Invoke(info);
            return ret;

        }
        public void pcsc_transparent(byte[] sendBuff, CallbackDelegate callBack)
        {
            string info = "";
            byte[] outBuffer = null;
            outBuffer = pcsc_dev.pcsc_WriteRead(sendBuff, sendBuff.Length);
            if (callBack != null && sendBuff != null)
            {
                info = ">>  ";
                for (int i = 0; i < sendBuff.Length; i++)
                {
                    info += String.Format("{0:X2} ", sendBuff[i]);
                }
                info += "\r\n";

            }
            if (callBack != null && outBuffer != null)
            {
                info += "<<  ";

                for (int i = 0; i < outBuffer.Length; i++)
                {
                    info += String.Format("{0:X2} ", outBuffer[i]);
                }

                info += "\r\n";
            }
            callBack?.Invoke(info);
        }
        private int pcsc_optFunction(byte cmd, byte addr, byte[] inData, int inLen, byte[] outData, out int outLen, CallbackDelegate callBack)
        {
            byte[] inBuffer = new byte[BUFFER_SIZE];
            byte[] outBuffer = null;
            int ret = 0;
            string info = "";
            if (Authority_count++ >= AUTHORITY_COUNT)
            {
                //      outLen = 0;
                //    return ERR_FORMAT;
            }


            outLen = 0;
            if (inData != null)
            {
                inLen = inData.Length;
            }
            else
            {
                inLen = 0;
            }
            inBuffer[0] = STX;
            inBuffer[1] = (byte)((inLen >> 8) & 0xFF);
            inBuffer[2] = (byte)(inLen & 0xFF);
            inBuffer[3] = cmd;
            for (int i = 0; i < inLen; i++)
            {
                inBuffer[4 + i] = inData[i];
            }
            inBuffer[4 + inLen] = makeXor(inBuffer, 0, 4 + inLen);
            if (pcsc_dev.runResult == 0)
            {
                outBuffer = pcsc_dev.pcsc_WriteRead(inBuffer, 5 + inLen);
            }
            else
            {
                ret = ERR_COM;
                if (callBack != null)
                {
                    callBack("Communication port is not open\r\n");
                }
                goto end;
            }

            if (callBack != null)
            {
                info = ">>  ";
                for (int i = 0; i < 5 + inLen; i++)
                {
                    info += String.Format("{0:X2} ", inBuffer[i]);
                }
                info += "\r\n";
                callBack(info);
            }

            if (callBack != null && outBuffer != null)
            {
                info = "<<  ";

                for (int i = 0; i < outBuffer.Length; i++)
                {
                    info += String.Format("{0:X2} ", outBuffer[i]);
                }
                info += "---";

            }


            if (outBuffer != null && outBuffer[3] == 0x27)
            {
                outLen = 0;
            }
            if (outBuffer != null)   //Data returned, verify the returned data
            {
                byte r_xor = makeXor(outBuffer, 0, outBuffer.Length - 1);
                if (outBuffer[0] != STX && outBuffer[0] != STX_ERR)
                {
                    ret = ERR_FORMAT;
                    goto end;
                }
                else
                {
                    if (r_xor == outBuffer[outBuffer.Length - 1])//Received a properly formatted command
                    {
                        int intLen;
                        intLen = outBuffer[1];
                        intLen = (intLen << 8) | outBuffer[2] + 5; //Accepted data total length
                        if (intLen >= 5)
                        {
                            outLen = intLen - 5;

                            if (outData != null && outLen < 2048)
                            {
                                Array.Copy(outBuffer, 4, outData, 0, outLen); //Copy the received data part to outData
                            }

                            if (outBuffer[0] == STX)
                            {
                                ret = 0;
                                goto end;//Return correctly
                            }
                            else
                            {
                                if (outData != null)
                                {
                                    ret = outData[0];
                                    goto end;//Return error code
                                }
                                else
                                {
                                    ret = ERR_ACK;
                                    goto end;
                                }

                            }

                        }
                        else
                        {
                            outLen = 0;
                            ret = ERR_ACK;
                            goto end;
                        }
                    }
                    ret = ERR_FORMAT;
                }

            }
            else
            {
                ret = ERR_TIMEOUT;//No data received timed out
            }

        end:
            if (ret == 0)
            {
                info += "success\r\n";

            }
            else
            {

                info += "failure\r\n";
            }

            callBack?.Invoke(info);
            return ret;
        }
        /*	Parameter: cmd command
                 addr: 485 address as communication, can be ignored when not 485
                 inData: buffer for the data portion of the command
                 inLen: data length in the command
                 outData: returns the buffer of the data part of the command
                 outLen: return the data length in the command
                 Returns: if not 0, then inLen = 1 and outData [0] = err code
        */
        private int optFunction(byte cmd, byte addr, byte[] inData, int inLen, byte[] outData, out int outLen, CallbackDelegate callBack)
        {

            if (protocol_sel == 0)
                return serial_optFunction(cmd, addr, inData, inLen, outData, out outLen, callBack);
            else
                return pcsc_optFunction(cmd, addr, inData, inLen, outData, out outLen, callBack);

        }


        public int reset_Test(byte cmd, byte addr, byte[] inData, int inLen, byte[] outData, out int outLen, CallbackDelegate callBack)
        {

            return optFunction(cmd, addr, inData, 0, outData, out outLen, callBack);
        }
        public int GetFWVersion(byte[] version, out int versionLen, CallbackDelegate callBack)
        {

            return optFunction(GET_FW_VERSION, 0, null, 0, version, out versionLen, callBack);

        }
        public int GetHWVersion(byte[] version, out int versionLen, CallbackDelegate callBack)
        {
            return optFunction(GET_HW_VERSION, 0, null, 0, version, out versionLen, callBack);
        }

        public int GetHidIclass_uid(byte[] uid, out int uidLen, CallbackDelegate callBack)
        {
            return optFunction(GET_HID_ICLASS_UID, 0, null, 0, uid, out uidLen, callBack);
        }

        public int GetVersion(byte addr, byte[] version, out int versionLen, out byte resStatus, CallbackDelegate callBack)
        {
            byte[] outData = new byte[BUFFER_SIZE];
            int outLen;

            int result = optFunction(21, addr, null, 0, outData, out outLen, callBack);
            versionLen = 0;
            resStatus = 0;
            if (result != 0)
            {
                resStatus = outData[0];
            }
            else
            {
                versionLen = outLen;
                Array.Copy(outData, version, versionLen);
            }
            return result;
        }

        /*
         * active card
         * use this fuction to activate the card before any other command, PICCACTIVATE will run REQA, Anti-collision and Select sequence as defined in ISO/IEC 14443_3 document
         *  PICCACTIVATE(CMD=0x22)
         */
        public int piccActivate(Byte ucRst_ms, Byte ucReqCode, Byte[] pATQ, out Byte pSAK, out int pUIDLen, Byte[] pUID, CallbackDelegate call)
        {
            Byte[] inData = { ucRst_ms, ucReqCode };
            Byte[] outData = new Byte[100];
            int outLen;
            int ret = 0;
            ret = optFunction(PICCACTIVATE, 0, inData, inData.Length, outData, out outLen, call);
            if (ret == 0)
            {
                pATQ[0] = outData[0];
                pATQ[1] = outData[1];
                pSAK = outData[2];
                pUIDLen = outData[3];
                if (outLen >= 4)
                {
                    pUIDLen = outLen - 4;
                    Array.Copy(outData, 4, pUID, 0, pUIDLen);
                }
                else
                {
                    pUIDLen = 0;
                }
            }
            else
            {
                pUIDLen = 0;
                pSAK = 0;
            }
            return ret;
        }
        static void send_activate()
        {

        }
        public int piccReset(Byte ucRst_ms, CallbackDelegate callBack)
        {
            Byte[] inData = { ucRst_ms };
            Byte[] outData = new Byte[7];
            int ret = 0;
            int outLen;
            ret = optFunction(PICCRESET, 0, inData, 1, outData, out outLen, callBack);
            return 0;
        }

        public int piccRequestATS(Byte ucRFU, out int pATSLen, Byte[] pATS, CallbackDelegate callBack)
        {
            Byte[] inData = { };
            Byte[] outData = new Byte[100];
            int ret = 0;
            int outLen;
            ret = optFunction(PICCRATS, 0, inData, 0, outData, out outLen, callBack);
            Array.Copy(outData, pATS, outLen);
            pATSLen = outLen;
            return ret;
        }

        private int piccSendRevfunc(Byte cmd, uint usSendLen, Byte[] pSendBuf, out uint pRcvLen, Byte[] pRcvBuf, CallbackDelegate callBack)
        {
            Byte[] inData = new Byte[usSendLen];
            if (pSendBuf != null)
                Array.Copy(pSendBuf, inData, usSendLen);

            int ret = 0;
            int outLen;
            ret = optFunction(cmd, 0, inData, inData.Length, pRcvBuf, out outLen, callBack);

            pRcvLen = (uint)outLen;
            return ret;
        }
        public int piccAPDU(uint usSendLen, Byte[] pSendBuf, out uint pRcvLen, Byte[] pRcvBuf, CallbackDelegate callBack)
        {
            return piccSendRevfunc(PICCAPDU, usSendLen, pSendBuf, out pRcvLen, pRcvBuf, callBack);
        }

        public int piccTPCL(uint usSendLen, Byte[] pSendBuf, out uint pRcvLen, Byte[] pRcvBuf, CallbackDelegate callBack)
        {
            return piccSendRevfunc(PICCTPCL, usSendLen, pSendBuf, out pRcvLen, pRcvBuf, callBack);
        }

        // PICC_MF3_AUTHENTICATE(CMD=0x81)
        public int desAuthenticate(Byte KeyNO, Byte[] pKey, CallbackDelegate callBack)
        {
            Byte[] inData = new Byte[pKey.Length + 1];
            inData[0] = KeyNO;
            Array.Copy(pKey, 0, inData, 1, pKey.Length);
            Byte[] outData = new Byte[5];
            int outLen;
            return optFunction(PICC_MF3_AUTHENTICATE, 0, inData, inData.Length, outData, out outLen, callBack);
        }

        //PICC_MF3_GETKEYSETTING(CMD=0x82)
        public int desGetKeySetting(out Byte pKeySetting, out byte pKeyNum, CallbackDelegate callBack)
        {
            int outLen;
            pKeySetting = 0;
            pKeyNum = 0;
            Byte[] revbuff = new Byte[2];
            int ret = optFunction(PICC_MF3_GETKEYSETTING, 0, null, 0, revbuff, out outLen, callBack);
            if (ret == 0)
            {

                pKeySetting = revbuff[0];
                pKeyNum = revbuff[1];

            }
            return ret;
        }

        //PICC_MF3_CHANGEKEY(CMD=0x83)
        public int desChangKey(Byte KeyNo, Byte KeySettings, Byte[] pNewKey, Byte[] pOldKey, CallbackDelegate callBack)
        {
            Byte[] inData = new Byte[pNewKey.Length + pOldKey.Length + 2];
            inData[0] = KeyNo;
            inData[1] = KeySettings;
            Array.Copy(pNewKey, 0, inData, 2, pNewKey.Length);
            Array.Copy(pOldKey, 0, inData, 2 + pNewKey.Length, pOldKey.Length);
            Byte[] outData = new Byte[5];
            int outLen;
            return optFunction(PICC_MF3_CHANGEKEY, 0, inData, inData.Length, outData, out outLen, callBack);
        }


        //PICC_MF3_CHANGEKEYSET(CMD=0x84)
        public int desChangKeySetting(Byte KeySetting, CallbackDelegate callBack)
        {
            Byte[] inData = { KeySetting };
            int outLen;
            return optFunction(PICC_MF3_CHANGEKEYSET, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //PICC_MF3_GETKEYVER(CMD= 0x85)
        public int desGetKeyVersion(Byte KeyNO, Byte[] pKeyVersion, CallbackDelegate callBack)
        {
            Byte[] inData = { KeyNO };
            int outLen;
            return optFunction(PICC_MF3_GETKEYVER, 0, inData, inData.Length, pKeyVersion, out outLen, callBack);
        }

        //PICC_MF3_CREATEAPP(CMD=0x86)
        public int desCreateApplication(Byte[] AID, Byte KeySetting, Byte KeyNo, CallbackDelegate callBack)
        {

            Byte[] inData = { AID[0], AID[1], AID[2], KeySetting, KeyNo };
            int outLen;
            Byte[] outData = new Byte[5];
            return optFunction(PICC_MF3_CREATEAPP, 0, inData, inData.Length, outData, out outLen, callBack);
        }

        private int desApplication(Byte cmd, Byte[] AID, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.AddRange(AID);
            int outLen;
            return optFunction(cmd, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        //PICC_MF3_DELETEAPP(CMD=0x87)
        public int desDeleteApplication(Byte[] AID, CallbackDelegate callBack)
        {
            return desApplication(PICC_MF3_DELETEAPP, AID, callBack);
        }

        private int getItems(Byte cmd, Byte[] items, out Byte size, CallbackDelegate callBack)
        {
            Byte[] inData = { };
            int outLen;
            Byte[] outData = new Byte[256];
            int ret;
            ret = optFunction(cmd, 0, inData, inData.Length, outData, out outLen, callBack);
            if (outLen > 0)
            {
                size = outData[0];
                if (size > 0)
                    Array.Copy(outData, 1, items, 0, outLen - 1);
            }
            else
            {
                size = 0;
            }
            return ret;
        }
        //PICC_MF3_GETAPPIDS(CMD=0x88)
        public int desGetApplicationIDs(Byte[] pAIDs, out Byte pAIDno, CallbackDelegate callBack)
        {
            return getItems(PICC_MF3_GETAPPIDS, pAIDs, out pAIDno, callBack);
        }

        //PICC_MF3_SELECTAPP(CMD=0x89)
        public int desSelectApplication(Byte[] AID, CallbackDelegate callBack)
        {
            return desApplication(PICC_MF3_SELECTAPP, AID, callBack);
        }

        //PICC_MF3_FORMATPICC(CMD=0x8A)
        public int desFormatPicc(CallbackDelegate callBack)
        {
            int outLen;
            return optFunction(PICC_MF3_FORMATPICC, 0, null, 0, null, out outLen, callBack);
        }

        //PICC_MF3_GETVERSION(CMD= 0x8B)
        public int desGetDESVersion(out uint relen, Byte[] rebuf, CallbackDelegate callBack)
        {
            return piccSendRevfunc(PICC_MF3_GETVERSION, 0, null, out relen, rebuf, callBack);
        }

        //PICC_MF3_GETFILEIDS(CMD= 0x8C)
        public int desGetFileIDs(out Byte pIDs, Byte[] pFileIDs, CallbackDelegate callBack)
        {
            return getItems(PICC_MF3_GETFILEIDS, pFileIDs, out pIDs, callBack);
        }

        //PICC_MF3_GETFILESET(CMD=0x8D)
        public int desGetFileSettings(Byte FileID, out uint pInfoLen, Byte[] pFileInfo, CallbackDelegate callback)
        {
            Byte[] inData = { FileID };
            return piccSendRevfunc(PICC_MF3_GETFILESET, (uint)inData.Length, inData, out pInfoLen, pFileInfo, callback);
        }

        //PICC_MF3_CHANGEFILESET(CMD= 0x8E)
        public int desChangeFileSettings(Byte FileID, Byte NewComSet, ushort NewAccessRights, CallbackDelegate callBack)
        {
            Byte high_byte = (Byte)(NewAccessRights >> 8);
            Byte low_byte = (Byte)(NewAccessRights & 0xFF);
            Byte[] inData = { FileID, NewComSet, low_byte, high_byte };
            int outLen;
            return optFunction(PICC_MF3_CHANGEFILESET, 0, inData, inData.Length, null, out outLen, callBack);
        }

        private int desCreateFile(Byte cmd, Byte FileID, Byte ComSet, Byte[] AccessRights, Byte[] FileSize, CallbackDelegate callBack)
        {

            Byte[] inData = { FileID, ComSet, AccessRights[0], AccessRights[1], FileSize[0], FileSize[1] };
            int outLen;
            return optFunction(cmd, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //PICC_MF3_CREATESTDDTFL(CMD=0x8F)
        public int desCreateStdDataFile(Byte FileID, Byte ComSet, Byte[] AccessRights, Byte[] FileSize, CallbackDelegate callBack)
        {
            return desCreateFile(PICC_MF3_CREATESTDDTFL, FileID, ComSet, AccessRights, FileSize, callBack);
        }

        //PICC_MF3_CREATEBKPDTFL(CMD=0x90)
        public int desCreateBackupDataFile(Byte FileID, Byte ComSet, Byte[] AccessRights, Byte[] FileSize, CallbackDelegate callBack)
        {
            return desCreateFile(PICC_MF3_CREATEBKPDTFL, FileID, ComSet, AccessRights, FileSize, callBack);
        }

        //PICC_MF3_CREATEVALUEFL(CMD=0x91)
        public int desCreateValueFile(Byte FileID, Byte ComSet, ushort AccessRights, uint LowerLimit,
            uint UpperLimit, uint Value, Byte LimitCredit, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(ComSet);
            byteSource.AddRange(BitConverter.GetBytes(AccessRights));
            Byte[] LowerLimit_bytes = BitConverter.GetBytes(LowerLimit);
            Byte[] UpperLimit_bytes = BitConverter.GetBytes(UpperLimit);
            Byte[] Value_bytes = BitConverter.GetBytes(Value);
            byteSource.AddRange(LowerLimit_bytes);
            byteSource.AddRange(UpperLimit_bytes);
            byteSource.AddRange(Value_bytes);
            byteSource.Add(LimitCredit);
            int outLen;
            return optFunction(PICC_MF3_CREATEVALUEFL, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        //PICC_MF3_CREATELNRRECFL(CMD= 0x92)
        public int desCreateLinearRecordFile(Byte FileID, Byte ComSet, ushort AccessRights, ushort FileSize,
            ushort RecordsNum, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(ComSet);
            byteSource.AddRange(BitConverter.GetBytes(AccessRights)); ;
            byteSource.AddRange(BitConverter.GetBytes(FileSize));
            byteSource.AddRange(BitConverter.GetBytes(RecordsNum));
            int outLen;
            return optFunction(PICC_MF3_CREATELNRRECFL, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }


        //PICC_MF3_CREATECYCRECFL(CMD= 0x93)
        public int DESCreateCyclicRecordFile(Byte FileID, Byte ComSet, ushort AccessRights, ushort FileSize,
            ushort RecordsNum, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(ComSet);
            byteSource.AddRange(BitConverter.GetBytes(AccessRights)); ;
            byteSource.AddRange(BitConverter.GetBytes(FileSize));
            byteSource.AddRange(BitConverter.GetBytes(RecordsNum));
            int outLen;
            return optFunction(PICC_MF3_CREATECYCRECFL, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        //PICC_MF3_DELETEFILE(CMD= 0x94)
        public int desDeleteDESFile(Byte FileID, CallbackDelegate callBack)
        {
            Byte[] inData = BitConverter.GetBytes(FileID);
            int outLen;
            return optFunction(PICC_MF3_DELETEFILE, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //PICC_MF3_REAdDATA(CMD=0x95)
        public int desReadData(Byte FileID, Byte comset, ushort Offset, ushort Length, Byte[] pBuf, out ushort RcvLen, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(comset);
            byteSource.AddRange(BitConverter.GetBytes(Offset));
            byteSource.AddRange(BitConverter.GetBytes(Length));
            int ret;
            int outLen;
            ret = optFunction(PICC_MF3_REAdDATA, 0, byteSource.ToArray(), byteSource.Count, pBuf, out outLen, callBack);
            RcvLen = (ushort)outLen;
            return ret;
        }

        private int desWrite(Byte cmd, Byte FileID, Byte comset, ushort Offset, ushort Length, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(comset);
            byteSource.AddRange(BitConverter.GetBytes(Offset));
            byteSource.AddRange(BitConverter.GetBytes(Length));
            byteSource.AddRange(pBuf);
            int outLen;
            return optFunction(cmd, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        //PICC_MF3_WRITEDATA(CMD= 0x96)
        public int desWriteData(Byte FileID, Byte comset, ushort Offset, ushort Length, Byte[] pBuf, CallbackDelegate callBack)
        {
            return desWrite(PICC_MF3_WRITEDATA, FileID, comset, Offset, Length, pBuf, callBack);
        }

        //PICC_MF3_GETVALUE(CMD=0x97)
        public int DESGetValue(Byte FileID, Byte comset, out int Value, CallbackDelegate callback)
        {
            uint outLen;
            Byte[] inData = { FileID, comset };
            Byte[] outData = new Byte[4];
            int ret;
            ret = piccSendRevfunc(PICC_MF3_GETVALUE, (uint)inData.Length, inData, out outLen, outData, callback);
            Value = BitConverter.ToInt32(outData, 0);
            return ret;
        }

        //PICC_MF3_CREDIT(CMD=0x98)
        //PICC_MF3_DEBIT(CMD=0x99)
        //PICC_MF3_LIMITEDCREDIT(CMD=0x9A)
        public int desOperateValue(Byte cmd, Byte FileID, Byte comset, Byte ValueCommand, long Value, CallbackDelegate callBack)
        {
            Byte[] Value_byte = BitConverter.GetBytes(Value);
            int outLen;
            Byte[] inData = { FileID, comset, Value_byte[0], Value_byte[1], Value_byte[2], Value_byte[3] };
            return optFunction(cmd, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //PICC_MF3_WRITERECORD(CMD= 0x9B)
        public int desWriteRecord(Byte FileID, Byte comset, ushort Offset, ushort Length, Byte[] pBuf, CallbackDelegate callBack)
        {
            return desWrite(PICC_MF3_WRITERECORD, FileID, comset, Offset, Length, pBuf, callBack);
        }

        //PICC_MF3_READRECORD(CMD= 0x9C)
        public int desReadRecord(Byte FileID, Byte comset, ushort RecordNo, ushort RecordNum, Byte[] pBuf, out int RcvLen, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(FileID);
            byteSource.Add(comset);
            byteSource.AddRange(BitConverter.GetBytes(RecordNo)); ;
            byteSource.AddRange(BitConverter.GetBytes(RecordNum));
            return optFunction(PICC_MF3_READRECORD, 0, byteSource.ToArray(), byteSource.Count, pBuf, out RcvLen, callBack);
        }


        //PICC_MF3_CLEARRECORDFILE(CMD=0x9D)

        public int desClearRecordFile(Byte FileID, CallbackDelegate callBack)
        {
            Byte[] inData = BitConverter.GetBytes(FileID);
            int outLen;
            return optFunction(PICC_MF3_CLEARRECORDFILE, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //PICC_MF3_COMMITTRANS(CMD=0x9E)
        //PICC_MF3_ABORTTRANS(CMD= 0x9F)
        public int desTransaction(Byte Command, CallbackDelegate callback)
        {

            int outLen;
            return optFunction(Command, 0, null, 0, null, out outLen, callback);
        }

        //I2_INVENTORY
        public int ISO15693_Inventory(Byte flags, Byte AFI, Byte masklengh, Byte[] uid,
            out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.Add(AFI);
            byteSource.Add(masklengh);
            if (masklengh > 0)
            {
                byteSource.AddRange(uid);
            }
            return optFunction(I2_INVENTORY, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }
        //I2_SELECTCARD
        public int ISO15693_SelectCard(Byte flags, Byte[] Cardid,
           out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.AddRange(Cardid);
            return optFunction(I2_SELECTCARD, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }

        //I2_STAYQUIET
        public int ISO15693_Stayquiet(Byte flags, Byte[] Cardid,
           out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.AddRange(Cardid);
            return optFunction(I2_STAYQUIET, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }
        //I2_READ_BLOCK
        public int ISO15693_Read_Block(Byte flags, Byte blnr, Byte nbl, Byte[] uid,
            out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.Add(blnr);
            byteSource.Add(nbl);
            if (flags == 0x22)
            {
                if (uid.Length == 8)//8 bytes is needed 
                    byteSource.AddRange(uid);
                else
                {
                    resplen = 0;
                    return ERR_PARAM;
                }
            }
            return optFunction(I2_READ_BLOCK, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }

        //I2_WRITE_BLOCK
        public int ISO15693_Write_Block(Byte flags, Byte blnr, Byte nbl, Byte[] uid,
            Byte[] dtw, out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.Add(blnr);
            byteSource.Add(nbl);
            if (flags == 0x22)
            {
                if (uid.Length == 8)//8 bytes is needed 
                    byteSource.AddRange(uid);
                else
                {
                    resplen = 0;
                    return ERR_PARAM;
                }
            }
            /*           if (dtw.Length < nbl * 4)
                        {
                            byteSource.AddRange(dtw);
                        }
                        else
                        {
                            Array.Resize(ref dtw, nbl * 4); //Redefine dtw size
                            byteSource.AddRange(dtw);
                        }
            */
            byteSource.AddRange(dtw);
            return optFunction(I2_WRITE_BLOCK, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }

        //I2_LOCK_BLOCK
        public int ISO15693_Lock_Block(Byte flags, Byte blnr, Byte[] uid,
             out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            byteSource.Add(blnr);
            if (flags == 0x22)
            {
                if (uid.Length == 8)//8 bytes is needed 
                    byteSource.AddRange(uid);
                else
                {
                    resplen = 0;
                    return ERR_PARAM;
                }
            }
            return optFunction(I2_LOCK_BLOCK, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }

        private int ISO15693_Fun(Byte cmd, Byte flags, Byte[] param, Byte[] uid,
              out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(flags);
            if (param != null)
                byteSource.AddRange(param);
            if (flags == 0x22)
            {
                if (uid.Length == 8)//8 bytes is needed 
                    byteSource.AddRange(uid);
                else
                {
                    resplen = 0;
                    return ERR_PARAM;
                }
            }
            return optFunction(cmd, 0, byteSource.ToArray(), byteSource.Count, resp, out resplen, callBack);
        }
        //I2_WRITE_AFI
        public int ISO15693_Write_AFI(Byte flags, Byte AFI, Byte[] uid,
              out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            Byte[] param = { AFI };
            return ISO15693_Fun(I2_WRITE_AFI, flags, param, uid, out resplen, resp, callBack);
        }

        //I2_LOCK_AFI
        public int ISO15693_Lock_AFI(Byte flags, Byte[] uid,
              out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            return ISO15693_Fun(I2_LOCK_AFI, flags, null, uid, out resplen, resp, callBack);
        }

        //I2_WRITE_DSFID
        public int ISO15693_Write_DSFID(Byte flags, Byte DSFID, Byte[] uid,
            out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            Byte[] param = { DSFID };
            return ISO15693_Fun(I2_WRITE_DSFID, flags, param, uid, out resplen, resp, callBack);
        }

        // I2_LOCK_DSFID
        public int ISO15693_Lock_DSFID(Byte flags, Byte[] uid,
            out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            return ISO15693_Fun(I2_LOCK_DSFID, flags, null, uid, out resplen, resp, callBack);
        }

        //I2_GET_SYSTEM_INFO
        public int ISO15693_Get_SysInfor(Byte flags, Byte[] uid,
            out int resplen, Byte[] resp, CallbackDelegate callBack)
        {
            return ISO15693_Fun(I2_GET_SYSTEM_INFO, flags, null, uid, out resplen, resp, callBack);
        }

        //SET_BUZZER
        public int SetBuzzer(Byte ucRates, Byte ucTimes, CallbackDelegate callBack)
        {
            Byte[] inData = { ucRates, ucTimes };
            int resplen;
            return optFunction(SET_BUZZER, 0, inData, inData.Length, null, out resplen, callBack);
        }

        //SET_LED
        public int SetLed(Byte ucRates, Byte ucTimes, CallbackDelegate callBack)
        {
            Byte[] inData = { ucRates, ucTimes };
            int resplen;
            return optFunction(SET_LED, 0, inData, inData.Length, null, out resplen, callBack);
        }

        public int piccActivateB(Byte ucRst_1ms, Byte ucAFI, Byte ucMethod,
            out int pUIDLen, Byte[] pUID, CallbackDelegate callBack)
        {
            Byte[] inData = { ucRst_1ms, ucAFI, ucMethod, 0x00 };
            return optFunction(PICCACTIVATE_B, 0, inData, inData.Length, pUID, out pUIDLen, callBack);
        }

        public int piccAuthKey(Byte auth_mode, Byte addr, Byte[] pSnr, Byte[] pKey, CallbackDelegate callBack)
        {

            List<byte> byteSource = new List<byte>();
            byteSource.Add(auth_mode);
            byteSource.Add(addr);
            byteSource.AddRange(pSnr);
            byteSource.AddRange(pKey);
            int outLen;
            return optFunction(PICCAUTHKEY, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }
        public int piccInitVL(Byte ucBlock, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            byteSource.AddRange(pBuf);
            int outLen;
            return optFunction(PICCINITVL, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        public int piccReadValue(Byte ucBlock, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            int outLen;
            return optFunction(PICCREADVL, 0, byteSource.ToArray(), byteSource.Count, pBuf, out outLen, callBack);
        }
        public int piccValueOper(Byte ucOperMode, Byte ucBlock,
               Byte[] pValue, Byte ucTransBlock, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucOperMode);
            byteSource.Add(ucBlock);
            byteSource.AddRange(pValue);
            byteSource.Add(ucTransBlock);
            int outLen;
            return optFunction(PICCVALUE_A, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        public int piccBackup(Byte ucBlock, Byte ucTransBlock, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            byteSource.Add(ucTransBlock);
            int outLen;
            return optFunction(PICCBAK_A, 0, byteSource.ToArray(), byteSource.Count, null, out outLen, callBack);
        }

        public int piccRead(Byte ucBlock, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            int outLen;
            return optFunction(PICCREAD_A, 0, byteSource.ToArray(), byteSource.Count, pBuf, out outLen, callBack);
        }

        public int piccWrite(Byte ucBlock, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            byteSource.AddRange(pBuf);
            int outLen;
            return optFunction(PICCWRITE_A, 0, byteSource.ToArray(), byteSource.Count, pBuf, out outLen, callBack);
        }
        public int piccWriteUL(Byte ucBlock, Byte[] pBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucBlock);
            byteSource.AddRange(pBuf);
            int outLen;
            return optFunction(PICCWRITE_UL, 0, byteSource.ToArray(), byteSource.Count, pBuf, out outLen, callBack);
        }
        public int iccPowerUp(Byte usCardSlot, out int pRecLen, Byte[] pRcvBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(usCardSlot);
            return optFunction(ICCPOWERUP_ISO, 0, byteSource.ToArray(), byteSource.Count, pRcvBuf, out pRecLen, callBack);
        }

        int iccPowerDn(Byte usCardSlot, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(usCardSlot);
            int ret_len;
            return optFunction(ICCPOWEROFF, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, callBack);
        }

        public int iccAPDU(Byte usCardSlot, int usSendLen, Byte[] pSendBuf, out uint pRcvLen,
            Byte[] pRcvBuf, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(usCardSlot);
            Byte[] tmp_send = new byte[usSendLen];
            Array.Copy(pSendBuf, tmp_send, usSendLen);
            byteSource.AddRange(tmp_send);
            return piccSendRevfunc(ICCAPDU, (uint)byteSource.Count, byteSource.ToArray(), out pRcvLen, pRcvBuf, callBack);
        }

        public int iccCheck_Pres(Byte usCardSlot, out Byte usStatus, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(usCardSlot);
            Byte[] outData = new Byte[10];
            int outlen, ret;
            ret = optFunction(ICCCHECK_PRES, 0, byteSource.ToArray(), byteSource.Count, outData, out outlen, callBack);
            if (ret == 0)
            {
                if (outlen >= 1)
                {
                    usStatus = outData[0];
                }
            }
            usStatus = 0;
            return ret;

        }

        public int iccSetInitBaudrate(Byte usCardSlot, Byte ucRates, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(usCardSlot);
            byteSource.Add(ucRates);
            int ret_len;
            return optFunction(ICCPOWEROFF, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, callBack);
        }

        public int setUARTBaudRate(Byte ucRates, CallbackDelegate callBack)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(ucRates);
            Byte[] outData = new Byte[5];
            int outLen;
            return optFunction(SET_UR_BAUDRATE, 0, byteSource.ToArray(), byteSource.Count, outData, out outLen, callBack);
        }

        public int piccULAuth(Byte[] pKey, CallbackDelegate callBack)
        {

            uint prlen;
            return piccSendRevfunc(PICC_MF0_AUTHENTICATE, (uint)pKey.Length, pKey, out prlen, null, callBack);
        }

        public int piccULSetKey(Byte[] pKey, CallbackDelegate callBack)
        {
            uint prlen;
            return piccSendRevfunc(PICC_MF0_CHANGEKEY, (uint)pKey.Length, pKey, out prlen, null, callBack);
        }

        public int piccITGRead(Byte rst_ms, Byte req_mode, Byte sector_begin, Byte sector_much,
                            Byte block_each, Byte auth_mode, Byte[] pKey, Byte[] pBuf, CallbackDelegate call)
        {
            uint prlen;
            List<byte> byteSource = new List<byte>();
            Byte[] inData = { rst_ms, req_mode, sector_begin, sector_much, block_each, auth_mode };
            byteSource.AddRange(inData);
            byteSource.AddRange(pKey);
            return piccSendRevfunc(PICCRMULEAD_A, (uint)byteSource.Count, byteSource.ToArray(), out prlen, pBuf, call);
        }

        //SETANT
        public int setANT(Byte status, CallbackDelegate callBack)
        {
            int outLen;
            Byte[] inData = { status };
            return optFunction(SETANT, 0, inData, inData.Length, null, out outLen, callBack);
        }

        //GETANT
        public int getANT(out Byte status, CallbackDelegate callBack)
        {
            int outLen;
            Byte[] outData = new Byte[1];
            int ret = optFunction(GETANTSTATUS, 0, null, 0, outData, out outLen, callBack);
            status = outData[0];
            return ret;
        }

        //ISO18000P3M3_INVENTORY
        public int ISO18000P3M3_Activate(out int rebInforLen, Byte[] rebInfo, out Byte pbM, out Byte pbDr, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();

            Byte[] out_data = new byte[50];
            int ret_len;
            int ret = optFunction(ISO18000P3M3_INVENTORY, 0, byteSource.ToArray(), byteSource.Count, out_data, out ret_len, call);
            if (ret == 0)
            {
                rebInforLen = ret_len - 2;
                Array.Copy(out_data, 2, rebInfo, 0, rebInforLen);
                pbM = out_data[0];
                pbDr = out_data[1];
            }
            else
            {
                rebInforLen = 0;
                pbM = 0;
                pbDr = 0;
            }

            return ret;
        }


        //ISO18000P3M3_ACK
        public int ISO18000P3M3_Ack(Byte[] pRxBuffer, out int pRxLength, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();

            return optFunction(ISO18000P3M3_ACK, 0, byteSource.ToArray(), byteSource.Count, pRxBuffer, out pRxLength, call);
        }

        //ISO18000P3M3_REQRN
        public int ISO18000P3M3_ReqRn(Byte[] pRxBuffer, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();

            int ret_len;
            return optFunction(ISO18000P3M3_REQRN, 0, byteSource.ToArray(), byteSource.Count, pRxBuffer, out ret_len, call);
        }

        //ISO18000P3M3_READ
        public int ISO18000P3M3_Read(byte bMemBank, byte[] pWordPtr, byte bWordPtrLength, Byte[] bWordCount, Byte[] pRxBuffer, out int pRxLength, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bMemBank);
            byteSource.AddRange(pWordPtr);
            byteSource.Add(bWordPtrLength);
            byteSource.AddRange(bWordCount);

            return optFunction(ISO18000P3M3_READ, 0, byteSource.ToArray(), byteSource.Count, pRxBuffer, out pRxLength, call);
        }
        //ISO18000P3M3_WRITE
        public int ISO18000P3M3_Write(byte bOption, Byte bMemBank, Byte[] pWordPtr, int pWordPtrLength, Byte[] pData, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bOption);
            byteSource.Add(bMemBank);
            byteSource.AddRange(pWordPtr);
            byteSource.Add((Byte)pWordPtrLength);
            byteSource.AddRange(pData);
            int ret_len;
            return optFunction(ISO18000P3M3_WRITE, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);
        }

        //ISO18000P3M3_KILL
        public int ISO18000P3M3_Kill(byte bOption, byte[] pPassword, byte bRecom, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bOption);
            byteSource.AddRange(pPassword);
            byteSource.Add(bRecom);
            int ret_len;
            return optFunction(ISO18000P3M3_KILL, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);

        }

        //ISO18000P3M3_LOCK
        public int ISO18000P3M3_Lock(byte[] pMask, byte[] pAction, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.AddRange(pMask);
            byteSource.AddRange(pAction);
            int ret_len;
            return optFunction(ISO18000P3M3_LOCK, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);

        }

        //ISO18000P3M3_ACCESS
        public int ISO18000P3M3_Access(byte bOption, byte[] pPassword, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bOption);
            byteSource.AddRange(pPassword);
            int ret_len;
            return optFunction(ISO18000P3M3_ACCESS, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);
        }

        //ISO18000P3M3_BLOCKWRITE
        public int ISO18000P3M3_BlockWrite(byte bMemBank, byte[] pWordPtr, byte bWordPtrLength, byte[] bWordCount, Byte[] pData, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bMemBank);
            byteSource.AddRange(pWordPtr);
            byteSource.Add(bWordPtrLength);
            byteSource.AddRange(bWordCount);
            byteSource.AddRange(pData);
            int ret_len;
            return optFunction(ISO18000P3M3_BLOCKWRITE, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);
        }

        //ISO18000P3M3_BLOCKERASE
        public int ISO18000P3M3_BlockErase(byte bMemBank, byte[] pWordPtr, byte bWordPtrLength, byte[] bWordCount, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bMemBank);
            byteSource.AddRange(pWordPtr);
            byteSource.Add(bWordPtrLength);
            byteSource.AddRange(bWordCount);
            int ret_len;
            return optFunction(ISO18000P3M3_BLOCKERASE, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);
        }

        //ISO18000P3M3_BLOCKPERMALOCK
        public int ISO18000P3M3_BlockPermaLock(byte bRFU, byte bReadLock, Byte bMemBank, Byte[] pBlockPtr, Byte pBlockPtrLength, Byte[] pBlockRange,
            Byte[] pMask, Byte[] pRxBuffer, out int pRxLength, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(bRFU);
            byteSource.Add(bReadLock);
            byteSource.Add(bMemBank);
            byteSource.AddRange(pBlockPtr);
            byteSource.Add(pBlockPtrLength);
            byteSource.AddRange(pBlockRange);
            byteSource.AddRange(pMask);
            return optFunction(ISO18000P3M3_BLOCKPERMALOCK, 0, byteSource.ToArray(), byteSource.Count, pRxBuffer, out pRxLength, call);
        }

        //ISO18000P3M3_SETHANDLE
        public int ISO18000P3M3_SetHandle(byte[] pHandle, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.AddRange(pHandle);
            int ret_len;
            return optFunction(ISO18000P3M3_SETHANDLE, 0, byteSource.ToArray(), byteSource.Count, null, out ret_len, call);
        }

        //ST SR series
        public int ST_SR_active(byte[] id, out int data_len, CallbackDelegate call)
        {
            return optFunction(ST_SR_ACTIVE, 0, null, 0, id, out data_len, call);
        }

        public int ST_SR_read(byte block_num, byte[] data, out int data_len, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(block_num);
            return optFunction(ST_SR_READ, 0, byteSource.ToArray(), byteSource.Count, data, out data_len, call);
        }

        public int ST_SR_write(byte block_num, byte[] data, CallbackDelegate call)
        {
            List<byte> byteSource = new List<byte>();
            byteSource.Add(block_num);
            byteSource.AddRange(data);
            int ret_len;
            return optFunction(ST_SR_WRITE, 0, byteSource.ToArray(), byteSource.Count, data, out ret_len, call);
        }

    }
}
