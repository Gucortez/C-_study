// Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);     
int x = 1000; // 232 is the max for bytes
byte b = (byte)x; // cast
string number = "1234";
// int i = (int) number; //string cannot be cast to int
int i = Convert.ToInt32(number); // has to use convert
Console.WriteLine(b);
Console.WriteLine(i);

try
{
    string str = "true";
    bool c = Convert.ToBoolean(str);
    Console.WriteLine(c);
}
catch (Exception)
{
    Console.WriteLine("The number could not be converted to a byte;"); // prevents the app to crash
}

var v = true;
var y = false;
var z = true || false;
Console.WriteLine("v = {0}, y = {1}, z = {2}", v, y, z);

// putting static makes the method acessible in other classes