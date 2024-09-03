namespace MyConsoleApp.Classes
{
    public class ClassTests
    {
        public static string ClassText()
        {
            var a = 10;
            var b = a;
            b++;
            var text = string.Format("a: {0}, b: {1}", a, b);

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            var text2 = string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]);
            return text + "; " + text2;
        }
    }
}