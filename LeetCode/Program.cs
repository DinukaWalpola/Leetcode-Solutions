// See https://aka.ms/new-console-template for more information

using LeetCode.Easy;

Console.WriteLine("Hello, World!");

char[] chars = { 'h', 'e', 'l', 'l', 'o' };

var x = ReverseStringSolution.ReverseString(chars);

foreach (var s in x)
{
    Console.WriteLine(s);
}