using System;
using System.Configuration;
using System.IO;


namespace FizzBuzz.CrossCutting.Utilities.GetPath
{
    public class GetPathFile : IGetPathFile
    {
        public string GetPath()
        {
            string filePath = string.Empty;

            string path = AppDomain.CurrentDomain.BaseDirectory + "/bin";

            string title = ConfigurationManager.AppSettings["Title"];

            DateTime currentDateTime = DateTime.Now;

            string formattedDateTime = currentDateTime.ToString("yyyyMMddHHmmss");
            
            string fileName = title + "_" + formattedDateTime;

            filePath = Path.Combine(path, fileName);

            return filePath;

        }
    }
}


