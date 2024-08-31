namespace LeetCode.Easy;

public class StringCountAsASubstringSolution
{
    public static int NumOfStrings(string[] patterns, string word)
    {
        int substringCount = 0;

        for (int i = 0; i < patterns.Length; i++) // iterate through the patterns array
        {
            bool isEqual = false;
            int patternWordCharacterIndex = 1;
            int capturedSimilarIndex = 0;
            for (int j = 0; j < word.Length; j++) // iterate through a single pattern (string)
            {
                // patternWordCharacterIndex = 0;
                if (patterns[i][patternWordCharacterIndex - 1] == word[j])
                {
                    capturedSimilarIndex = j;
                    isEqual = true;

                    if (patterns[i].Length > 1)
                    {
                        for (int k = j + 1; k < word.Length; k++) // compare it with the original word
                        {
                            // patternWordCharacterIndex++;
                            if (patternWordCharacterIndex < patterns[i].Length)
                            {
                                if (patterns[i][patternWordCharacterIndex] != word[k])
                                {
                                    isEqual = false;
                                    break;
                                }
                                
                                patternWordCharacterIndex++;
                            }
                            
                            // else
                            // {
                            //     isEqual = false;
                            //     break;
                            // }

                            // index++;
                        }
                    }
                    // index need to be updated
                }
                // else
                // {
                //     index++;
                //     isEqual = false;
                // }

                if (isEqual)
                {
                    // patternWordCharacterIndex = 0;
                    break;
                }
                
                patternWordCharacterIndex = 1;
            }

            if (isEqual && (word.Length - capturedSimilarIndex + 1) >= patterns[i].Length && word.Length >= patterns[i].Length)
            {
                substringCount++;
                // Console.WriteLine(patterns[i]);
                // isEqual = false;
            }
        }

        return substringCount;
    }
}