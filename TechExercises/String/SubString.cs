namespace TechExercises.String;

using System;

public class SubString
{
    //3. Longest Substring Without Repeating Characters
    public int LengthOfLongestSubstring(string s)
    {
        int length = s.Length - 1;
        int maxLength = 0;
        int temporaryMax = 0;
        HashSet<char> subStringSet = new HashSet<char>();
        if (String.IsNullOrEmpty(s))
        {
            return maxLength;
        }

        for (int i = 0; i <= length; i++)
        {
            for (int j = i; j <= length; j++)
            {
                char currentChar = s[j];
                if (!subStringSet.Contains(currentChar))
                {
                    subStringSet.Add(currentChar);
                    temporaryMax++;
                }
                else
                {
                    maxLength = Math.Max(temporaryMax, maxLength);
                    j--;
                    temporaryMax = 0;
                    subStringSet = new HashSet<char>();
                }
            }

            //We check again in case the last character made the substring bigger
            maxLength = Math.Max(temporaryMax, maxLength);
        }

        return maxLength;
    }
}