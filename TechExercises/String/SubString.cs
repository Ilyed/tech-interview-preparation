namespace TechExercises.String;

using System;

public class SubString
{
    //3. Longest Substring Without Repeating Characters
    public int LengthOfLongestSubstring(string s)
    {
        int aPointer = 0;
        int bPointer = 0;
        int maxLength = 0;
        HashSet<char> subStringSet = new HashSet<char>();
        if (String.IsNullOrEmpty(s))
        {
            return maxLength;
        }

        while (bPointer < s.Length)
        {
            char currentChar = s[bPointer];
            if (!subStringSet.Contains(currentChar))
            {
                subStringSet.Add(currentChar);
                bPointer++;
                maxLength = Math.Max(subStringSet.Count, maxLength);
            }
            else
            {
                currentChar = s[aPointer];
                subStringSet.Remove(currentChar);
                aPointer++;
            }    
        }

        return maxLength;
    }
}