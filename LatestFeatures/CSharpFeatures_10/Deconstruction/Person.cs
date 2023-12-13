using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures_10.Deconstruction
{
    public class User
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public User(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }
        public void Deconstruct(out string fullname, out int age)
        {
            fullname = FullName;
            age = Age;
        }
    }
}
