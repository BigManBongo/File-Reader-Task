using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (StreamWriter writer = new StreamWriter("counting.txt"))
        {
            for (int loopIndex = 0; loopIndex <= 10; loopIndex++)
            {
                writer.WriteLine(loopIndex);
            }
        }
    }
}

