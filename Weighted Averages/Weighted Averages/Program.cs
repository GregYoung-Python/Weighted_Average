using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weighted_Averages
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declare Constants
            const double HOME_WORK = .10;
                  double       PROJECT = .35;
                  double       QUIZZ = .10;
                  double       EXAM = .30;
                  double       FINAL_EXAM = .15;

            //Input from user
            //Declare variables
               int      homeworkScore = 97;
               int      projectScore = 89;
               int      quizzScore = 94;
               int      examScore = 90;
               int      finalExamScore = 98;


           
            //Do Calculations
           double     Homework =  HOME_WORK * homeworkScore;
           double     Project =   PROJECT * projectScore;
           double     Quizz =     QUIZZ * quizzScore;
           double     Exam =      EXAM * examScore;
           double     FinalExam = FINAL_EXAM * finalExamScore;
           double     Average =   Homework + Quizz + Exam + FinalExam + Project;




            //Display Outputs

            Console.WriteLine("Enter the average score for Homework:97");
            Console.WriteLine("Enter the average score for Projects: 89");
            Console.WriteLine("Enter the average score for Quiz: 94");
            Console.WriteLine("Enter the average score Exams: 90");
            Console.WriteLine("Enter the final exam score: 98");



            Console.WriteLine("\n          Grading App           ");



            Console.WriteLine("\nHomework   (10%):     97");
            Console.WriteLine("Projects   (35%):     89");
            Console.WriteLine("Quizzes    (10%):     94");
            Console.WriteLine("Exams      (30%):     90");
            Console.WriteLine("Final Exam (15%):     98");
            Console.WriteLine("Final Grade:          " + Average);
            Console.WriteLine("\nPress Any Key to Continue...");
            Console.ReadKey();
            
             
           



            



          











        


                        









        }
    }
}
