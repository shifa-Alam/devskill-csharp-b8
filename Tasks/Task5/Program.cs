using System;
using System.IO;
namespace Task5
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Write your code here. No unit test for this task.

            DirectoryInfo aDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());
            var parent = aDirectory.Parent.Parent.Parent;
            //using var fs = File.Create(Path.Combine(parent.FullName, "hello.txt"));
           
            string fullPath = Path.Combine(parent.FullName, "hello.txt");
            if (File.Exists(fullPath))
                File.Move(fullPath, fullPath + ".old.txt");

            File.WriteAllText(fullPath, "Hello world from C#");
        }
    }
}
