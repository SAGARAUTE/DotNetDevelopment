using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
         FileDetails fileDetails = new FileDetails();
         List<string> versionInput = new List<string> { "-v","--v", "/v", "--version" };
         List<string> sizeInput = new List<string> { "-s", "--s", "/s", "--size" };
         
         #region Task1 
         
         if (args != null)
         {
            if(args[0].Equals("-v"))
            {
               Console.WriteLine("Task1 => FileVersion: " + fileDetails.Version(args[1]) + "\n \n");
            }
         }
         #endregion

         #region Task2
         if (args != null)
         {
            if (versionInput.Contains(args[0]))
            {
               Console.WriteLine("Task2 => FileVersion: " + fileDetails.Version(args[1]));
            }
            else if(sizeInput.Contains(args[0]))
            {
               Console.WriteLine("Task2 => FileSize: " + fileDetails.Size(args[1]));
            }
         }
         #endregion
         Console.ReadKey();
        }
    }
}
