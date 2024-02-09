using Exercises.Exercise1;
using Exercises.Exercise2;
using Exercises.Exercise3;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            var exercise1 = new MyExercise1();


            // Exercise 2
            var exercise2 = new MyExercise2();


            // Exercise 3
            var exercise3 = new MyExercise3();
            string filePath1 = Path.Combine(Directory.GetCurrentDirectory(), "Exercise3", "file1.csv");
            string filePath2 = Path.Combine(Directory.GetCurrentDirectory(), "Exercise3", "file2.csv");
            string outputPath = Path.Combine(Directory.GetCurrentDirectory(), "Exercise3", "outputFile.csv");
            exercise3.ProcessFiles(filePath1, filePath2, outputPath);
        }
    }
}