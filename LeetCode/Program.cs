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
var s = "RLLLLRRRLR";
Console.WriteLine(SplitStringInABalanceStringSolution.BalancedStringSplit(s));