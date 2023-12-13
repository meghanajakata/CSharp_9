using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_11.Generic_Attribute;
public class CustomAttribute<T> : Attribute
{
    public Type CurrentType => typeof(T);

    public T Addition(T value1, T value2) => (dynamic)value1 + (dynamic)value2;
}

/*public class CustomAttribute : Attribute
{
    private readonly Type type;
    public CustomAttribute(Type type)
    {

        this.type = type;

    }
    public Type CurrentType => type;
}*/

