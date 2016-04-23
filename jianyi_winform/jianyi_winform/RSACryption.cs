﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace jianyi_winform
{
    /// <summary> 
    /// RSA加密解密及RSA签名和验证
    /// </summary> 
    public class RSACryption
    {


        //RSACryption rsa = new RSACryption();
        //string orginStr = "abcdefssfsf";
        //string pjPath = Application.StartupPath.Substring(0, Application.StartupPath.LastIndexOf("bin"));
        //string privateKeyPath = Path.Combine(pjPath, @"certs\private_key_pkcs8.pem");



        //string publicKeyPath = Path.Combine(pjPath, @"certs\public_key.pem");
        //string signResult = rsa.Sign(orginStr, privateKeyPath);

        //if (rsa.Verify(orginStr, signResult, publicKeyPath))
        //{
        //    MessageBox.Show("验证签名成功!","tisp");
        //}


        /// <summary>  
        /// 验证签名  
        /// </summary>  
        /// <param name="OriginalString">原文：UTF8编码</param>  
        /// <param name="SignatureString">签名：base64编码的字节</param>  
        /// <param name="publicKeyPath">公钥路径</param>  
        /// <returns> 验签结果</returns>  
        public bool Verify(String OriginalString, String SignatureString, String publicKeyPath)
        {
            //将base64签名数据转码为字节   
            byte[] signedBase64 = Convert.FromBase64String(SignatureString);
            byte[] orgin = Encoding.UTF8.GetBytes(OriginalString);

            X509Certificate2 x509_Cer1 = new X509Certificate2(publicKeyPath);

            RSACryptoServiceProvider oRSA = new RSACryptoServiceProvider();
            oRSA.FromXmlString(x509_Cer1.PublicKey.Key.ToXmlString(false));

            bool bVerify = oRSA.VerifyData(orgin, "SHA1", signedBase64);
            return bVerify;

        }

        /// <summary>  
        /// 验证签名  
        /// </summary>  
        /// <param name="data">原文：UTF8编码</param>  
        /// <param name="privateKeyPath">证书路径：D:/certs/mycert.key</param>  
        /// <returns> 验签</returns>  
        public string Sign(string data, string privateKeyPath)
        {
            RSACryptoServiceProvider rsaCsp = LoadCertificateFile(privateKeyPath);
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);
            byte[] signatureBytes = rsaCsp.SignData(dataBytes, "SHA1");
            return Convert.ToBase64String(signatureBytes);
        }

        private byte[] GetPem(string type, byte[] data)
        {
            string pem = Encoding.UTF8.GetString(data);
            string header = String.Format("-----BEGIN {0}-----", type);
            string footer = String.Format("-----END {0}-----", type);
            int start = pem.IndexOf(header) + header.Length;
            int end = pem.IndexOf(footer, start);

            string base64 = pem.Substring(start, (end - start));

            return Convert.FromBase64String(base64);
        }

        private RSACryptoServiceProvider LoadCertificateFile(string filename)
        {
            using (System.IO.FileStream fs = System.IO.File.OpenRead(filename))
            {
                byte[] data = new byte[fs.Length];
                byte[] res = null;
                fs.Read(data, 0, data.Length);
                if (data[0] != 0x30)
                {
                    res = GetPem("RSA PRIVATE KEY", data);
                }
                try
                {
                    RSACryptoServiceProvider rsa = DecodeRSAPrivateKey(res);
                    return rsa;
                }
                catch (Exception ex)
                {
                }
                return null;
            }
        }

        private RSACryptoServiceProvider DecodeRSAPrivateKey(byte[] privkey)
        {
            byte[] MODULUS, E, D, P, Q, DP, DQ, IQ;

            // --------- Set up stream to decode the asn.1 encoded RSA private key ------    
            MemoryStream mem = new MemoryStream(privkey);
            BinaryReader binr = new BinaryReader(mem);  //wrap Memory Stream with BinaryReader for easy reading    
            byte bt = 0;
            ushort twobytes = 0;
            int elems = 0;
            try
            {
                twobytes = binr.ReadUInt16();
                if (twobytes == 0x8130) //data read as little endian order (actual data order for Sequence is 30 81)    
                    binr.ReadByte();    //advance 1 byte    
                else if (twobytes == 0x8230)
                    binr.ReadInt16();    //advance 2 bytes    
                else
                    return null;

                twobytes = binr.ReadUInt16();
                if (twobytes != 0x0102) //version number    
                    return null;
                bt = binr.ReadByte();
                if (bt != 0x00)
                    return null;


                //------ all private key components are Integer sequences ----    
                elems = GetIntegerSize(binr);
                MODULUS = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                E = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                D = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                P = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                Q = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                DP = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                DQ = binr.ReadBytes(elems);

                elems = GetIntegerSize(binr);
                IQ = binr.ReadBytes(elems);


                // ------- create RSACryptoServiceProvider instance and initialize with public key -----    
                CspParameters CspParameters = new CspParameters();
                CspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(1024, CspParameters);
                RSAParameters RSAparams = new RSAParameters();
                RSAparams.Modulus = MODULUS;
                RSAparams.Exponent = E;
                RSAparams.D = D;
                RSAparams.P = P;
                RSAparams.Q = Q;
                RSAparams.DP = DP;
                RSAparams.DQ = DQ;
                RSAparams.InverseQ = IQ;
                RSA.ImportParameters(RSAparams);
                return RSA;
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                binr.Close();
            }
        }

        private int GetIntegerSize(BinaryReader binr)
        {
            byte bt = 0;
            byte lowbyte = 0x00;
            byte highbyte = 0x00;
            int count = 0;
            bt = binr.ReadByte();
            if (bt != 0x02)     //expect integer    
                return 0;
            bt = binr.ReadByte();

            if (bt == 0x81)
                count = binr.ReadByte();    // data size in next byte    
            else
                if (bt == 0x82)
                {
                    highbyte = binr.ReadByte(); // data size in next 2 bytes    
                    lowbyte = binr.ReadByte();
                    byte[] modint = { lowbyte, highbyte, 0x00, 0x00 };
                    count = BitConverter.ToInt32(modint, 0);
                }
                else
                {
                    count = bt;     // we already have the data size    
                }

            while (binr.ReadByte() == 0x00)
            {   //remove high order zeros in data    
                count -= 1;
            }
            binr.BaseStream.Seek(-1, SeekOrigin.Current);       //last ReadByte wasn't a removed zero, so back up a byte    
            return count;
        }    







    }

}
