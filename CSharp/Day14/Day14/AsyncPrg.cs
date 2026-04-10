using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    internal class AsyncPrg
    {
        static void Main()
        {
            //Method1();
            //Method2();
            Console.WriteLine("-------Await in catch and Finally------");
            ExceptionAwait.addAsync();
            Console.WriteLine("-----2nd Example-------");
            FileRead fr = new FileRead();
            fr.filereadoperation();
            Console.Read();
        }

        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Method 1 " + i);
                    //dosomething
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Method 2 " + i);
                //dosomething
                Task.Delay(100).Wait();
            }
        }

    }

    class ExceptionAwait
    {
        public async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 2;
            }
            catch (Exception ex)
            {
                //using await in catch
                 await ExceptionOccured();

                Console.WriteLine("Correct your Code");
            }
            finally
            {
                await ReleasingResources();
            }
        
        }

        async static Task ExceptionOccured()
        {
            Console.WriteLine("Array Exception Occurred");
        }

        async static Task ReleasingResources()
        {
            Console.WriteLine("All occupied resources have been released..");
        }
    }

    class FileRead
    {
        static string filename;
        public async void filereadoperation()
        {
            try
            {
                StreamReader sr = File.OpenText("data.txt");
                Console.WriteLine("The data is : " + sr.ReadLine());
                sr.Close();
            }
            catch { await FileNotFound(); }
            finally { await Exitprogram(); }
        }

        async Task FileNotFound()
        {
            Console.WriteLine($"The file {filename}you are trying to read is not found.. try later");
        }

        async Task Exitprogram()
        {
            Console.WriteLine("\n press any key to exit");
        }
    }
}
