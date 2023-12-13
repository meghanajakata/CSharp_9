using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures_10.Record
{
    public record struct Doctor(int Id, string Name, double Salary);

    public readonly record struct PointAxis(double X, double Y, double Z);

    public class Patient
    {
        public int Id;
        public string Name;
    }

    public record Person(string FirstName, string LastName, string Id)
    {
        internal string Id { get; init; } = Id;
    }

    public record Employee
    {
        public int Id { get; set; }
        public string Name {  get; set; }
        public sealed override string ToString()
        {
            return String.Format("Values of Employee are" + Id + " Name" + Name);
        }
    }

    public record Developer : Employee
    {
        public string Role {  get; set; }
    }
}
