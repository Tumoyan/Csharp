using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AnotherApp
{
    public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
                throw new ArgumentNullException();

            foreach (var item in source)
            {
                action(item);
            }
        }
    }

    class Program
    {
        private static void DisplayLargestWithLink(string pathToDir)
        {
            new DirectoryInfo(pathToDir)
            .GetFiles()
            .OrderBy(x => x.Length)
            .Take(5)
            .ForEach(x => Console.WriteLine($"{x.Name} weights {x.Length}"));

            //.OrderBy(x =>
            //{
            //    return x.Length;
            //    return x.Length - 1;
            //});

            // альтернатива метода расширения
            /*
            IEnumerable<FileInfo> orderFiles = new DirectoryInfo(pathToDir)
             .GetFiles()
             .OrderBy(x => x.Length)
             .Take(5);
            foreach (FileInfo orderFile in orderFiles)
            {
                Console.WriteLine($"{orderFile.Name} weights {orderFile.Length}");
            }
            */
        }

        // без лямбды вырaжения
        //static long KeySelector(FileInfo file)
        //{
        //    return file.Length;
        //}

        private static void DisplayLargestFiles(string pathToDir)
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files,FilesComprasion);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }

        static int FilesComprasion(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }
        static void Main(string[] args)
        {
            DisplayLargestFiles(@"C:\Users\Tumoyan\Desktop\TC_Manual");
            Console.WriteLine();
            DisplayLargestWithLink(@"C:\Users\Tumoyan\Desktop\TC_AUTO");
        }
    }
}
