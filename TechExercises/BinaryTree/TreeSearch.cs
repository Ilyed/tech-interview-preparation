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
            LowestCommonAncestor(root.left, p, q);
        }
        if (p.val > root.val && q.val > root.val)
        {
            LowestCommonAncestor(root.right, p, q);
        }
        return root;
    }
}