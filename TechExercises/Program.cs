// See https://aka.ms/new-console-template for more information

using TechExercises.String;

Console.WriteLine("Hello, World!");
SubString subStringTest = new SubString();
string stringToTest = "dvdf";
int subStringLength = subStringTest.LengthOfLongestSubstring(stringToTest);
Console.WriteLine($"SubString : {stringToTest} has a maximum subStringLength of: {subStringLength}");