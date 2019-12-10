using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_10_01
{
   public static class DirectoryClass
    {
       
        public static void IOMethod()
        {
            var fileInfo = new FileInfo(@"D:\NotExistingDir1\NotExistsingDir2\NewFile.txt");

            if (!fileInfo.Exists)
            {
                try
                {
                    fileInfo.Create();
                    Console.WriteLine($"File:{fileInfo.FullName} created");
                }
                catch 
                {
                    var directory = new DirectoryInfo(@"D:\NotExistingDir1\NotExistsingDir2\");
                    directory.Create();
                    Console.WriteLine($"Directory {directory.FullName} was created");
                }
                
               
            }
            
            


        }
        
    }
}
