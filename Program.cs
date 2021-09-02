using System;
using System.IO;

namespace OnlyRetrieve
{
   
    public class Student
    {

        static void Main(string[] args)
        {
            string strdata = File.ReadAllText(@"D:\student.txt");

            string[] rowdata = strdata.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);

        
            foreach (string sturecord in rowdata)
            {
               
                string[] splitdata = sturecord.Split('|');
                Console.WriteLine("student ID:" + splitdata[0]);
                Console.WriteLine("student name:" + splitdata[1]);
                Console.WriteLine("student class:" + splitdata[2]);
                Console.WriteLine("student section:" + splitdata[3] + "\n");


            }

        }
    }
}
