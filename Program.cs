using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            /********************************************************** IMPLEMENT QUEUE WITH TWO STACKS ***********************************************************************/
            ImplementQueueWithTwoStacks iqTS = new ImplementQueueWithTwoStacks();
            iqTS.Insert(10);
            iqTS.Insert(20);
            iqTS.Insert(30);
            iqTS.Insert(40);

            Console.WriteLine(iqTS.Delete()); // 10
            Console.WriteLine(iqTS.Delete()); // 20
            Console.WriteLine(iqTS.Delete()); // 30
            /********************************************************** IMPLEMENT QUEUE WITH TWO STACKS ***********************************************************************/

           // Console.WriteLine(new InfixToPostFixConversion(7).ConvertToPostfix("a+b*(c-d)"));
            Console.WriteLine(new InfixToPostFixConversion("a+b*(c^d-e)^(f+g*h)-i".Length).ConvertToPostfix("a+b*(c^d-e)^(f+g*h)-i")); // abcd^e-fgh*+^*+i-

            /**************************************************************** Trying to implement complete binary tree   *****************************************************************/
            TreePractice tr = new TreePractice();
            tr.AddNode_BinaryTree(10, tr.root);
            tr.AddNode_BinaryTree(20, tr.root);
            tr.AddNode_BinaryTree(30, tr.root);
            tr.AddNode_BinaryTree(40, tr.root);
            tr.AddNode_BinaryTree(50, tr.root);
            tr.AddNode_BinaryTree(60, tr.root);
            /**************************************************************** Trying to implement complete binary tree   *****************************************************************/

            TreeTraversals trTraversal = new TreeTraversals();
            trTraversal.Inorder(tr.root);

            Console.WriteLine(new TreePractice().CountNumberOfNodes(tr.root));

            Console.WriteLine(new TreePractice().CountNumberOfNodes_Meth2(tr.root));

            Console.WriteLine(new TreePractice().CountNumberOfLeaves(tr.root));

            Console.WriteLine("No of leaves:" + new TreePractice().CountNumberofLeaves_Meth2(tr.root));

            Console.WriteLine("No of non-leaves:" + new TreePractice().CountNumberofNonLeaves_Meth2(tr.root));

            /************************************************* Binary Search Tree ************************************/
            BinarySearchTree bTree = new BinarySearchTree();

            /* Add elements in Binary Search Tree */
            bTree.AddNode(10, bTree.root);
            bTree.AddNode(20, bTree.root);
            bTree.AddNode(30, bTree.root);
            bTree.AddNode(40, bTree.root);
            bTree.AddNode(25, bTree.root);
            bTree.AddNode(15, bTree.root);
            bTree.AddNode(5, bTree.root);
            bTree.AddNode(8, bTree.root);
            bTree.AddNode(9, bTree.root);

            Console.WriteLine("Maximum Element: " + bTree.FindMax(bTree.root));

            Console.WriteLine("Minimum Element: " + bTree.FindMin(bTree.root));

            bTree.DeleteNode(25, bTree.root);
            NodePractice afterDelete = bTree.DeleteNode(40, bTree.root);
            // bTree.DeleteNode(10, bTree.root);

            Console.WriteLine(afterDelete.data);

            trTraversal.Inorder(bTree.root); // should print all elements in a sorted order

            Console.ReadLine();
        }

    }
}
