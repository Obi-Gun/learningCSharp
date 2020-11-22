using _10.CW_15._11._2020_Streams;
using _11.CW_22._11._2020_ClassLib;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace _11.CW_22._11._2020_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task2Deserialize();
            //Task3Serialize();
            //Task3Deserialize();
            Task3SerializeProtobuf();
            ReadBinaryFileProtobuf("listSerial2.txt", out List<PC> objArr);
            foreach (var item in objArr)
            {
                Console.WriteLine(item);
            }
        }

        public static byte[] Serialize(List<PC> list)
        {
            byte[] result;
            using (var stream = new MemoryStream())
            {
                Serializer.Serialize(stream, list);
                result = stream.ToArray();
            }
            return result;
        }

        public static List<PC> Deserialize(FileStream fileStream)
        {
            List<PC> result;

            result = Serializer.Deserialize<List<PC>>(fileStream);

            return result;
        }

        private static void Task3SerializeProtobuf()
        {
            var arr = new List<PC>()
            {
                new PC(),
                new PC(23123, "HP", new DateTime (2009, 11, 11 )),
                new PC()
                {
                    PurshaseDate = new DateTime (2008, 12, 12)
                }
            };
            var bytes = Serialize(arr);
            try
            {
                using var fs = new FileStream("listSerial2.txt", FileMode.Create);
                using var bw = new BinaryWriter(fs, Encoding.Unicode);
                bw.Write(bytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadBinaryFileProtobuf(string filepath, out List<PC> objArr)
        {
            objArr = Deserialize(File.OpenRead(filepath));
        }

        private static void Task3Serialize()
        {
            var arr = new List<PC>()
            {
                new PC(),
                new PC(23123, "HP", new DateTime (2009, 11, 11 )),
                new PC()
                {
                    PurshaseDate = new DateTime (2008, 12, 12)
                }
            };
            var serializer = new BinaryFormatter();
            using (Stream stream = File.Create("listSerial.txt"))
            {
                serializer.Serialize(stream, arr);
            }
        }

        private static void Task3Deserialize()
        {
            var serializer = new BinaryFormatter();
            using (Stream stream = File.OpenRead("listSerial.txt"))
            {
                var obj = (List<PC>)serializer.Deserialize(stream);
                foreach (var item in obj)
                    Console.WriteLine(item);
            }
        }

        private static void Task1()
        {
            {
                foreach (var attr in typeof(Apple).GetCustomAttributes())
                    Console.WriteLine(attr);

                foreach (var method in typeof(Apple).GetRuntimeMethods())
                    foreach (var attr in method.GetCustomAttributes())
                        Console.WriteLine(attr);

                foreach (var field in typeof(Apple).GetRuntimeFields())
                    foreach (var attr in field.GetCustomAttributes())
                        Console.WriteLine(attr);
            }
        }

        private static void Task2()
        {
            var list = new List<Apple>()
            {
                new Apple(){Color = "red"},
                new Apple(){Color = "green", Radius = 2},
                new Apple(){Radius = 4},
                new Apple()
            };
            var serializer = new XmlSerializer(typeof(List<Apple>));
            using (Stream stream = File.Create("test.xml"))
            {
                serializer.Serialize(stream, list);
            }

        }

        private static void Task2Deserialize()
        {
            var serializer = new XmlSerializer(typeof(List<Apple>));
            List<Apple> result = null;
            using (Stream stream = File.OpenRead("test.xml"))
            {
                result = (List<Apple>)serializer.Deserialize(stream);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
