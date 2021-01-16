using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            Console.WriteLine("Please input your numbers below, separated with a comma or space: ");
            string input = Console.ReadLine();
            char[] cDividers = { ',', ' ' };
            string[] segments = input.Split(cDividers);
            double[] intValues = Array.ConvertAll(segments, s => double.Parse(s));

            //user options for math
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.WriteLine("\tq - Square");
            Console.Write("Your option? ");

            //switch statement
            switch (Console.ReadLine())
            {
                case "a":
                    double aresult = 0.0;
                    foreach (string a in segments)
                    {
                        aresult = aresult + double.Parse(a);
                    }
                    Console.WriteLine("Total:" + aresult);
                    break;
                case "s":
                    double sresult = double.Parse(segments[0]);
                    for (int i = 1; i < segments.Length; i++)
                    {
                        sresult -= double.Parse(segments[i]);
                    }
                    Console.WriteLine("Total:" + sresult);
                    break;
                case "m":
                    double mresult = 1.0;
                    foreach (string m in segments)
                    {
                        mresult = mresult * double.Parse(m);
                    }
                    Console.WriteLine("Total:" + mresult);
                    break;
                case "d":
                    double dresult = double.Parse(segments[0]);
                    for (int i = 1; i < segments.Length; i++)
                    {
                        dresult /= double.Parse(segments[i]);
                    }
                    Console.WriteLine("Total:" + dresult);
                    break;
                case "q":
                    var squares = Array.ConvertAll(intValues, x => x * x);
                    string qresult = "";
                    char trimChar = ',';
                    for (int i = 0; i < segments.Length; i++)
                    {
                        qresult += squares[i] + ",";
                    }
                    Console.WriteLine(qresult.TrimEnd(trimChar));
                    break;
            }
        }
    }
}


