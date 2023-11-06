using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.CrossCutting.Utilities.GetPath
{
    public class GetPathFile
    {
        public string GetPath()
        {
            string filePath = string.Empty;

            string path = AppDomain.CurrentDomain.BaseDirectory + "/bin";

            string title = ConfigurationManager.AppSettings["Title"];

            DateTime currentDateTime = DateTime.Now;

            string formattedDateTime = currentDateTime.ToString("yyyyMMddHHmmss");
            
            string fileName = title + "_" + formattedDateTime;

            filePath = System.IO.Path.Combine(path, fileName);

            return filePath;

        }
    }
}


