using System;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {

           

            int[] scores = new int[5];
            Console.WriteLine("Welcome to my Cgpa & Cgpa percentage Calculator");


          
            Console.WriteLine("Enter first grade: ");
            int firstscore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second grade: ");
            int secondscore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third grade: ");
            int thirdscore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fourth grade: ");
            int fourthscore = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fifth grade: ");
            int fifthscore = int.Parse(Console.ReadLine());

            scores[0] = firstscore/10;
            scores[1] = secondscore/10;
            scores[2] = thirdscore/10;
            scores[3] = fourthscore/10;
            scores[4] = fifthscore/10;

            int sum = 0;
            double cgpa = 0;

           
            foreach (var score in scores)
            {
                
                sum += score;
                cgpa = sum / scores.Length;
                   

            }
            Console.WriteLine("Your cgpa : " + cgpa);
             Console.WriteLine("Your cgpa percentage  : " + cgpa*9.5 + "%");
        }


    }


}


