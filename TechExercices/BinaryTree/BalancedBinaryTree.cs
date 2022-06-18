namespace TechExercices.BinaryTree
{
    public class BalancedBinaryTree
    {
        private int Height(TreeNode node)
        {
            if (node is null)
            {
                return -1;
            }

            int height = 1 + Math.Max(Height(node.left), Height(node.right));
            return height;
        }

        //Leetcode 110.
        public bool IsBalanced(TreeNode root)
        {
            if (root is null)
            {
                return true;
            }

            return Math.Abs((Height(root.left) - Height(root.right))) < 2
                   && IsBalanced(root.left)
                   && IsBalanced(root.right);
        }
    }
}