using System;
using System.Collections;
using System.IO.Compression;
using System.IO.Pipes;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace Lesson14_1
{
    class Book
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public override string ToString() => $@"
Id: {Id}
Author: {Author}
Title: {Title}
Genre: {Genre}";
    }


    class Program
    {
        static void Main()
        {
            //// Stream

            // FileStream
            // MemoryStream
            // NetworkStream
            // PipeStream
            // UnmanagedMemoryStream
            // CryptoStream
            // BufferedStream

            // GZipStream
            // DeflateStream



            //// Helper classes or Adapters

            // TextReader, TextWriter
            // StreamReader, StreamWriter
            // BinaryReader, BinaryWriter
            // XmlReader, XmlWriter




            // File, FileInfo
            // Directory, DirectoryInfo
            // Path










            #region Write with FileStream

            //    using (FileStream fs = new FileStream("test.txt", 
            //                                          FileMode.OpenOrCreate, 
            //                                          FileAccess.Write, 
            //                                          FileShare.None))
            //    {
            //        Console.Write("Enter some text: ");
            //        string? someText = Console.ReadLine();
            //    
            //        byte[] bytes = Encoding.Default.GetBytes(someText);
            //    
            //        fs.Write(bytes, 0, bytes.Length);
            //    
            //        // fs.Flush();
            //        // fs.Close();
            //    }

            #endregion







            #region Read with FileStream

            //  using (FileStream fs = new FileStream("test.txt",
            //                                      FileMode.Open,
            //                                      FileAccess.Read))
            //  {
            //      byte[] buffer = new byte[fs.Length];
            //  
            //      fs.Read(buffer, 0, buffer.Length);
            //  
            //      string text = Encoding.Default.GetString(buffer);
            //      Console.WriteLine(text);
            //  }

            #endregion






            #region StreamWriter

            //  List<Book> books = new List<Book>()
            //  {
            //      new Book
            //      {
            //          Id = 1,
            //          Author = "Joseph Albahari",
            //          Title = "C# in nutshell",
            //          Genre = "Programming"
            //      },
            //      new Book
            //      {
            //          Id = 2,
            //          Author = "Jeffrey Richter",
            //          Title = "CLR via C#",
            //          Genre = "Programming"
            //      },
            //      new Book
            //      {
            //          Id = 3,
            //          Author = "Antoine de Saint-Exupéry",
            //          Title = "The Little Prince",
            //          Genre = "Children's literature"
            //      }
            //  };
            //  
            //  
            //  using FileStream fs = new FileStream("books.txt", FileMode.Create,    FileAccess.Write);
            //  using StreamWriter sw = new StreamWriter(fs);
            //  
            //  //  Console.Write("Enter some text: ");
            //  //  string? someText = Console.ReadLine();
            //  //  sw.WriteLine(someText);
            //  
            //  books.ForEach(book => sw.WriteLine(book));

            #endregion





            #region StreamReader

            // using FileStream fs = new FileStream("books.txt", FileMode.Open, FileAccess.Read);
            // using StreamReader sr = new StreamReader(fs);
            // 
            // Console.WriteLine(sr.ReadToEnd());

            #endregion








            #region BinaryWriter

            //  using FileStream fs = new FileStream("binary.bin", FileMode.Create, FileAccess.Write);
            //  using BinaryWriter bw = new BinaryWriter(fs);
            //  
            //  bw.Write("Lesson: Stream");
            //  bw.Write(10);
            //  bw.Write(true);

            #endregion





            #region BinaryReader

            // using FileStream fs = new FileStream("binary.bin", FileMode.Open, FileAccess.Read);
            // using BinaryReader br = new BinaryReader(fs);
            // 
            // 
            // string text = br.ReadString();
            // int number = br.ReadInt32();
            // bool isOKay = br.ReadBoolean();
            // 
            // Console.WriteLine(text);
            // Console.WriteLine(number);
            // Console.WriteLine(isOKay);

            #endregion












            #region Directory, DirectoryInfo

            // string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Console.WriteLine(path);


            // var directory = new DirectoryInfo(path);
            // foreach (var file in directory.GetFiles())
            //     Console.WriteLine(file.FullName);



            // var directory = new DirectoryInfo("..");
            // var directory = new DirectoryInfo("../..");
            // var directory = new DirectoryInfo("./SubFolder");

            // var directory = new DirectoryInfo(".");
            // foreach (var folder in directory.GetDirectories())
            //     Console.WriteLine(folder.Name);




            // Directory.CreateDirectory(@$"C:\Users\{Environment.UserName}\Desktop\CreateNewFolder");


            #endregion







            #region File, FileInfo

            // FileInfo fileInfo = new FileInfo("test.txt");

            // File.WriteAllText("easy.txt", "FBAS_2214_az");
            // Console.WriteLine(File.ReadAllText("easy.txt")); 

            #endregion







            #region Path

            string fileName = "example";
            string extension = ".txt";
            string desktopPath = @$"C:\Users\{Environment.UserName}\Desktop";

            string fileFullName = fileName + extension;

            File.WriteAllText(Path.Combine(desktopPath, fileFullName), "FBAS_2214_az");

            #endregion
        }
    }
}