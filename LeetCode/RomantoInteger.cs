public class RomantoInteger
{
    public static int ConvertRomanToInterger(string romanLetters)
    {
        var romanToInt = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        var LengthofString = romanLetters.Length; // lenght of the inputed string

        var sum = romanToInt[romanLetters[LengthofString - 1]]; // creating of variable sum and getting the last indice of the inputed string

        for (int i = LengthofString - 1; i > 0; i --)
        {
            if(romanToInt[romanLetters[i - 1]] >= romanToInt[romanLetters[i]])
            {
                sum += romanToInt[romanLetters[i - 1]];
            }else
            {
                sum -= romanToInt[romanLetters[i -1]];
            }
        }
        return sum;
    }
}