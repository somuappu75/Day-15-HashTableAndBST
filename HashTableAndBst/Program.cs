﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace HashTableAndBst
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------  ## BInary Search Tree Operations ## --------------");
            Console.WriteLine("------------UC-1- added Binary Search Tree-------- ");
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("----Enter Your Option-----\n1.Add Binary Tree \n2.Insert More Elements");
                int num = Convert.ToInt32(Console.ReadLine());
                BST<int> binarySearchTree = new BST<int>(56);
                switch (num)
                {
                    case 1:
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        binarySearchTree.Display();
                        break;

                    case 2:
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        binarySearchTree.Insert(22);
                        binarySearchTree.Insert(40);
                        binarySearchTree.Insert(11);
                        binarySearchTree.Insert(3);
                        binarySearchTree.Insert(16);
                        binarySearchTree.Insert(60);
                        binarySearchTree.Insert(95);
                        binarySearchTree.Insert(65);
                        binarySearchTree.Insert(63);
                        binarySearchTree.Insert(67);
                        binarySearchTree.Display();
                        binarySearchTree.GetSize();
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
