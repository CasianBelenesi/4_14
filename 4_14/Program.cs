using System;

namespace _4_14
{

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Counter c = new Counter("heads");
            c.Increment();
            while ( n > 0)
            {
                c.Increment();
                n--;
            }


            Console.WriteLine(c.Count);
            Counter heads = new Counter("heads");
            Counter tails = new Counter("tails");
            Random random = new Random();
            for (int i = 0; i < 10000; i++)
            {
                switch (random.Next(2))
                {
                    case 0:
                        heads.Increment();
                        break;
                    case 1:
                        tails.Increment();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Heads: {heads.Count}, Tails: {tails.Count}");



            ModulusCounter mc = new ModulusCounter(10 , "zece") ;

            for ( int i = 0; i < 100; i++ )
            {
                mc.Increment();
                Console.WriteLine(mc);
            }

            MultiCounter multicounter = new MultiCounter(4, 10);
            for (int i = 0; i < 1500; i++)
            {
                multicounter.Increment();
                Console.WriteLine(multicounter)
                
            }

        }
    }
    }
    }
}
