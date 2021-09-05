using System;
using System.IO;

namespace pr2_01_02
{
    class Program
    {// C#
        static void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Changed: {0}", e.FullPath);
        }

        static void Main(string[] args)
        {
            // C#
            FileSystemWatcher watcher =
            new FileSystemWatcher(@"D:\temp");

            // C#
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.Size;
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            Console.ReadKey();


        }
    }
}
/*
* using System;
using System.IO;

namespace pr2_01_01
{
 class Program
 {
   static void ShowDirectory(DirectoryInfo dir)
   {
     // Показать все файлы
     foreach (FileInfo file in dir.GetFiles())
     {
       Console.WriteLine("File: {0}", file.FullName);
     }

     foreach (DirectoryInfo subDir in dir.GetDirectories())
     {
       ShowDirectory(subDir);
     }
   }

   static void Main(string[] args)
   {
     // C#
     DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory); 
     ShowDirectory(dir);
   }
 }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Compression
{
   class Program
   {
       static void Main(string[] args)
       {
           string inFilename = @"d:\ttt.txt";
           string outFilename = @"d:\ttt.txt.gz";
           //FileStream sourceFile = File.OpenRead(inFilename);
           //FileStream destFile = File.Create(outFilename);

           //GZipStream compStream = new GZipStream(destFile, CompressionMode.Compress);
           //int theByte = sourceFile.ReadByte();
           //while (theByte != -1)
           //{
           //    compStream.WriteByte((byte)theByte);
           //    theByte = sourceFile.ReadByte();
           //}
           //compStream.Close();


           string inFilename1 = @"d:\tttt.txt";
           FileStream sourceFile = File.OpenRead(outFilename);
           FileStream destFile = File.Create(inFilename1);
           GZipStream compStream =
           new GZipStream(sourceFile, CompressionMode.Decompress);
           int theByte = compStream.ReadByte();
           while (theByte != -1)
           {
               destFile.WriteByte((byte)theByte);
               theByte = compStream.ReadByte();
           }

           compStream.Close();


       }
   }
} */ 
