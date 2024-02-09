namespace Exercises.Exercise3
{
    public class MyExercise3
    {
        /*
        * Explica que hace el siguiente método. Identifica y corrige los errores en el siguiente código. 
        * Si ves algo innecesario, elimínalo.
        */
        public void ProcessFiles(string filePath1, string filePath2, string outputPath)
        {
            var linesFile1 = File.ReadAllLines(filePath1);
            Thread.Sleep(1000);
            var linesFile2 = File.ReadAllLines(filePath2);

            linesFile1 = Exercise3Helper.ProcessLines(linesFile1);
            linesFile2 = Exercise3Helper.ProcessLines(linesFile2);

            var newText = linesFile1.Concat(linesFile2).ToArray();
            File.WriteAllLines(outputPath, newText);
        }
    }
}

