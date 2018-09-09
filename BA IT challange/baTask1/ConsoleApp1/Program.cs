using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var even = new List<int>();
            var notEven = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    PrintNumber(i, true);
                    even.Add(i);
                    //Continue nėra būtini, nes cikle yra tik 1 sąliga
                    //continue;
                }
                //nereikalingas antra if eilutė
                else
                {
                    PrintNumber(i, false);
                    notEven.Add(i);
                    //continue;
                }
                //Nepasiekiamas kodas ir duomenu isvedimas jau egzistuoja
                //Console.WriteLine(i);
            }
            //Print sum and get it. 
            var evenSum = PrintNumberSum(even, true);
            var notEvenSum = PrintNumberSum(notEven, false);
            //Print individual sum numbers
            var evenSumNumbers = GetIndividualNumbers(evenSum);
            foreach (var number in evenSumNumbers)
            {
                Console.WriteLine(number);
            }
            var notEvenSumNumbers = GetIndividualNumbers(notEvenSum);
            foreach (var number in notEvenSumNumbers)
            {
                Console.WriteLine(number);
            }
            Console.Read();
        }

        //Mažiau kodo naudojant 1 funkcija
        static void PrintNumber(int x, bool isEqual)
        {
            //Reikalingas tarpas kad konsolėje būtų lengviau skaitomas ir suprantamas
            if(isEqual)
                Console.WriteLine(x + " is even");
            else
                Console.WriteLine(x + " is not even");
        }
        static List<int> GetIndividualNumbers(int x)
        {
            var result = new List<int>();
            while (x > 0)
            {
                var number = x % 10;
                x /= 10;
                result.Add(number);
            }
            result.Reverse();
            return result;
        }
        //Mažiau kodo eilučių bei lengvesni funkcijų pavadinimai
        static int PrintNumberSum(IEnumerable<int> Numbers, bool isEvenNumbers)
        {
            var sum = Numbers.Sum();
            if(isEvenNumbers)
                Console.WriteLine("Even numbers sum");
            else
                Console.WriteLine("Not even numbers sum");
            Console.WriteLine(sum);
            return sum;
        }
    }
}
