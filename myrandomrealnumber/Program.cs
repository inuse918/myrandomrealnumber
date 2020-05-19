using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myrandomrealnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var input = 0;
            //Console.WriteLine(random.Next(1,1000));
            var com = random.Next(1, 1000);
            Console.WriteLine(com);
            while (true)
            {
                Console.Write("숫자를 입력해주세요: ");
                input = int.Parse(Console.ReadLine());
                if (input == com)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                } else if (input < com)
                {
                    Console.WriteLine(input + "보다는 큰 숫자입니다.");
                } else
                {
                    Console.WriteLine(input + "보다는 작은 숫자입니다.");
                }
            }
        }
    }
}
