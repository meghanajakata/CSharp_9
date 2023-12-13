using System.Diagnostics.CodeAnalysis;

namespace CSharp_11.RequiredMember;

/// <summary>
/// Required Members
/// </summary>
public class Person
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
    //public static required int Age {get; set;} //Required cannot apply to a static members
    //public required const int Eyes = 2; // Required cannot apply to a const members
}
public struct Employe
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
}
public record Customer
{
    public required string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public required string LastName { get; set; }
}
/*public interface User // Required cannot apply in the interface
{
    public required int Id { get; set; }
}*/
class JobSeeker
{
    [SetsRequiredMembers]
    public JobSeeker()
    {
        Name = "ABC";
    }
    public required string Name { get; init; }
}
