namespace Aero.Sort;

public static partial class Sort
{
    public static void TreeSort<T>(this T[] array) where T : IComparable<T>
    {

        if (array == null || array.Length <= 1)
        {
            return;
        }

        TreeNode root = null;
        foreach (T item in array)
        {
            root = Insert(root, item);
        }
        int index = 0;
        InOrderTraversal(root, array, ref index);
    }

    private static TreeNode Insert<T>(TreeNode node, T value) where T : IComparable<T>
    {
        if (node == null)
        {
            return new TreeNode(value);
        }
        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = Insert(node.Left, value);
        }
        else
        {
            node.Right = Insert(node.Right, value);
        }

        return node;
    }
    private static void InOrderTraversal<T>(TreeNode node, T[] array, ref int index) where T : IComparable<T>
    {
        if (node == null) return;

        InOrderTraversal(node.Left, array, ref index);
        
        array[index] = node.Value;
        index++;

        InOrderTraversal(node.Right, array, ref index);
    }
    private class TreeNode
    {
        public object Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(object value)
        {
            Value = value;
        }
    }
}
