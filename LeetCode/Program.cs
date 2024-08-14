// See https://aka.ms/new-console-template for more information

using LeetCode.Easy;

Console.WriteLine("Hello, World!");

// REVERSE STRING
// char[] chars = { 'h', 'e', 'l', 'l', 'o' };
//
// var x = ReverseStringSolution.ReverseString(chars);
//
// foreach (var s in x)
// {
//     Console.WriteLine(s);
// }

// CLEAR DIGITS
// Console.WriteLine(ClearDigitsSolutions.ClearDigits("7"));

// REVERSE VOWELS
// var s = ".a";
// var output = ReverseVowelsSolution.ReverseVowels(s);
// Console.WriteLine(output);

// LENGTH OF LAST WORD
// var s = "   fly me   to   the moon  ";
// Console.WriteLine(LengthOfLastWordSolution.LengthOfLastWord(s));

// VALID PALINDROME
// var s = "A man, a plan, a canal: Panama";
// Console.WriteLine(ValidPalindromeSolution.IsPalindrome(s));

// RANSOM NOTE
// string ransomNote = "aa", magazine = "aab";
// Console.WriteLine(RansomNote.CanConstruct(ransomNote:ransomNote, magazine:magazine));

// FIRST UNIQUE CHARACTER IN A STRING
// string s = "leetcodel";
// Console.WriteLine(FirstUniqueCharacterSolution.FirstUniqChar(s));

// FIND THE DIFFERENCE
// string s = "", t = "a";
// Console.WriteLine(FindDifferenceSolution.FindTheDifference(s, t));

// ADD STRINGS
// string num1 = "401716832807512840963", num2 = "167141802233061013023557397451289113296441069";
// Console.WriteLine(AddStringsSolution.AddStrings(num1, num2));

// REVERSE WORDS IN A STRING III
// string words = "Let's take LeetCode contest";
// string result = ReverseWordsInAStringIIISolution.ReverseWords(words);
// Console.WriteLine(result);

// ROBOT RETURN TO ORIGIN
// string moves = "LL";
// Console.WriteLine(RobotReturnToOriginSolution.JudgeCircle(moves));

// DIVIDE A STRING INTO GROUPS SIZE OF K
// string s = "abcdefghij";
// int k = 3;
// char fill = 'x';
// string[] result = DivideStringIntoGroupSizeKSolution.DivideString(s, k, fill);
// foreach (var res in result)
// {
//     Console.WriteLine(res);
// }

// COUNT ITEMS MATCHING A RULE
// List<IList<string>> items = [["phone","blue","pixel"],["computer","silver","phone"],["phone","gold","iphone"]];
// string ruleKey = "type", ruleValue = "phone";
// Console.WriteLine(CountItemsMatchingARuleSolution.CountMatches(items, ruleKey, ruleValue));

// SPLIT A STRING IN BALANCED STRINGS
// var s = "RLLLLRRRLR";
// Console.WriteLine(SplitStringInABalanceStringSolution.BalancedStringSplit(s));

// DECRYPT STRING FROM ALPHABET TO INTEGER MAPPING
// string s = "824#15#826#";
// Console.WriteLine(DecryptStringFromAlphToIntMapSolution.FreqAlphabets(s));

// GENERATE A STRING WITH CHARACTERS THAT HAVE ODD COUNTS
// Console.WriteLine(GenerateStringWithOddCountCharacters.GenerateTheString(5));

// SCORE OF A STRING
// Console.WriteLine(ScoreOfAString.ScoreOfString("zaz"));

// FINAL VALUE OF A VARIABLE AFTER PERFORMING OPERATIONS 
// var operations = new[] {"++X","++X","X++"};
// Console.WriteLine(FinalValueOfAVarialbleAfterPerformingOperationsSolution.FinalValueAfterOperations(operations));

// DEFANGING AN IP ADDRESS
// string address = "255.100.50.0";
// Console.WriteLine(DefangingIpAddressSolution.DefangIPaddr(address));

// PERMUTATION DIFFERENCE BETWEEN TWO STRINGS
// string s = "abcde", t = "edbac";
// Console.WriteLine(PermutationDifferenceBetweenTwoStringsSolution.FindPermutationDifference(s, t));

// JEWELS AND STONES
// string jewels = "z", stones = "ZZ";
// Console.WriteLine(JewelsAndStonesSolution.NumJewelsInStones(jewels, stones));

// FIND WORDS CONTAINING CHARACTER
// string[] words = ["leet","code"];
// char x = 'e';
// var res = FindWordsContainingCharacterSolution.FindWordsContaining(words, x);
// foreach (var i in res)
// {
//     Console.WriteLine(i);
// }

// GOAL PARSER INTERPRETATION
// string command = "(al)G(al)()()G";
// Console.WriteLine(GoalParserInterpretationSolution.Interpret(command));

// MAXIMUM NUMBER OF WORDS FOUND IN SENTENCES
// string[] sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"];
// Console.WriteLine(MaximumNumberOfWordsInASentenceSolution.MostWordsFound(sentences));

// REVERSE PREFIX OF A WORD
// string word = "abcd";
// char ch = 'z';
// Console.WriteLine(ReversePrefixOfAWordSolution.ReversePrefix(word, ch));

// CHECK IF TWO STRING ARRAYS ARE EQUIVALENT
// string[] word1 = ["ab", "c"], word2 = ["a", "bc"];
// Console.WriteLine(CheckIfTwoStringArraysAreEquivalentSolution.ArrayStringsAreEqual(word1, word2));

// TRUNCATE STRINGS 
// string s = "chopper is not a tanuki";
// int k = 4;
// Console.WriteLine(TruncateStringSolution.TruncateSentence(s, k));

// SORT THE PEOPLE
// string[] names = ["Mary","John","Emma"];
// int[] heights = [180,165,170];
// string[] output = SortThePeopleSolution.SortPeople(names, heights);
// foreach (var s in output)
// {
//     Console.Write($"{s} ");
// }

// SHUFFLE STRING
// string s = "codeleet";
// int[] indices = [4,5,6,7,0,2,1,3];
// Console.WriteLine(ShuffleStringSolution.RestoreString(s, indices));

// DECODE THE MESSAGE 
// string key = "eljuxhpwnyrdgtqkviszcfmabo", message = "zwx hnfx lqantp mnoeius ycgk vcnjrdb";
// Console.WriteLine(DecodeTheMessageSolution.DecodeMessage(key, message));

// CELLS IN A RANGE ON AN EXCEL SHEET
// string s = "U7:X9";
// var result = ExcelSheetCellRangeSolution.CellsInRange(s);
// foreach (var r in result)
// {
//     Console.Write($"{r} ");
// }

// MAXIMUM NESTING DEPTH OF THE PARENTHESES
// string s = "(1)+((2))+(((3)))";
// Console.WriteLine(MaximumNestingDepthOfParenthesesSolution.MaxDepth(s));

// FIND FIRST PALINDROMIC STRING IN THE ARRAY
// string[] words = ["abc","car","ada","racecar","cool"];
// Console.WriteLine(FirstPalindromeStringSolution.FirstPalindrome(words));

// FAULTY KEYBOARD
string s = "string";
Console.WriteLine(FaultyKeyboardSolution.FinalString(s));