using MyConsoleApp.Math;
using MyConsoleApp.People;
using MyConsoleApp.Classes;

var john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.Introduce();

var result = Calculator.Add(1, 2);
System.Console.WriteLine(result);

// declaring arrays
// int[] numbers = new int[3] {1, 2, 3};
// values in {}
string name = "Mosh";
char firstChar = name[0];
System.Console.WriteLine(firstChar);

var stringsLesson = StringTest.Names();
System.Console.WriteLine(stringsLesson);

var array = ArrayTest.Arrays();
System.Console.WriteLine(string.Join(", ", array));

// instead of using multiple const you can use enum
/* 
const int RegularAirMail = 1,
const int RegisteredAirMail = 2,
const int Express = 3;
public enum Shipping method
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3;
}
*/
var methodId = 3;
System.Console.WriteLine((EnumTest.ShippingMethod)methodId); // output = Express

var method = EnumTest.ShippingMethod.Express; // call the enum that you want
System.Console.WriteLine((int)method);

System.Console.WriteLine(method.ToString()); // convert enum to string, output = Express

var methodName = "Express";
var shippingMethod = (EnumTest.ShippingMethod)Enum.Parse(typeof(EnumTest.ShippingMethod),methodName); // string to enum, parse and cast
System.Console.WriteLine(shippingMethod);

var classText = ClassTests.ClassText();
System.Console.WriteLine(classText);

var numb = 1;
Person.Increment(numb);
System.Console.WriteLine(numb); // the method takes a copy of the numb, making the original numb unchanged, because only the copy was altered. output = 1

var person = new Person() {Age = 20};
Person.MakeOld(person);
System.Console.WriteLine(person.Age); // method takes the reference to the same memory location, so the object is altered. output = 30

/* 
Summary:
Value Types: Changes are made on a copy, so the original value remains unchanged (e.g., int, bool, char, struct).
Reference Types: Changes are made on the original object since the method operates on a reference to the same object (e.g., class, array, delegate).*/


