using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class TreePractice
    {
        public NodePractice root;

        int countOfNodes = 0;

        public int countNumberOfNodes = 0;

        public int countNumberOfLeaves = 0;

        public int countNumberOfNonLeaves = 0;

        public TreePractice()
        {

        }

        public void AddNode_BinaryTree(int data, NodePractice rootNew)
        {
            NodePractice node = GetNewNode(data);

            NodePractice temp = rootNew;

            if (temp == null)
            {
                root = node;
            }
            else
            {
                if (countOfNodes % 2 != 0)
                {
                    while (temp.left != null)
                    {
                        temp = temp.left;
                    }

                    temp.left = node;
                }
                else
                {
                    while (temp.right != null)
                    {
                        temp = temp.right;
                    }

                    temp.right = node;
                }

            }

            countOfNodes++;
        }

        private NodePractice GetNewNode(int data)
        {
            NodePractice node = new NodePractice();
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }

        public int CountNumberOfNodes_Meth2(NodePractice temp)
        {
            if (temp != null)
            {
                return (1 + CountNumberOfNodes_Meth2(temp.left) + CountNumberOfNodes_Meth2(temp.right));
            }
            else
            {
                return 0;
            }
        }

        public int CountNumberOfNodes(NodePractice temp)
        {
            if (temp != null)
            {
                CountNumberOfNodes(temp.left);
                countNumberOfNodes++;
                CountNumberOfNodes(temp.right);
            }

            return countNumberOfNodes;
        }

        public string CountNumberOfLeaves(NodePractice temp)
        {
            if (temp != null)
            {
                if (temp.left == null && temp.right == null)
                {
                    countNumberOfLeaves++;
                }
                else
                {
                    CountNumberOfLeaves(temp.left);
                    countNumberOfNonLeaves++;
                    CountNumberOfLeaves(temp.right);
                }
            }

            return "No of Leaves" + countNumberOfLeaves + "Non Leaves" + countNumberOfNonLeaves;
        }

        public int CountNumberofLeaves_Meth2(NodePractice temp)
        {
            if (temp != null)
            {
                if (temp.left == null && temp.right == null)
                {
                    return 1;
                }
                else
                {
                    return (CountNumberofLeaves_Meth2(temp.left) + CountNumberofLeaves_Meth2(temp.right));
                }
            }
            else
            {
                return 0;
            }
        }

        public int CountNumberofNonLeaves_Meth2(NodePractice temp)
        {
            if (temp != null)
            {
                if (temp.left == null && temp.right == null)
                {
                    return 0;
                }
                else
                {
                    return (1 + CountNumberofNonLeaves_Meth2(temp.left) + CountNumberofNonLeaves_Meth2(temp.right));
                }
            }
            else
            {
                return 0;
            }
        }

        public bool isCompleteBinaryTree(NodePractice node)
        {
            if(node.left == null && node.right == null)
            {
                return true;
            }
           else if()
            {

            }
           else
            {

            }
        }

    }

    class NodePractice
    {
        public int data;
        public NodePractice left;
        public NodePractice right;
    }

    class TreeTraversals
    {
        public void Inorder(NodePractice root)
        {
            if (root != null)
            {
                Inorder(root.left);
                Console.WriteLine(root.data);
                Inorder(root.right);
            }

        }

        public void PreOrder(NodePractice root)
        {
            if (root != null)
            {
                Console.WriteLine(root.data);
                PreOrder(root.left);
                PreOrder(root.right);
            }

        }

        public void PostOrder(NodePractice root)
        {
            if (root != null)
            {
                PostOrder(root.left);
                PostOrder(root.right);
                Console.WriteLine(root.data);
            }

        }
    }

    class BinarySearchTree
    {
        public NodePractice root;

        public void AddNode(int data, NodePractice node)
        {
            NodePractice newNode = GetNewNode(data);
            if(root == null)
            {
                root = newNode;
            }
            else
            {
                NodePractice temp = node;
                if (temp != null)
                {
                    if (newNode.data >= temp.data)
                    {
                        if(temp.right != null)
                        {
                            AddNode(newNode.data, temp.right);
                        }
                        else
                        {
                            temp.right = newNode;
                        }
                    }
                    else
                    {
                        if(temp.left != null)
                        {
                            AddNode(newNode.data, temp.left);
                        }
                        else
                        {
                            temp.left = newNode;
                        }
                    }
                }
            }          
        }

        public int FindMax(NodePractice node)
        {
            while (node.right != null) { node = node.right; }
            return node.data;
        }

        public int FindMin(NodePractice node)
        {
            while (node.left != null) { node = node.left; }
            return node.data;
        }

        public NodePractice FindInOrderSuccessor(NodePractice node)
        {
            while (node.left != null) { node = node.left; }
            return node;
        }

        public NodePractice FindInOrderPredecessor(NodePractice node)
        {
            while (node.right != null) { node = node.right; }
            return node;
        }

        public NodePractice DeleteNode(int data, NodePractice node)
        {
            if (data > node.data)
            {
                node.right = DeleteNode(data, node.right);
            }
            else if (data < node.data)
            {
                node.left = DeleteNode(data, node.left);
            }
            else
            {
                if(node.left == null && node.right == null)
                {
                    NodePractice temp = node;
                    node = null;
                }
                else if(node.left == null)
                {
                    return node.right;
                }
                else if(node.right == null)
                {
                    return node.left;
                }
                else
                {
                    NodePractice temp = FindInOrderSuccessor(node.right);
                    node.data = temp.data;
                    node.right = DeleteNode(temp.data, node.right);
                }
            }
            return node;
        }

        private NodePractice GetNewNode(int data)
        {
            NodePractice node = new NodePractice();
            node.data = data;
            node.left = null;
            node.right = null;
            return node;
        }

    }

}
