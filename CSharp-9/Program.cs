using CSharp_9.CovariantReturnType;
using CSharp_9.InitOnlyProperty;
using CSharp_9.PatternMatching;
using CSharp_9.Record;
using CSharp_9.StaticAnonymous;
using CSharp_9.SwitchCase;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Xml.Linq;




//Switch Case
Test test = new();
string result = test.GetExperienceLevel(4);
Console.WriteLine(result);

//Init-Only Properties 
Customer customer = new() //Target-typed new Expressions
{
    FirstName = "John",
    LastName = "Doe"
};
//customer.FirstName = "John Lee";
customer.Age = 3;


/*Customer customer1 = new();
customer1.FirstName = "Pavan";*/


//Record
SignUp signUp = new() //classes
{
    UserName = "Tanya",
    Email = "tanya@gmail.com",
    Phone = "1234567890",
    ConfirmPassword = "1234567890"
};
SignUpModel signUpModel = new("Supraja", 
                              "supraja@gmail.com",
                              "1234567890",
                              "Supraja@123", 
                              "Supraja@123"); //record


var (username, email, phone, password, confirm_password) = signUpModel;
//var (username, email, phone, password, confirm_password) = signUp;

User user = new()
{
    UserName = username,
    Email = email,
    Phone = phone,
    Password = password,
    Created_at = DateTime.Now,
};

// Old Versions
User user_ = new()
{
    UserName = signUp.UserName,
    Email = signUp.Email,
    Phone = signUp.Phone,
    Password = signUp.Password,
    Created_at = DateTime.Now,
};


// Value Equality in Records

List<CourseMaterials> materials = new List<CourseMaterials>() //class
{
    new CourseMaterials() { Title = "Django", Category = "Development", Price = 900},
    new CourseMaterials() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
    new CourseMaterials() { Title = "Web Development", Category = "Development", Price = 1000}
};



List<Course> courses = new List<Course>() //record
 {
    new Course() { Title = "Django", Category = "Development", Price = 900},
    new Course() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
    new Course() { Title = "Web Development", Category = "Development", Price = 1000}
 };

CourseMaterials material = new() //class
{
    Title = "Web Development",
    Category = "Development",
    Price = 1000
};

Course course = new() //record
{
    Title = "Web Development",
    Category = "Development",
    Price = 1000
};

foreach (var item in materials) // class
{
    if (item.Title == material.Title && item.Category == material.Category && item.Price == material.Price)
    {
        Console.WriteLine("Courses with specific category and price already exists");
    }
}

foreach (var item in courses) //record
{
    if (item == course)
    {
        Console.WriteLine("Courses with specific category and price already exists");
    }
}



//Pattern Matching
Shape shape = new Shape();
Circle circle = new() { Radius = 10 };
// circle.Radius = 12;
Console.WriteLine(shape.CalculateArea(circle));


//CovariantReturnType
Book book = new ("My Book", 1, "123-567-7890");
BookOrder orderBook = book.Order(2);
Music music = new Music("My Music", 2, Format.Mp3);
MusicOrder orderMusic = music.Order(2);


//Static Anonymous
//To avoid unnecessary and wasteful memory allocation,
//we can use the static keyword on the lambda and the
//const keyword on the variable or object that we do
//not want to be captured.
Base base1 = new Base();
long start = GC.GetTotalMemory(true);
base1.NonStaticAnonymousMethod();
long stop = GC.GetTotalMemory(true);
Console.WriteLine($"Memory used by NonStaticAnonymousMethod: {stop - start} bytes");
long start1 = GC.GetTotalMemory(true);
base1.StaticAnonymousMethod();
long stop1 = GC.GetTotalMemory(true);
Console.WriteLine($"Memory used by StaticAnonymousMethod: {stop1 - start1} bytes");

Console.WriteLine("*****************************");

long startMemory = GC.GetTotalMemory(true);
base1.DelegateInvocationOverhead();
base1.LambdaCapturingLocalVariable();
EnclosingClass @class = new EnclosingClass();
@class.LambdaCapturingEnclosingInstance();
base1.LambdaCapturingLocalVariable();
long endMemory = GC.GetTotalMemory(true);
Console.WriteLine($"Memory used by the code: {endMemory - startMemory} bytes");


//Native Size Integer
Console.WriteLine("Integer Min Value is " + int.MinValue);
Console.WriteLine("Integer Max Value is " + int.MaxValue);
Console.WriteLine();
Console.WriteLine("Long Min Value is " + long.MinValue);
Console.WriteLine("Long Max Value is " + long.MaxValue);
Console.WriteLine();
Console.WriteLine("Native signed integer size in this system is " + IntPtr.Size);
Console.WriteLine("Native signed integer min value is " + nint.MinValue);
Console.WriteLine("Native signed integer max value is " + IntPtr.MaxValue);
Console.WriteLine();
Console.WriteLine("Native unsigned integer size in this system is " + UIntPtr.Size);
Console.WriteLine("Native unsigned integer min value is " + UIntPtr.MinValue);
Console.WriteLine("Native unsigned integer max value is " + UIntPtr.MaxValue);

IntPtr a = (IntPtr)5;
IntPtr b = (IntPtr)6;
IntPtr c = new IntPtr((long)a + (long)b);
//IntPtr d = a + b;


public class EnclosingClass
{
    public int InstanceState = 42;
    public void LambdaCapturingEnclosingInstance()
    {
        // Scenario 3: Lambda capturing an enclosing instance state (results in heap allocation)
        Func<int, int> add = y => InstanceState + y;
        int result = add(5);
    }
}


