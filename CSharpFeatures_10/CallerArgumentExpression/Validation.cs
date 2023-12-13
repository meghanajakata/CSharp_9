using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures_10.CallerArgumentExpression
{
    public class Validation
    {
        public static void Validate(string condition, [CallerArgumentExpression("condition")] string? message = null)
        {
            throw new InvalidOperationException($"Argument failed validation: <{message}>");
        }
    }
}
