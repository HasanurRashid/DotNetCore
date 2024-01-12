
using Reflection;
using System.Reflection;
using System.Collections;

Assembly assembly  = Assembly.GetExecutingAssembly();

foreach (var t in assembly.GetTypes())
{
    if (t.Name == "Program")
    {
        var methods = t.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
        foreach (var m in methods)
        {
            Console.WriteLine(m.Name);
        }
    }
}



Course course = new Course("C#",8000.00m, new List<Topic>
{
   new Topic{Title = "Tool Installation", Duration = 2 },
   new Topic{Title = "Getting Started", Duration = 4 },
});


// Type t = typeof(Course); // Jodi Object Na thake typeof diya likhte hoy

Type type = course.GetType(); 
 

var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);

foreach (var property in properties)
{

    if(property.PropertyType.GetInterfaces().Contains(typeof(IEnumerable)))
    {
        //Type p = property.GetType();
        {
            //Type[] genericArguments = p.GetGenericArguments();
            var items = (IEnumerable)property.GetValue(course);
            foreach(var item in items)
            {
                // Console.WriteLine(item);
                var it = item.GetType();
                var topicTypes = it.GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach(var topicType in topicTypes)
                {
                    var value = topicType.GetValue(item);
                    Console.WriteLine(value);
                }
            }
        }
        Console.WriteLine();
    }
    else
    {
        // Console.WriteLine(property.Name);
        Console.WriteLine(property.GetValue(course));
    }
}
