using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public struct BST<T> : ICloneable, IEnumerable<TreeNode<T>>
        where T : IComparable<T>
    {
        private TreeNode<T> rootTree;
 
        public TreeNode<T> Find(T value)
        {
            return Find(this.rootTree, value);
        }
 
        private TreeNode<T> Find(TreeNode<T> node, T value)
        {
            int compareTo = value.CompareTo(node.Value);
 
            if (compareTo == 0)
            {
                return node;
            }
 
            if (compareTo < 0)
            {
                if (node.LeftChild != null) return Find(node.LeftChild, value);

                else 
                {
                    return null;
                }
            }
            else
            {
                if (node.RightChild != null) return Find(node.RightChild, value);

                else
                { 
                    return null;
                }
            }
        }
 
        public void AddElement(T value)
        {
            this.rootTree = AddElement(value, null, rootTree);
        }
 
        private TreeNode<T> AddElement(T value, TreeNode<T> parentNode, TreeNode<T> node)
        {
            if (node == null)
            {
                node = new TreeNode<T>(value);
                node.Parent = parentNode;
            }
            else
            {
                int compareTo = value.CompareTo(node.Value);
                if (compareTo < 0)
                {
                    node.LeftChild = AddElement(value, node, node.LeftChild);
                }
                else if (compareTo > 0)
                {
                    node.RightChild = AddElement(value, node, node.RightChild);
                }
            }
            return node;
        }
 
        public void Remove(T value)
        {
            TreeNode<T> nodeToDelete = Find(value);
            if (nodeToDelete == null)
            {
                return;
            }
 
            Remove(nodeToDelete);
        }
 
        private void Remove(TreeNode<T> node)
        {
            if (node.LeftChild != null && node.RightChild != null)
            {
                TreeNode<T> replacement = node.RightChild;
                while (replacement.LeftChild != null)
                {
                    replacement = replacement.LeftChild;
                }
                node.Value = replacement.Value;
                node = replacement;
            }
 
            TreeNode<T> theChild = node.LeftChild != null ?
                    node.LeftChild : node.RightChild;
 
            if (theChild != null)
            {
                theChild.Parent = node.Parent;
 
                if (node.Parent == null)
                {
                    rootTree = theChild;
                }
                else
                {
                    if (node.Parent.LeftChild == node)
                    {
                        node.Parent.LeftChild = theChild;
                    }
                    else
                    {
                        node.Parent.RightChild = theChild;
                    }
                }
            }
            else
            {
                if (node.Parent == null)
                {
                    rootTree = null;
                }
                else
                {
                    if (node.Parent.LeftChild == node)
                    {
                        node.Parent.LeftChild = null;
                    }
                    else
                    {
                        node.Parent.RightChild = null;
                    }
                }
            }
        }
 
        private void AddNodes(ref StringBuilder builder, TreeNode<T> root)
        {
            if (root == null)
            {
                return;
            }
 
            AddNodes(ref builder, root.LeftChild);
            builder.Append(root.Value);
            builder.Append(" ");
            AddNodes(ref builder, root.RightChild);
        }
 
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            AddNodes(ref builder, this.rootTree);
            return builder.ToString();
        }
 
        public override int GetHashCode()
        {
            int hashCode = 7;
 
            foreach (TreeNode<T> node in this)
            {
                hashCode ^= node.Value.GetHashCode();
            }
            return hashCode;
        }
 
        private void CheckEqualNodes(TreeNode<T> node1, TreeNode<T> node2, ref bool equal)
        {
            if (node1 == null && node2 == null) return; // must not compare null nodes
 
            if ((node1 != null && node2 == null) || (node1 == null && node2 != null) || node1.CompareTo(node2) != 0)
            {
               
                equal = false;
                return;
            }
 
            CheckEqualNodes(node1.LeftChild, node2.LeftChild, ref equal);
            CheckEqualNodes(node1.RightChild, node2.RightChild, ref equal);
        }
 
        public override bool Equals(object param)
        {
            bool equal = true;
            CheckEqualNodes(this.rootTree, ((BST<T>)param).rootTree, ref equal);
            return equal;
        }
 
        public static bool operator ==(BST<T> first, BST<T> second)
        {
            return Equals(first,second);
        }
 
        public static bool operator !=(BST<T> first, BST<T> second)
        {
            return !Equals(first,second);
        }
 
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
 
        public IEnumerator<TreeNode<T>> GetEnumerator()
        {
            List<TreeNode<T>> nodes = new List<TreeNode<T>>();
            GetNextNode(rootTree, ref nodes);
 
            foreach (TreeNode<T> node in nodes)
                yield return node;
        }
 
        public void GetNextNode(TreeNode<T> node, ref List<TreeNode<T>> nodes)
        {
            if (node == null) return;
 
            GetNextNode(node.LeftChild, ref nodes);
            nodes.Add(node);
            GetNextNode(node.RightChild, ref nodes);
        }
 
        public object Clone()
        {
            BST<T> clone = new BST<T>();
            CopyNode(this.rootTree, ref clone);
            return clone;
        }
 
        private void CopyNode(TreeNode<T> root, ref BST<T> tree)
        {
            if (root == null) return;
 
            tree.AddElement(root.Value);
            CopyNode(root.LeftChild, ref tree);
            CopyNode(root.RightChild, ref tree);
        }
    }
