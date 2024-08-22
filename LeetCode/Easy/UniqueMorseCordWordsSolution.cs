namespace LeetCode.Easy;

public class UniqueMorseCordWordsSolution
{
    public static int UniqueMorseRepresentations(string[] words)
    {
        string[] morseCodeOfChars = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        string morseCodeWord = "";
        List<string> decodedMorseCodes = new List<string>();
        
        foreach (var word in words)
        {
            foreach (var c in word)
            {
                morseCodeWord += morseCodeOfChars[c - 97];
            }

            if (!decodedMorseCodes.Contains(morseCodeWord))
            {
                decodedMorseCodes.Add(morseCodeWord);
            }

            morseCodeWord = "";
        }

        return decodedMorseCodes.Count;
    }
}