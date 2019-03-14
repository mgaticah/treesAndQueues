using System;
public class GenericBsTreeNode<T>
{
    public T value;
    public GenericBsTreeNode<T> left;
    public GenericBsTreeNode<T> right;
    public GenericBsTreeNode(T value)
    {
        this.value = value;
        left = null;
        right = null;
    }
 
}
