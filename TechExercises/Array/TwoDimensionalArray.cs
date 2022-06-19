namespace TechExercises.Array
{
    public class TwoDimensionalArray
    {
        //Leetcode 733. Flood Fill
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
            if (image[sr][sc] == newColor)
                return image;
        
            int originalColor = image[sr][sc];
        
            Stack<(int i, int j)> changeStack = new Stack<(int i, int j)>();
            changeStack.Push((sr, sc));
        
            while(changeStack.Count > 0) {
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
    }
}