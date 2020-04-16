using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace csharp_projects_assignment4
{
    class FileWriteAndRead
    {
        public void writeAndRead(string fileName)
        {
            try
            {
                //if file already exists delete it
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                //create file and add contents to it
                using (FileStream fs = File.Create(fileName))
                {
                    Byte[] articleTitle = new UTF8Encoding(true).GetBytes("How To Be Happy\n");
                    fs.Write(articleTitle, 0, articleTitle.Length);
                    byte[] writer = new UTF8Encoding(true).GetBytes("Author : John Alexander\n");
                    fs.Write(writer, 0, writer.Length);
                    byte[] date = new UTF8Encoding(true).GetBytes("Created date : 16-04-2020\n\n");
                    fs.Write(date, 0, date.Length);
                }

                string article = "Lorem ipsum dolor sit amet, consectetur adipiscing elit " + "::"
                                + "sed do eiusmod tempor incididunt ut labore et dolore magna aliqua" + "::"
                                + "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi" + "::";
                
                File.AppendAllLines(fileName, article.Split("::"));

                using (StreamReader file = new StreamReader(fileName))
                {
                    //counter to count number of lines in file
                    int counter = 0;
                    string ln;

                    while ((ln = file.ReadLine()) != null)
                    {
                        Console.WriteLine(ln);
                        counter++;//increment counter
                    }
                    //close file
                    file.Close();
                    Console.WriteLine($"File has {counter} lines.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Execption : "+ex.Message);
            }

        }
    }
}
