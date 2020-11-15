using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _10.CW_15._11._2020_Streams
{
    public class StreamClass
    {
        public static bool TryWrite(string filepath, string text)
        {
            try
            {
                using var fs = new FileStream(filepath, FileMode.Create);
                using var sw = new StreamWriter(fs, Encoding.Unicode);
                sw.WriteLine(text);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool TryRead(string filepath, out string text)
        {
            try
            {
                using var fs = new FileStream(filepath, FileMode.Open);
                using var sw = new StreamReader(fs, Encoding.Unicode);
                text = sw.ReadToEnd();
                return true;
            }
            catch (Exception ex)
            {
                text = "";
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool TryReadAllLines(string filepath, out string[] text)
        {
            try
            {
                text = File.ReadAllLines(filepath);
                return true;
            }
            catch (Exception ex)
            {
                text = Array.Empty<string>();
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool TryWriteAllLines(string filepath, string[] text)
        {
            try
            {
                File.WriteAllLines(filepath, text);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool TryReadBinaryFile(string filepath, out List<string> objArr)
        {
            objArr = new List<string>();
            try
            {
                using var fs = new FileStream(filepath, FileMode.Open);
                using var br = new BinaryReader(fs, Encoding.Unicode);
                objArr.Add(br.ReadString());
                objArr.Add(br.ReadDouble().ToString());
                objArr.Add(br.ReadInt32().ToString());
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool TryWriteBinaryFile(string filepath)
        {
            try
            {
                using var fs = new FileStream(filepath, FileMode.Create);
                using var bw = new BinaryWriter(fs, Encoding.Unicode);

                string writeText = "sdfgsdf";
                double pi = 3.1415926;
                int number = 1256;
                bw.Write(writeText);
                bw.Write(pi);
                bw.Write(number);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }


    }
}
