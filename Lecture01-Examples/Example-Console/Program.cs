using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入神奇寶貝姓名:");
            string Name = Console.ReadLine();
            Console.Write("屬性:");
            string Type = Console.ReadLine();
            Console.Write("身高:");
            string Hight = Console.ReadLine();
            Console.Write("體重:");
            string Weight = Console.ReadLine();
            Console.WriteLine(
                "恭喜你獲得{0},屬性{1},身高{2},體重{3}", Name, Type,Hight,Weight
                );
        }
    }
}
