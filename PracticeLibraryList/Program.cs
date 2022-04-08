using PracticeLibraryList.List;
using System;

namespace PracticeLibraryList
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomCollection<int> list = new CustomCollection<int>();
            list.Add(32);
            list.Add(3);
            list.Add(9);
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);   
            //}
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
