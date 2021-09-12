using System;
using System.Collections.Generic;

public class TreeNode<T>
{
    /// <summary>
    /// 上级结点
    /// </summary>
    public TreeNode<T> Parent { get; set; }

    /// <summary>
    /// 下级结点
    /// </summary>
    public IEnumerable<TreeNode<T>> Children { get; set; }

    /// <summary>
    /// 结点内容
    /// </summary>
    public T Content { get; set; }

    /// <summary>
    /// 判断是不是树根结点
    /// </summary>
    /// <returns>是，返回True;否，返回False</returns>
    public bool IsRootNode() => this.Parent is null;

    /// <summary>
    /// 判断是不是叶结点
    /// </summary>
    /// <returns>是，返回True;否，返回False</returns>
    public bool IsLeafNode() => this.Children is null;
}

public class MenuTree<T>
{
    /// <summary>
    /// 结点ID
    /// </summary>
    /// <value></value>
    public int Id { get; set; }
    /// <summary>
    /// 父节点ID
    /// </summary>
    public int ParentId { get; set; }
    /// <summary>
    /// 结点内容
    /// </summary>
    public T Content { get; set; }
}