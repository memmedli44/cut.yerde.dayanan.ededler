using System.Reflection.Emit;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            label1:
            Console.Write("ededi daxil edin: ");
            string stl= Console.ReadLine();
            bool situate = int.TryParse(stl, out int eded);
            int say=(int)Math.Log10(eded)+1;
            int eded2=0;
            if (!situate)
            {
                goto label1;
            }
            while (eded > 0)
            {
                if (say % 2 == 0)
                {
                    int qaliq = eded % 10;
                    eded = eded / 100;
                    eded2 = eded2  * 10 + qaliq;
                        
                }
                else
                {
                    eded = eded / 10;
                    int qaliq = eded % 10;
                    eded = eded / 10;
                    eded2 = eded2 * 10 + qaliq;

                    

                }

            }
            int sum = 0;
            while (eded2 > 0)
            {
                int qaliq2 = eded2 % 10;
                eded2 = eded2 / 10;
                sum = sum * 10 + qaliq2;

            }
            Console.WriteLine(sum);
           





        }
    }
}