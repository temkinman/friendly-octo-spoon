/*
 Given the root of a binary tree, return the inorder traversal of its nodes' values.

Input: root = [1,null,2,3]
Output: [1,3,2]
Example 2:

Input: root = []
Output: []
Example 3:

Input: root = [1]
Output: [1]
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
 

Follow up: Recursive solution is trivial, could you do it iteratively?
 */

namespace LeetCodeTasks
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class InorderTreeTraversal
    {
        

        public static IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null)
                return new List<int>();

            if (root.left == null && root.right == null)
                return new List<int> { root.val };

            List<int> list = new List<int>();

            TraverseTreeInternal(root, list);

            return list;
        }

        private static void TraverseTreeInternal(TreeNode node, IList<int> list)
        {
            if (node == null) return;

            TraverseTreeInternal(node.left, list);
            list.Add(node.val);
            TraverseTreeInternal(node.right, list);
        }

        // Option 2: More complicated I think
        private void InorderTraverseIteratively(TreeNode root, IList<int> list)
        {
            var current = root;
            var stack = new Stack<TreeNode>();

            while (current != null || stack.Count != 0)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                }
                var top = stack.Pop();
                list.Add(top.val);
                current = top.right;
            }
        }
    }
}
