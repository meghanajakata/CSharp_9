
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp_11.Generic_Attribute;

//[Custom(typeof(string))]
[Custom<string>()]
public class User 
{
    public string Name { get; set; }
    public required string Address { get; set; }
    public int Phone{ get; set; }
}

[Custom<int>()]
public class UserWithInt
{
    public int Age { get; set; }
}

[Custom<string>()]
public class UserWithString
{
    public string Name { get; set; }
}

/*
[Custom<T>()]
[Custom<string?()]
[Custom<dynamic>()]
[Custom<(int a, int b)>()]*/
[Custom<Tuple<int, int>>()]
internal class GenericUser
{
    public string Name { get; set; }
}
