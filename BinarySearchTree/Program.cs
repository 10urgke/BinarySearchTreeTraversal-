using BinarySearchTree;

class Program

{ 
    static void Main(string[] args)
    {
        /*
         *                      25
         *             14----------------40
         *        7----------23       34------48
         *     5------10   17--24      36
         *          7         23
         */
        Tree BST = new Tree();
        BST.Insert(25);
        BST.Insert(14);
        BST.Insert(23);                   
        BST.Insert(40);
        BST.Insert(24);
        BST.Insert(23);
        BST.Insert(48);
        BST.Insert(7);
        BST.Insert(5);
        BST.Insert(34);
        BST.Insert(10);
        BST.Insert(7);
        BST.Insert(17);
        BST.Insert(36);
        Console.WriteLine("Inorder Traversal : ");
        BST.Inorder(BST.ReturnRoot());
        Console.WriteLine(" ");
        Console.WriteLine();
        Console.WriteLine("Preorder Traversal : ");
        BST.Preorder(BST.ReturnRoot());
        Console.WriteLine(" ");
        Console.WriteLine();
        Console.WriteLine("Postorder Traversal : ");
        BST.Postorder(BST.ReturnRoot());
        Console.WriteLine(" ");
        Console.ReadLine();
    }
    
}