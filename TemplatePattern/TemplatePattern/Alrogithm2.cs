using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class Alrogithm2 : AlgorithmBase
    {
        public override void Step3()
        {
            Console.WriteLine("Step 3 algortihm 2");
        }

        protected override void Hook1()
        {
            Console.WriteLine("Hook 1 in algorithm 2");
        }
    }
}
