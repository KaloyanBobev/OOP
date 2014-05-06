using System;

    class TestProgram
    {
        static void Main(string[] args)
        {
             BST<int> firdtTree = new BST<int>();
            firdtTree.AddElement(1);
            firdtTree.AddElement(2);
            firdtTree.AddElement(5);
            firdtTree.AddElement(7);
            firdtTree.AddElement(9);
            
 
            BST<int> secondTree = (BST<int>)firdtTree.Clone();
            
           
            Console.WriteLine("First Tree: {0}" ,firdtTree.ToString());
            Console.WriteLine("Second Tree: {0} ",secondTree.ToString());
            Console.WriteLine("First Tree equals Second Tree: {0}",firdtTree.Equals(secondTree));
            
            Console.Write("Traverse with foreach: ");
            foreach (TreeNode<int> item in firdtTree)
                Console.Write(item.Value + " ");
 
            Console.WriteLine();

            Console.WriteLine("First Tree hash: {0}", firdtTree.GetHashCode());
            Console.WriteLine("Second Tree hash: {0}", secondTree.GetHashCode());
        }
    }
