using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    public class Sample
    {
        public Sample()
        {
            Console.WriteLine("sample class constructor");
        }
        public void Display()
        {
            Console.WriteLine("display method");
        }
        //~Sample() { Console.WriteLine("sample class destructor"); }
        internal class Program
        {
            static void Main(string[] args)
            {
                Sample sample = new Sample();
                sample.Display();
                sample = null;
                GC.Collect();
                Console.WriteLine(GC.GetTotalMemory(false));
                GC.Collect();
                Console.WriteLine(GC.MaxGeneration);


                Console.ReadLine();
            }
        }
    }
}







//string filePath = "C:/Users/anvithr/Videos/example.txt";

//// Write to a file
//using (StreamWriter writer = new StreamWriter(filePath))
//{
//    writer.WriteLine("Hello, World!");
//    writer.WriteLine("This is a sample file.");
//}

// Read from a file
//using (StreamReader reader = new StreamReader(filePath))
//{
//    string content = reader.ReadToEnd();
//    Console.WriteLine("File Content:");
//    Console.WriteLine(content);
//}

// Append to a file
//using (StreamWriter writer = new StreamWriter(filePath, true))
//{
//    writer.WriteLine("Appending a new line.");
//}

// Read the updated file
//using (StreamReader reader = new StreamReader(filePath))
//{
//    string content = reader.ReadToEnd();
//    Console.WriteLine("Updated File Content:");
//    Console.WriteLine(content);
//}

//StreamReader reader = null;
//try
//{
//    string content = reader.ReadToEnd();
//    Console.WriteLine(content);
//}
//catch (Exception e)
//{
//    throw new Exception(e.Message);
//}
//finally
//{
//    if (reader != null)
//        reader.Close();
//}






//static void Main(string[] args)
//{
//    FileInfo file = new FileInfo("C:/Users/anvithr/Videos/sample.txt");
//    if (!file.Exists)
//    {
//        file.Create().Close();
//    }
//    Console.WriteLine(file.FullName);
//    file.CopyTo("C:/Users/anvithr/Music/sample_backup.txt", true);
//    //file.MoveTo("C:/Users/anvithr/Videos/sample_renamed.txt");

//    //file.MoveTo("C:/Users/anvithr/Videos");
//    string sourcedir = @"C:/Users/anvithr/Videos/Training";
//    string targetdir = @"C:/Users/anvithr/Videos/Training/sampleDestination";
//    DirectoryInfo sdi = new DirectoryInfo(sourcedir);
//    DirectoryInfo tdi = new DirectoryInfo(targetdir);
//    if (!tdi.Exists)
//    {
//        tdi.Create();
//    }
//    foreach (FileInfo fi in sdi.GetFiles())
//    {
//        fi.CopyTo(Path.Combine(tdi.ToString(), fi.Name), true);
//        Console.WriteLine(@"Copying {0}\{1}", tdi.FullName, fi.Name);
//    }
//    foreach (DirectoryInfo sourceSubDir in sdi.GetDirectories())
//    {
//        DirectoryInfo targetSubDir = tdi.CreateSubdirectory(sourceSubDir.Name);
//        foreach (FileInfo fi in sourceSubDir.GetFiles())
//        {
//            fi.CopyTo(Path.Combine(targetSubDir.ToString(), fi.Name), true);
//            Console.WriteLine(@"Copying {0}\{1}", targetSubDir.FullName, fi.Name);
//        }

//    }