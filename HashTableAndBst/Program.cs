using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableAndBst
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------  ## BInary Search Tree Operations ## --------------");
            Console.WriteLine("------------UC-1- added Binary Search Tree--------\n ");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("----Enter Your Option-----\n1.Add Binary Tree \n");
                int num = Convert.ToInt32(Console.ReadLine());
                BST<int> binarySearchTree = new BST<int>(56);
                switch (num)
                {
                    case 1:
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        binarySearchTree.Display();
                        break;





                    default:
                        Console.WriteLine("Enter Valid Choice!");
                        break;
                }
                Console.WriteLine("\nDo you want to continue?(Y/N)");
                flag = Console.ReadLine();

            }
            Console.ReadKey();

        }
    }
}
