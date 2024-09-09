namespace MyConsoleApp.Math;

public static class ArrayTest
{   
    public static void Arrays()
    {
        int[] numbers = [3, 7, 9, 2, 14, 6];

        // length
        Console.WriteLine("Length: " + numbers.Length);

        // IndexOf()
        var index = Array.IndexOf(numbers, 9);
        Console.WriteLine("Index of 9: " + index);

        // Clear()
        Array.Clear(numbers, 0, 2); // the first to itens are set to 0, or bool set to false or num in  str[]
        Console.WriteLine("Effect of Clear()");

        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Copy()
        int[] another = new int[3];
        Array.Copy(numbers, another, 3); // copies 3 elements of numbers array to another array

        Console.WriteLine("Effect of Copy()");
        foreach (var n in another)
        {
            Console.WriteLine(n);
        }

        // Sort()
        Array.Sort(numbers); // organizes the array by value
        Console.WriteLine("Effect of Sort()");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);   
        }

        // Reverse()
        Array.Reverse(numbers); // reverses the array

        Console.WriteLine("Effect of Reverse()");
        foreach (var n in numbers)
        {
            Console.WriteLine(n);
        };
    }
}
