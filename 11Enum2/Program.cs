using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Enum2
{
    class Program
    {
        enum Job
        {
            Baecker=5, 
            Metzger,
            Maurer        
        }

        enum Job2
        {
            Baecker = 500,
            Metzger = 45645,
            Maurer = 445
        }

        enum JobBin
        {
            Baecker = 1,
            Metzger = 2,
            Maurer = 4
        }

        static void Main(string[] args)
        {
            Job job = Job.Metzger;
            Console.WriteLine(job);
            Console.WriteLine((int)job);
            Console.WriteLine();

            switch(job)
            {
                case Job.Baecker:
                    Console.WriteLine("Bäcker");
                        break;
                case Job.Maurer:
                    Console.WriteLine("Maurer");
                    break;
                case Job.Metzger:
                    Console.WriteLine("Fleischer");
                    break;
                default:
                    Console.WriteLine("Undefined");
                    break;
            }
            Console.WriteLine();


            Job2 job2 = Job2.Maurer;
            Console.WriteLine(job2);
            Console.WriteLine((int)job2);
            Console.WriteLine();

            JobBin job3 = JobBin.Baecker | JobBin.Maurer;
            if ((job3 & JobBin.Baecker) == JobBin.Baecker)
            {
                Console.WriteLine(JobBin.Baecker);
            }
            if ((job3 & JobBin.Maurer) == JobBin.Maurer)
            {
                Console.WriteLine(JobBin.Maurer);
            }
            if ((job3 & JobBin.Metzger) == JobBin.Metzger)
            {
                Console.WriteLine(JobBin.Metzger);
            }
            Console.WriteLine();

        }
    }
}
