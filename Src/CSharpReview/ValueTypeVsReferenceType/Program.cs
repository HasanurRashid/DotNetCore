

using ValueTypeVsReferenceType;

int a = 5;
int b = 10;

b = a;

Console.WriteLine($"a = {a} b= {b}");


string aString = "H";
string bString = "N";

aString = bString;

Console.WriteLine($"a = {aString} b= {bString}");

Test1 test1 = new();

Test2 test2 = new();

Console.WriteLine($"test1 = {test1} test2 = {test2}");

