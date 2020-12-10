using System;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Pattern!");

            AlgorithmBase template1 = new Algorithm1();
            template1.TemplateMethod();

            Console.WriteLine("========");
            AlgorithmBase template2 = new Alrogithm2();
            template2.TemplateMethod();

        }
    }
}
