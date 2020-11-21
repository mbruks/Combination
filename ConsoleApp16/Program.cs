using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Combination
    {
        class Program
        {
            static void Main(string[] args)
        { 
            //Время работы программы 
            DateTime time1 = DateTime.Now;
            for (int i = 0; i < 20000000; i++) { }
            DateTime time2 = DateTime.Now;
            Console.WriteLine("Время выполнения: {0}", (time2 - time1).Milliseconds);

            StreamWriter sw = new StreamWriter(@"C:\Users\Admin\source\repos\ConsoleApp16\ConsoleApp16\txt.txt");
            Console.WriteLine("Введите N = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[k + 1];
                for (int i = 0; i < k; i++)
                    arr[i] = 0;
                arr[k] = n;
                bool b = true;
                if (k > 0 && k < n)
                {
                    do
                    {
                        arr[0]++;
                        for (int i = 0; i < k; i++)
                        {
                            if (arr[i] >= n)
                            {
                                arr[i] = 0;
                             arr[i + 1]++;
                            }
                        }
                        for (int i = 0; i < k - 1; i++)
                        {
                            if (arr[i] >= arr[i + 1])
                            {
                                b = false;
                            }
                        }
                        if (b)
                        {
                            for (int i = 0; i < k; i++)
                            {
                                Console.Write(arr[i]+ " ");
                                sw.Write(arr[i]+ " ");

                            }
                                Console.WriteLine(" ");
                                sw.WriteLine(" "); 
                    }
                    b = true;  
                    }
                                while (arr[k] == n);
                                Console.ReadKey();
                                sw.Close();
            }
        }
        }
    }

