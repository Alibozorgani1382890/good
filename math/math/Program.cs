namespace math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> StudentMarks = new Dictionary<string, int>();
            int TotalMark = 0;
            int TotalRatio = 0;

            while (true)
            {
                int Ratio;
                int Mark;
                Console.Write("Please enter the lesson name: ");
                string LessonName = Console.ReadLine();
                while (true)
                {
                    Console.Write("Please enter the lesson ratio: ");
                    string Input = Console.ReadLine();
                    if (IsInt(Input))
                    {
                        Ratio = Convert.ToInt32(Input);
                        TotalRatio += Ratio;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct Ratio!!!!");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("Please enter the lesson mark: ");
                    string Input = Console.ReadLine();
                    if (IsInt(Input))
                    {
                        Mark = Convert.ToInt32(Input);
                        if (Mark >= 0 && Mark <= 20)
                        {
                            TotalMark += Mark * Ratio;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a mark from 0 to 20!!!!!");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a correct mark!!!!!");
                        continue;
                    }
                }
                StudentMarks.Add(LessonName, Mark);
                if (StudentMarks.Count > 10)
                {
                    Console.Write("Do you want to contione? if yes enter (y) ");
                    if (Console.ReadLine() == "y")
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

            }

            double Average = (double)TotalMark / (double)TotalRatio;
            Console.WriteLine("////////////////////////////////////");
            foreach (KeyValuePair<string, int> Lesson in StudentMarks)
            {
                Console.WriteLine($"{Lesson.Key} : {Lesson.Value}");
                Console.WriteLine("============================");
            }
            Console.WriteLine("*******************************************");
            Console.WriteLine($"The Average is {Math.Round(Average, 2)}");



            static bool IsInt(string input)
            {
                foreach (char c in input)
                {
                    if (!Char.IsDigit(c))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}