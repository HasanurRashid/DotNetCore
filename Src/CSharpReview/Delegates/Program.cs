// See https://aka.ms/new-console-template for more information

using Delegates;

BubbleSort<int> bubbleSort = new();

var items = bubbleSort.Sort(new int[] { 9, 5, 2, 4, 8, 1 }, Check);

foreach (int item in items)
{
    Console.Write(item);
    Console.Write(' ');
}




//bool Check(int a, int b)
//{
//    return a < b;
//}

bool Check(int a, int b) => a < b; // lambda expression

Person[] person = new Person[]
{
    new Person(){Name="Hasan", Age = 32 },
    new Person(){Name="Rashid", Age = 30 },
    new Person(){Name="Hasan", Age = 29 },
};

BubbleSort<Person> person1 = new();
var result = person1.Sort(person, ComparePerson);

Console.WriteLine();
bool ComparePerson(Person a, Person b)
{
    if(a.Name == b.Name)
        return a.Age > b.Age;
    else
        return a.Name.CompareTo(b.Name) > 0;
}

foreach(var item in result)
{
    Console.WriteLine($"Name : {item.Name} Age: {item.Age}\n");
}

