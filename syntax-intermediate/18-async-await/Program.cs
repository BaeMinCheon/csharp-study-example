using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            p.Test();
            
            //p.FuncAsync(p.Func());
            
            //p.GetIntAsync(p.GetInt());

            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public async void Test()
        {
            Console.WriteLine(DateTime.Now);
            {
                var a = Task.Delay(1000);
                var b = Task.Delay(1000);
                var c = Task.Delay(1000);
                var d = Task.Delay(1000);
                var e = Task.Delay(1000);

                await a;
                await b;
                await c;
                await d;
                await e;
            }
            Console.WriteLine(DateTime.Now);
            {
                await Task.Delay(1000);
                await Task.Delay(1000);
                await Task.Delay(1000);
                await Task.Delay(1000);
                await Task.Delay(1000);
            }
            Console.WriteLine(DateTime.Now);
        }

        public async void FuncAsync(Task _t)
        {
            await _t;
        }

        public async Task Func()
        {
            Console.WriteLine("Func() Starts");
            await Task.Delay(2000);
            Console.WriteLine("Func() Ends");
        }

        public async Task GetIntAsync(Task<int> _t)
        {
            int i = await _t;
            Console.WriteLine("i = " + i.ToString());
        }

        public async Task<int> GetInt()
        {
            Console.WriteLine("GetInt() Starts");
            await Task.Delay(2000);
            Console.WriteLine("GetInt() Ends");
            return 10;
        }
    }
}
