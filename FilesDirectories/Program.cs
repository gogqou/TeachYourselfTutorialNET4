using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FilesDirectories
{
    public class Program
    {
        public static void Main(string[] args)
        {


            //Example of File handling 

            //string tempFile = Path.GetTempFileName();
            //try
            //{
            //    if(!File.Exists(tempFile))
            //    {
            //        using (StreamWriter writer = File.CreateText(tempFile))
            //        {
            //            writer.WriteLine("Line 1");
            //            writer.WriteLine("Line 2");

            //        }

            //    }
            //    File.Copy(tempFile, Path.GetTempFileName());
            //    File.Delete(tempFile);
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("An error occurred: {0}", e.Message);
            //}


            //Path info, enumerating directories and files and searching


            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "Web", "Wallpaper");
            Console.WriteLine(path);
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            try
            {
                if (directoryInfo.Exists)
                {
                    foreach (var directory in directoryInfo.EnumerateDirectories())
                    {
                        Console.WriteLine(directory.FullName);
                        foreach (var file in directory.EnumerateFiles("*.jpg", SearchOption.AllDirectories))
                        {
                            Console.WriteLine("{0} {1}", file.Name, file.CreationTime);
                        }
                    }
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("an error has occured: {0}", e.Message);
            }


            //string tempFile = Path.GetTempFileName();
            //FileInfo fileInfo = new FileInfo(tempFile);
            //try
            //{
            //    if (!fileInfo.Exists)
            //    {
            //        using (StreamWriter writer = fileInfo.CreateText())
            //        {
            //            writer.WriteLine("Line 1");
            //            writer.WriteLine("Line 2");

            //        }
            //    }
            //    fileInfo.CopyTo(Path.GetTempFileName());
            //    fileInfo.Delete();
            //}
            //catch(IOException e)
            //{
            //    Console.WriteLine("An error occured: {0}", e.Message);
            //}


            /*
             * File directory example
             * 
            string tempPath = Path.GetTempFileName();
            DirectoryInfo directoryInfo = new DirectoryInfo(tempPath);
            try
            {
                if (directoryInfo.Exists)
                {
                    Console.WriteLine("The directory already exists.");
                }
                else
                {
                    directoryInfo.Create();
                    Console.WriteLine("The directory was successfully created.");
                    directoryInfo.Delete();
                    Console.WriteLine("The directory was deleted.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured: {0}", e.Message);
            }
            */
            Console.ReadLine();

        }
    }
}
