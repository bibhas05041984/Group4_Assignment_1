using System;
using System.Collections.Generic;
using System.Text;

namespace Group4_Assignment1
{
    class Solution5
    {
        //For Assingment-1, Question-5
        // Checking common inputs from two arrays - with this code. 
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            Array.Sort(nums1);
            Array.Sort(nums2);
            int len, x = 0, y = 0;
            List<int> result = new List<int>();

            while (x < l1 && y < l2)
            {
                if (nums1[x] > nums2[y])
                {
                    y = y + 1;

                }
                else if (nums1[x] < nums2[y])
                {
                    x = x + 1;

                }
                else
                {
                    result.Add(nums1[x]);
                    x = x + 1;
                    y = y + 1;

                }

            }

            return result.ToArray();
        }

        //User Enter Elements coding begins
        Console.Write("Input the number of elements to store in the array-1 : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

    int[] UserInputArray1 = new int[n];

    Console.Write("Input {0} number of elements in the array-1 :\n", n);
                for (i = 0; i<n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out UserInputArray1[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }

                Console.Write("Input the number of elements to store in the array-2 : ");
                userInput = Console.ReadLine();
                while (!int.TryParse(userInput, out n))
                {
                    Console.WriteLine("You entered {0}, This is not a number!", userInput);
                    Console.Write("Please provide a number :");
                    userInput = Console.ReadLine();
                }

                int[] UserInputArray2 = new int[n];

Console.Write("Input {0} number of elements in the array-2 :\n", n);
                for (i = 0; i<n; i++)
                {
                    Console.Write("Enter Number {0} : ", i);
                    string UserInput = Console.ReadLine();
                    while (!int.TryParse(UserInput, out UserInputArray2[i]))
                    {
                        Console.WriteLine("You entered {0}, This is not a number!", UserInput);
                        Console.Write("Enter Number {0} :", i);
                        UserInput = Console.ReadLine();
                    }
                }

                Console.Clear();
                Console.Write("\nThe List of Numbers in Array-1 Are : \n");

                for (i = 0; i<UserInputArray1.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray1[i]);
                }

             
                Console.Write("\nThe List of Numbers in Array-2 Are : \n");

                for (i = 0; i<UserInputArray2.Length; i++)
                {
                    Console.Write("{0}  ", UserInputArray2[i]);
                }


                int[] Output1 = new int[n];

Output1=Intersect1(UserInputArray1, UserInputArray2);


                if (Output1.Length>0)
                {

                    Console.Write("\nThe List of Common Numbers from User Provided Array's : \n");
                    for (i = 0; i<Output1.Length; i++)
                    {
                        Console.Write("{0}  ", Output1[i]);
                    }

                }
                else
                {
                    Console.WriteLine("\n\n There are No Common Numbers Available between Two Arrays !! \n\n");
                }