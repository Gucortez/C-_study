namespace MyConsoleApp.People;

public class StringTest
{
    public static string Names()
    {
        var firstName = "Mosh";
        var lastName = "Hamedani";

        var fullName = firstName + " " + lastName;

        var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

        var names = new string[3] {"John", "Jack", "Mary"};
        var formattedNames = string.Join(", ", names);

        var text = @"Hi John
        Look into the follwing paths
        c:\folder1\folder2
        c:\folder3\folder4";

        return formattedNames + "; " + myFullName + "; " + fullName + "; " + text;
    }
}
