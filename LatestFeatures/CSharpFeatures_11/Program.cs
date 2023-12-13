// List Patterns
// The list pattern is to check, if sequence elements match corresponding nested patterns.
Console.WriteLine("List Patterns: ");
Test test = new();
test.Pattern();
test.Deconstruction();
var emptyArray = Array.Empty<string>();
var myName = new[] { "David Warner" };
var myNameFields = new[] { "David", "Warner" };
var myNameMiddleFields = new[] { "David", "Abraham", "Warner" };
test.SwitchStatement(emptyArray);
test.SwitchStatement(myName);
test.SwitchStatement(myNameMiddleFields);
test.SwitchStatement(myNameFields);

//UTF-8 string literals C# 11
Console.WriteLine("\nUTF-8 String Literals: ");
byte[] U8_StringLiteral = Encoding.UTF8.GetBytes("Hello World");
String byteArrayAsString = string.Join("", U8_StringLiteral);
Console.WriteLine($"StringLiteral: {byteArrayAsString}");

byte[] U8StringLiteral = "Hello World"u8.ToArray();
string byteArrayasString = string.Join("", U8StringLiteral);
Console.WriteLine($"StringLiteral: {byteArrayasString}");

//newlines in string interpolation
Console.WriteLine("\nNewLines in String Interpolation:");
int age = 44;
Console.WriteLine($"The User is {age} years old, which is {age switch
{
    > 80 => "old",
    > 60 => "getting old",
    > 20 => "a good age",
    _ => "young"
}}");

//file access modifier
Console.WriteLine("\nFile access modifier:");
var userProvider = new UserProvider();
Console.WriteLine(userProvider.Name);

//raw string literals
Console.WriteLine("\nRaw String Literals:");
string rawString;
string level = "Warning";
rawString = $$$""""
            {
                "Logging":{
                    "LogLevel":{
                        "Default":"{{{level}}}",
                        "Microsoft.AspNetCore":"""Warning"""
                    }
                },
                "AllowedHosts":"*"
            }
            """";
/*rawString = @"{
                ""Logging"":{
                    ""LogLevel"":{
                        ""Default"":""Information"",
                        ""Microsoft.AspNetCore"":""Warning""
                    }
                },
                ""AllowedHosts"":""*""
            }
            ";*/
Console.WriteLine(rawString);

//Required Members
//for class person
//Person person1 = new Person(); //Required fields must be initialize
Person person2 = new Person()
{
    FirstName = "Tommy",
    MiddleName = "Lee",
    LastName = "Jones"
};

Person person3 = new Person
{
    FirstName = "Tommy",
    LastName = "Jones"
};
//for struct employee
Employe employe = new Employe
{
    FirstName = "John",
    MiddleName = "Doe",
    LastName = "Smith"
};
//FOR record customer
Customer customer = new Customer
{
    FirstName = "John",
    MiddleName = "Doe",
    LastName = "Smith"
};

JobSeeker candidate = new JobSeeker();
//Console.WriteLine(candidate.Name);

//Auto-Default Struct
Console.WriteLine("\nAuto Default Struct:");
Employee employee = new Employee();
Console.WriteLine($"Id:{employee.id}, Name: {employee.name}");

//Pattern match Span<char> on a constant string
Console.WriteLine("\nPattern match Span<char> on a constant string:");
Console.WriteLine("Enter MobileNumber with country code(example=> +919876543210):");
var PhoneNumber = Console.ReadLine();
ReadOnlySpan<char> slicedSpan = PhoneNumber.AsSpan(0, PhoneNumber.Length - 10);
string country = string.Empty;
if (slicedSpan is "+91")
    country = "India";
else if (slicedSpan is "+1")
    country = "United States";
else if (slicedSpan is "+44")
    country = "United Kingdom";
else if (slicedSpan is "+81")
    country = "Japan";
else
    country = "Not Found";

country = slicedSpan switch
{
    "+91" => "India",
    "+1" => "USA",
    "+44" => "United Kingdom",
    "+81" => "Japan",
    _ => "Not Found",
};
Console.WriteLine("Entered PhoneNumber is registered in " + country);

//Static Abstract Members
Console.WriteLine("\nStatic Abstract Members:");
Height heightAverage = Average(new Height(1.5), new Height(2), new Height(3), new Height(4));
Console.WriteLine(heightAverage.Val);
Console.WriteLine();
Class1 obj1 = new();
Class2 obj2 = new();
Class1 obj3 = obj2;

// Static abstract cannot be made virtual
Demo demo = new Demo();
demo.ConsoleWriteLine(obj1);
demo.ConsoleWriteLine(obj2);
demo.ConsoleWriteLine(obj3);
Console.WriteLine();

//Numeric IntPtr
//IntPtr => nint, UIntPtr => nuint
Console.WriteLine("\nNumeric IntPtr");
Console.WriteLine("Native signed integer size in this system is " + nint.Size);
Console.WriteLine("Native signed integer size in this system is " + nuint.Size);

nint i = 5;
nint j = 6;
nint k = i + j;

//Generic Attribute
Console.WriteLine("\nGeneric Attribute:");
var type = typeof(User);
var CustomAttributes = type.GetCustomAttributes(false); //reflection
foreach (var customAttribute in CustomAttributes)
{
    if (customAttribute is CustomAttribute<string>)
    {
        Console.WriteLine(((CustomAttribute<string>)customAttribute).CurrentType.Name); //string
    }
}

ProcessUser<int, UserWithInt>(5, 7);
ProcessUser<string, UserWithString>("Hello, ", "World!");

static void ProcessUser<T, U>(T value1, T value2) where U : class
{
    var userType = typeof(U);
    var customAttributes = userType.GetCustomAttributes(false);
    foreach (var customAttribute in customAttributes)
    {
        if (customAttribute is CustomAttribute<T>)
        {
            Console.Write($"{userType.Name}:");
            Console.WriteLine(((CustomAttribute<T>)customAttribute).CurrentType.Name);
            var customAttr = (CustomAttribute<T>)customAttribute;
            T result = customAttr.Addition(value1, value2);
            Console.WriteLine($"Addition result: {result}");
        }
    }
}
static T Average<T>(params T[] array) where T : IMeasuarable<T>
{
    if (array.Length == 0)
    {
        return T.Zero;
    }
    T result = T.Zero;
    T denominator = T.Zero;
    foreach (T val in array)
    {
        result += val;
        denominator += T.One;
    }
    return result / denominator;
}