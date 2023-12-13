using CSharpFeatures_10.ExtendedPropertyPatterns;
using CSharpFeatures_10.LambdaExpressions;
using CSharpFeatures_10.Record;
using CSharpFeatures_10.AsyncMethodBuilder;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using System.Diagnostics.Metrics;
using CSharpFeatures_10.Structure;
using CSharpFeatures_10.CallerArgumentExpression;
using CSharpFeatures_10.Deconstruction;

//Extended Property Patterns
Computing computing = new Computing();
computing.Method();



//Constant interpolated strings
const string Name = "John";
const string Greeting = $"Hello, {Name}!";
//const string Greeting1 = "Hello, " + Name + "!";

//Record Struct
Doctor doctor = new Doctor(1,"Meghana",12000.0);
doctor.Name = "Shilpa";

//Readonly Record Struct
PointAxis point = new PointAxis(2.3, 4.5, 9.0);
//point.X = 10.2;

Person person = new("Nancy", "Singh", "10");
Console.WriteLine("person details"+person);

//Lambda Expressions
Test test = new();
test.greet("World");
Console.WriteLine(test.cube(4));
Console.WriteLine(test.testForEquality(4, 5));
Console.WriteLine(test.constant(2, 3));
var lambda = [DebuggerStepThrough] () => "Hello World";
string text = lambda();
Console.WriteLine(text);
// inferred type is Func<int[]>
var oneTwoThreeArray = () => new[] { 1, 2, 3 };
int[] resultantArray = oneTwoThreeArray();

for (int i = 0; i < resultantArray.Length; i++)
{
    Console.Write(resultantArray[i] + " ");
}
Console.WriteLine();
// same body, but inferred type is now Func<IList<int>
var oneTwoThreeList = IList<int> () => new[] { 5, 2, 3 };
IList<int> resultant = oneTwoThreeList();

for (int i = 0; i < resultant.Count; i++)
{
    Console.Write(resultant[i] + " ");
}
Console.WriteLine();
Func<int, bool> isEven = (int n) => n % 2 == 0;
isEven(4);
// isEven is implicitly of type Func<int, bool>
var is_Even = (int n) => n % 2 == 0;
is_Even(5);
var sum = (params int[] val) =>
{
    int sum = 0;
    foreach (int i in val)
    {
        sum += i;
    }
    return sum;
};

var empty = sum();
Console.WriteLine(empty);

/*var oneTwoThreeList = new[] { 1, 2, 3, 4 };
var total = sum(oneTwoThreeList);
Console.WriteLine(total);*/

// In C#12 default values for parameters on lambda expressions
var IncrementBy = (int source, int increment = 1) => source + increment;
Console.WriteLine(IncrementBy(5));
Console.WriteLine(IncrementBy(5, 2));

//Async Method Builder
var actual = await GetValueAsync();

Console.WriteLine("Done!");

//Improvements in struct types
Measurement measurement1 = new();
Console.WriteLine(measurement1.ToString());

Measurement measurement2 = new(1, "description");
Console.WriteLine(measurement2.ToString());

Measurement measurement3 = default;
Console.WriteLine(measurement3.ToString());

// Record types seal ToString() method
Developer dev = new Developer()
{
    Id = 1,
    Name = "ABC",
    Role = "Developer"
};

Console.WriteLine(dev.ToString());

// CallerArgumentExpression
Validation.Validate("Hello from Visual Studio");

//Assignment and declaration in the same deconstruction
var user = new User("John Lee", 31);
int age = 34;
(string fullname, age) = user;
Console.WriteLine(fullname);
Console.WriteLine(age);

[AsyncMethodBuilder(typeof(CustomAwaitableAsyncMethodBuilder<>))]
static async CustomAwaitable<string> GetValueAsync()
{
    await Task.Yield();
    return Guid.NewGuid().ToString();
}