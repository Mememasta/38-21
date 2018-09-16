using System;

namespace _38_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i=1; 
            int N=10; //сколько лет лежит в банке
            double prc=0.11;
            double money=1000000;
            while(i<=N) {
                money+=money*prc;
                i++;
            }
            Console.WriteLine(money);//вывод результата
        }
    }
}
