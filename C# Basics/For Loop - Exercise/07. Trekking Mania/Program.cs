using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupCount = int.Parse(Console.ReadLine());
            int musala, monblan, kilimandjaro, k2, everest, sum;
            musala = monblan = kilimandjaro = k2 = everest = sum = 0;
            for (int i = 0; i < groupCount; i++)
            {
                int groupPpl = int.Parse(Console.ReadLine());
                sum += groupPpl;
                if (groupPpl <= 5)
                {
                    musala += groupPpl;
                }
                else if (groupPpl <= 12)
                {
                    monblan += groupPpl;
                }
                else if (groupPpl <= 25)
                {
                    kilimandjaro += groupPpl;
                }
                else if (groupPpl <= 40)
                {
                    k2 += groupPpl;
                }
                else
                {
                    everest += groupPpl;
                }

            }

            Console.WriteLine($"{(musala / (sum * 1.0) * 100.0):F2}%");
            Console.WriteLine($"{(monblan / (sum * 1.0) * 100.0):F2}%");
            Console.WriteLine($"{(kilimandjaro / (sum * 1.0) * 100.0):F2}%");
            Console.WriteLine($"{(k2 / (sum * 1.0) * 100.0):F2}%");
            Console.WriteLine($"{(everest / (sum * 1.0) * 100.0):F2}%");
        }
    }
}
