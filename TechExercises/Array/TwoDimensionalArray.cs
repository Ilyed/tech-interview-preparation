using System.Security.Cryptography;

namespace TechExercises.Array
{
    public class TwoDimensionalArray
    {
        //Leetcode 733. Flood Fill
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
        {
            if (image[sr][sc] == newColor)
                return image;

            int originalColor = image[sr][sc];

            Stack<(int i, int j)> changeStack = new Stack<(int i, int j)>();
            changeStack.Push((sr, sc));

            while (changeStack.Count > 0)
            {
                var (i, j) = changeStack.Pop();

                if (i < 0 || i > image.Length - 1 ||
                    j < 0 || j > image[0].Length - 1)
                    continue;

                if (image[i][j] != originalColor || image[i][j] == newColor)
                    continue;

                image[i][j] = newColor;

                changeStack.Push((i - 1, j)); // top
                changeStack.Push((i + 1, j)); // bottom
                changeStack.Push((i, j + 1)); // right
                changeStack.Push((i, j - 1)); // left
            }

            return image;
        }

        //57. Insert Interval
        public int[][] Insert(int[][] intervals, int[] newInterval)
        {
            List<int[]> res = new List<int[]>();
            HashSet<int> valuesOfInterval = new HashSet<int>();
            foreach (int[] currentInterval in intervals)
            {
                for (int i = 0; i < currentInterval.Length; i++)
                {
                    if (!valuesOfInterval.Contains(i))
                    {
                        valuesOfInterval.Add(currentInterval[i]);
                    }
                }
            }

            for (int i = 0; i < newInterval.Length; i++)
            {
                if (!valuesOfInterval.Contains(i))
                {
                    valuesOfInterval.Add(newInterval[i]);
                }
            }
            int j = 0;
            int[] intervalToAdd = new int[valuesOfInterval.Count];
            int currentIndex = 0;
            while (j < valuesOfInterval.Count)
            {
                foreach (int currentValue in valuesOfInterval)
                {
                    if (intervalToAdd.Length == 0)
                    {
                        intervalToAdd[currentIndex] = currentValue;
                        currentIndex++;
                    }
                    else if (currentValue == intervalToAdd[currentIndex - 1] + 1)
                    {
                        intervalToAdd[currentIndex] = currentValue;
                        currentIndex++;
                    }
                    else
                    {
                        res.Add(intervalToAdd);
                        intervalToAdd = new int[valuesOfInterval.Count];
                        currentIndex = 0;
                    }
                }
            }

            if (intervalToAdd.Length > 0)
            {
                res.Add(intervalToAdd);
            }
            
            return res.ToArray();
        }
    }
}