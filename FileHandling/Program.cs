using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileHandling
{
    /* 
     For File Handling Open the CS COde With administrative permission (Run as administration)
    - import System.IO
    - 2 Object Directory and DirectoryInfo for file  handling
     */
    class Program
    {
        static void Main(string[] args)
        {
            Method4(null,null);
        }
        private static void DirectoryMethod(object sender , EventArgs e) {
       //     Directory.CreateDirectory("D:\\Temp"); // for treat \ as a single character
            Directory.CreateDirectory(@"D:\Temp"); // instead of // we can use @ which is telling compiler that it string literal containing no escape character
            /*
            TODO
 
            */

        }
        private void FileMethod(object sender, EventArgs e)
        {

            File.Create(@"D:\Temp\abc.txt");
            /*
                TODO
 
            */        
        }

        private void DriveMethod(object sender, EventArgs e)
        {

            // DriveInfo.
            /*
                TODO
 
            */
        }
        private static void Method4(object sender, EventArgs e)
        {


            /*
             
                File Modes:-

                Create -> if file is already present then it will override it
                createNew-> if file is already present then it throws an exceptions
                truncate -> file should be already present and if not present it will throw an exception and then override the existing data
                Open -> To read the file if file is not present open gives an exception
                OpenOrCreate -> To read and write if the file is not present it will create
            */

            string s = "Hello World";
            byte[] arr = Encoding.Default.GetBytes(s);

            FileStream stream = File.Open(@"D:\Temp\abc.txt",FileMode.Create);
            stream.Write(arr, 0, arr.Length);// writing on file

            //stream.Length
            //stream.Read()
            /*TODO: write code to read from stream*/

            // stream.Close();
            StreamWriter writer = File.CreateText(@"D:\Temp\abcd.txt");// formated stream //override existing file
            writer.WriteLine("Hello World");
            writer.WriteLine("Line 2");
            writer.WriteLine("Line 3");
            writer.Close();


            /*ToDO stream Reader*/
        }
        private static void Method5(object sender, EventArgs e)
        {
                /*Binary Writer*/
        }
    }
