using System;

class Program
{
    static void Main()
    {
        int numDecimal = int.Parse(Console.ReadLine());
        string numBinary = string.Empty;

        while (numDecimal != 0)
        {
            int a = (int)numDecimal % 2;
            numDecimal /= 2;
            numBinary = a + numBinary;
        }
        Console.WriteLine(numBinary);
    }
}
