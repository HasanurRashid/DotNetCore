// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Collections;
using ReflectionCopy2;

Course course = new Course("C#", 8000, new List<Topic>
{
    new Topic{ Title="Introduction",Duration=2},
    new Topic{ Title="Getting Started",Duration=4}
});

Type types = course.GetType();

var properties = types.GetProperties(BindingFlags.Instance | BindingFlags.Public);

foreach(var property in properties)
{
    if (property.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
    {
        var items = (IEnumerable)property.GetValue(course);
        foreach(var item in items)
        {
            var it = item.GetType();
            var topocTypes = it.GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach(var topocType in topocTypes)
            {
                Console.WriteLine(topocType.GetValue(item));
            }
           
        }
    }
    else
    Console.WriteLine(property.GetValue(course));
}

//Console.WriteLine(types.GetProperty();
