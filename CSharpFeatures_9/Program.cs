using CSharpFeatures_9.Record;
using System;
using System.Collections.Generic;

namespace CSharpFeatures_9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            SignUpModel signUpModel = new("Supraja", "supraja@gmail.com", "1234567890", "Supraja@123", "Supraja@123");

            SignUp signUp = new()
            {
                UserName = "Tanya",
                Email = "tanya@gmail.com",
                Phone = "1234567890",
                Password = "1234567890",
                ConfirmPassword = "1234567890"
            };

            var (username,email,phone,password,confirm_password) = signUpModel;

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
            List<Course>courses = new List<Course>()
            {
                new Course() { Title = "Django", Category = "Development", Price = 900},
                new Course() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
                new Course() { Title = "Web Development", Category = "Development", Price = 1000}
            };

            List<CourseMaterials> materials = new List<CourseMaterials>()
            {

                new CourseMaterials() { Title = "Django", Category = "Development", Price = 900},
                new CourseMaterials() { Title = "Digital Marketing ", Category = "Marketing", Price =1500 },
                new CourseMaterials() { Title = "Web Development", Category = "Development", Price = 1000}
            };
            Course course = new()
            {
                Title = "Web Development",
                Category = "Development",
                Price = 1000
            };

            Course course_ = new()
            {
                Title = "Web Development",
                Category = "Development",
                Price = 500
            };

            CourseMaterials material = new()
            {
                Title = "Web Development",
                Category = "Development",
                Price = 1000
            };

            foreach(var item in courses)
            {
                if(item == course)
                {
                    Console.WriteLine("Courses with specific category and price already exists");
                }
            }

            foreach(var item in  materials)
            {
                if(item.Title == material.Title &&  item.Category == material.Category && item.Price == material.Price)
                {
                    Console.WriteLine("Courses with specific category and price already exists");
                }
            }


            Console.WriteLine("signup model is" + signUp + confirm_password + user + user_);
            Console.WriteLine("Courses are " + (course == course_));

        }
    }
}