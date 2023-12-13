using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.StaticAnonymous
{
    public class Base
    {
        private const string formattedText = "{0} It was developed by Microsoft's Anders in the year 2000";

        void DisplayText(Func<string,string> func)
        {
            Console.WriteLine(func("C# is a popular programming language"));
        }

        public void Display()
        {
            DisplayText(static text=> string.Format(formattedText,text));
        }

        public void Display1()
        {
            DisplayText(text => string.Format(formattedText, text));
        }

        public void NonStaticAnonymousMethod()
        {
            int[] array = new int[1000000]; 

            Func<int, int> increment = x => x + 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = increment(array[i]);
            }
        }

        public void StaticAnonymousMethod()
        {
            int[] array = new int[1000000]; // Large array

            Func<int, int> increment = static x => x + 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = increment(array[i]);
            }
        }

        public void DelegateInvocationOverhead()
        {
            // Scenario 1: Delegate invocation overhead
            Action action = () => { /* do nothing */ };
            action();
        }

        public void LambdaCapturingLocalVariable()
        {
            // Scenario 2: Lambda capturing a local variable (results in heap allocations)
            int x = 10;
            Func<int, int> increment = y => x + y;
            int result = increment(5);
        }

        public void LambdaNotCapturingAnything()
        {
            // Scenario 4: Lambda not capturing anything (no heap allocation)
            Func<int, int> identity = x => x;
            int result = identity(5);
        }
    }
}
