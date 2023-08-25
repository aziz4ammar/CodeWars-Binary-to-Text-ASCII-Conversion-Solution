using System;
using System.Text;

public static class Kata
{
    public static string BinaryToString(string binary)
    {
        var text = new StringBuilder();
        int chunkSize = 8;

        // Loop through the binary string in chunks of 8 characters
        for (int i = 0; i < binary.Length; i += chunkSize)
        {
            string chunk = binary.Substring(i, Math.Min(chunkSize, binary.Length - i));

            // Convert the chunk to its ASCII equivalent
            int asciiValue = Convert.ToInt32(chunk, 2);
            char asciiChar = (char)asciiValue;

            // Append the ASCII character to the result text
            text.Append(asciiChar);
        }

        return text.ToString();
    }
}