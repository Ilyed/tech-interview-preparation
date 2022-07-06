namespace TechExercises.BinaryTree;

/// <summary>
/// Designed for search functions related to BinaryTree
/// </summary>
public class TreeSearch
{
    //Leetcode 235. Lowest Common Ancestor of a Binary Search Tree
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (p.val < root.val && q.val < root.val)
        {
            return LowestCommonAncestor(root.left, p, q);
        }

        if (p.val > root.val && q.val > root.val)
        {
            return LowestCommonAncestor(root.right, p, q);
        }

        return root;
    }


    //Leetcode 104. Maximum Depth of Binary Tree
    public int MaxDepth(TreeNode root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);
        return Math.Max(leftDepth, rightDepth) + 1;
    }

    //543. Diameter of Binary Tree
    public int DiameterOfBinaryTree(TreeNode root)
    {
        int current = int.MinValue;
        DiameterCalculater(root, ref current);
        return current;
    }

    public int DiameterCalculater(TreeNode root, ref int current)
    {
        if (root == null)
        {
            return 0;
        }

        int left = DiameterCalculater(root.left, ref current);
        int right = DiameterCalculater(root.right, ref current);
        current = Math.Max(current, left + right);

        return Math.Max(left, right) + 1;
    }
}