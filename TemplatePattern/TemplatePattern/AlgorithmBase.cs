using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class AlgorithmBase
    {
        public void TemplateMethod()
        {
            this.Step1();
            this.Step2();
            this.Step3();
            this.Step4();
            this.Hook1();

        }
        public void Step1()
        {
            Console.WriteLine("doing step 1...");
        }
        public void Step2()
        {
            Console.WriteLine("doing step 2...");
        }

        public abstract void Step3();

        public void Step4()
        {
            Console.WriteLine("doing step 4...");
        }
        // These are "hooks." Subclasses may override them, but it's not
        // mandatory since the hooks already have default (but empty)
        // implementation. Hooks provide additional extension points in some
        // crucial places of the algorithm.
        protected virtual void Hook1() { }
    }
}
