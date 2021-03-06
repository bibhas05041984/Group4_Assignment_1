﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Group4_Assignment_1
{
    class Program
    {

        // Dictonary object creation
        static Dictionary<char, int> dict = new Dictionary<char, int>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Professor! Please review Assignment 1 Solution from Group 4 - Avie, Bibhas, Kirti and Laura.");

            /*Question 1:   
                Professor Agrawal receives an array of integer points sorted in ascending order, the task is to find the initial
                and final index of a given target point’s value.
                If the target point value is not found in the array of integers, return [-1, -1]
                The professor had to leave for a conference at short notice and asked you to complete the task for him.He instructed you to
                limit the time complexity to O(n).
                Example 1:
                Input:  marks = [5, 6, 6, 9, 9, 12]  target = 9
                Output: [3,4]
                Example 2: 
                Input: marks = [5, 6, 6, 9, 9, 12] target = 10
                Output:[-1,-1]

                Note: The algorithm’s runtime complexity must be O(n).*/

            //Solution 1 - Starts Here - Work Assigned to -  Everyone

            Console.WriteLine("---------- Solution 1 Begins -----------");

            //int[] marks = { 5, 6, 6, 9, 12 };
            //int target = 6;
            int[] rangeResult;

            bool arrayCheck1 = true;
            List<int> marks = new List<int>();
            int element_of_array1;
            int arraycount1 = 0;

            while (arrayCheck1)
            {
                Console.WriteLine("Enter elements of the array in sequence. When finished, enter A.");

                string temp2 = Console.ReadLine();
                if (temp2 == "A")
                {
                    break;
                }
                else
                {
                    try
                    {
                        element_of_array1 = Convert.ToInt32(temp2);
                        marks.Add(element_of_array1);
                        arraycount1++;
                        arrayCheck1 = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine("Here is the array you entered.");
            for (int x = 0; x < arraycount1; x++)
            {
                Console.WriteLine(marks[x]);
                //Console.ReadKey();
            }
            Console.WriteLine("Now Enter the target variable. Must be an Integer.");
            try {
                Int32 target = Convert.ToInt32(Console.ReadLine());
                rangeResult = targetRange(marks, target);


            

            Console.WriteLine("---Question 1---");
            Console.WriteLine("The array includes: " + "[{0}]", string.Join(", ", marks));
            Console.WriteLine("The target integer is: " + target);
            Console.WriteLine("The initial and final Indicies are: " + "[{0}]", string.Join(", ", rangeResult));
            Console.WriteLine(" ");
            Console.WriteLine("---------- Solution 1 Ends -----------");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Solution 1 - Ends Here  

            /*Question 2: 
               Rocky is not aware of the inbuilt functions to split and reverse a string. He is given a string and he needs to
               reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
               He is not allowed to use any predefined split and reverse function. He is requesting you to complete the method for him.

               Example: 
               Input : “University of South Florida”
               Output: “stisverinU fo htuoS adirolF”
               Note: Time complexity should be O(n) where n is the length of string
               Hint: Create your own split and reverse function.
               Public static string StringReverse(string s). */

            //Solution 2 - Starts Here - Work Assigned to - Everyone

            Console.WriteLine("---------- Solution 2 Begins -----------");


            Console.WriteLine("Enter the String you want to reverse.");
            //string inputrevString = "University of Michigan";
            String inputrevString = Console.ReadLine();
            string reversedString;

            reversedString = StringReverse(inputrevString);

            Console.WriteLine("---Question 2---");
            Console.WriteLine("The input string is: " + inputrevString);
            Console.WriteLine("The split and reversed string is: " + reversedString);
            Console.WriteLine(" ");
            Console.WriteLine("---------- Solution 2 Ends -----------");

            //Solution 2 - Ends Here 

            /*Question 3: 
                Professor Stablein is given a sorted integer array. He needs to make the array elements distinct by increasing each
                value as needed, while minimizing the array sum. Professor Stablein thought this was an interesting exercise that the
                students might enjoy completing. Your job is to complete the method to print the minimum possible sum as output.
                Example : 
                Input : arr[] = {2,2,3,5,6};			Output: 20
                Explanation: Array is transformed to {2,3,4,5,6}. Sum becomes 2+3+4+5+6=20
                Input arr[]= {40,40};				Output: 81
                Explanation: Array is transformed to {40,41}. Sum becomes 81
                Input: arr[] = {4,5,6,9};			Output : 24
                Explanation: As the array is sorted and has distinct elements. So result is sum of each elements in the array.

                Time Complexity: O(n)
                public static int minSum(int[] arr) */

            //Solution 3 - Starts Here - Kirti's Solution to Problem 3

            Console.WriteLine("---------- Solution 3 Begins -----------");

            int i_var, n_len;
            int[] arr = new int[100];

            Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
            Console.Write("------------------------------------------------------------------------\n");
            try
            {
                Console.Write("Input the number of elements to store in the array :");
           
                n_len = Convert.ToInt32(Console.ReadLine());
            

                Console.Write("Input {0} number of elements in the array :\n", n_len);
                for (i_var = 0; i_var < n_len; i_var++)
                {
                    Console.Write("element - {0} : ", i_var);
                    arr[i_var] = Convert.ToInt32(Console.ReadLine());
                }

            
                Console.Write("\nThe values store into the array are : \n");
                for (i_var = 0; i_var < n_len; i_var++)
                {
                    Console.Write("{0}  ", arr[i_var]);
                }

                Console.Write("\nThe sum of values after transforming the Array values is : \n");
                Console.WriteLine(minSum(arr, n_len));
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("---------- Solution 3 Ends -----------");

            //Solution 3 - Ends Here

            /*Question 4: 
                You are given a string and your task is to sort the given string in decreasing order of frequency of occurrence of each character.
                Example 1: 
                Input : “Dell”					Output: “llDe”
                Explanation:  “lleD” is also accepted. Frequency of l is 2 and other 2 characters is 1.
                Example 2:
                Input : eebhhh					Output: hhheeb 
                Example 3: 
                Input : yYkk					Output: kkYy
                Explanation: “Yykk” is not a valid answer as Y and y are treated as two different characters.

                Note: The solution must use a dictionary as the primary data structure.
                public static string FreqSort(string s) */

            //Solution 4 - Starts Here - Kirti's Solution to Problem 4

            Console.WriteLine("---------- Solution 4 Begins -----------");

            // Getting User input           
            Console.WriteLine("Enter String Value:");
            try
            {
                String str = FreqSort(Console.ReadLine());
                Console.WriteLine(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

            Console.WriteLine("---------- Solution 4 Ends -----------");

            //Solution 4 - Ends Here

            /*Question 5: 
                Rocky the Bull is new to programming and is having trouble understating the importance of time complexity.
                Professor Agrawal assigned you the job of explaining time complexity to Rocky with the example below.
                Given two arrays, write a function to compute their intersection.

                Example 1:
                Input: nums1 = [2,5,5,2], nums2 = [5,5]
                Output: [5,5]

                Example 2:
                Input: nums1 = [3,6,2], nums2 = [6,3,6,7,3]
                Output: [3,6]

                Note:
                Each element in the result should appear as many times as it shows in both arrays.
                The result can be in any order.
                Submit 2 Solutions where time complexity of the methods is be less than O(n^2). 

                Hint1: You can sort the both arrays and then compute the intersection, in this way you will achieve a
                time complexity of O(n log n). 
                Hint2: If you make use of a dictionary, you need not sort the arrays to compute the intersection. The time complexity in
                this case will be O(n).

                public static int[] Intersect1(int[] nums1, int[] nums2)
                public static int[] Intersect1(int[] nums1, int[] nums2)
                 */

            //Solution 5 - Starts Here - Work Assigned to - AvieM

            Console.WriteLine("---------- Solution 5 Begins -----------");

            string userInput;
            int i, n;

            Dictionary<int, string> UserData = new Dictionary<int, string>();

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
            for (i = 0; i < n; i++)
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
            for (i = 0; i < n; i++)
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

            for (i = 0; i < UserInputArray1.Length; i++)
            {
                Console.Write("{0}  ", UserInputArray1[i]);
            }


            Console.Write("\nThe List of Numbers in Array-2 Are : \n");

            for (i = 0; i < UserInputArray2.Length; i++)
            {
                Console.Write("{0}  ", UserInputArray2[i]);
            }


            int[] Output1 = new int[n];

            Output1 = Intersect1(UserInputArray1, UserInputArray2);


            if (Output1.Length > 0)
            {

                Console.Write("\nThe List of Common Numbers from User Provided Array's : \n");
                for (i = 0; i < Output1.Length; i++)
                {
                    Console.Write("{0}  ", Output1[i]);
                }

            }
            else
            {
                Console.WriteLine("\n\n There are No Common Numbers Available between Two Arrays !! \n\n");
            }
            Console.WriteLine("---------- Solution 5 Ends -----------");

            //Solution 5 - Ends Here


            /*Question 6: 
                You are given an array of characters and an integer k, and are required to find out whether there are two distinct
                indices i and j in the array such that arr[i]=arr[j] and the absolute difference between i and j is at most k.
                Example 1: 
                Input: arr=[a,g,h,a], k=3
                Output= true
                Explanation= arr[0] and arr[3] contains “a”; hence the absolute difference between 0 and 3 is 3 which is equal to 3
                therefore output is true.
                Example 2: arr=[k,y,k,k], k=1
                Output= true
                Example 3: 
                Input: arr=[a,b,c,a,b,c], k=2
                Output: false
                Explanation= arr[0]=arr[3] but absolute difference is not at most 2 
                           arr[1]=arr[4] but absolute difference is not at most 2
                           arr[2]=arr[5] but absolute difference is not at most 2
                           There fore output is false.

                Note: The algorithm’s runtime complexity must be in the order of O(n).
                Hint : You can make use of a dictionary to obtain the required time complexity.

                public bool ContainsDuplicate(char[] arr, int k) 
             */

            //Solution 6 - Starts Here - Work Assigned to - Bibhas

            Console.WriteLine("---------- Solution 6 Begins -----------");

            //Solution 6 - Read Inputs from user

            bool arrayCheck = true;
            List<char> charlist = new List<char>();
            char element_of_array;
            int arraycount = 0;

            while (arrayCheck)
            {
                Console.WriteLine("Enter elements of the array in sequence. When finished, enter -1.");

                string temp = Console.ReadLine();
                if (temp == "-1")
                {
                    break;
                }
                else
                {
                    try
                    {
                        element_of_array = Convert.ToChar(temp);
                        charlist.Add(element_of_array);
                        arraycount++;
                        arrayCheck = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine("Here is the array you entered.");
            for (int x = 0; x < arraycount; x++)
            {
                Console.WriteLine(charlist[x]);
                //Console.ReadKey();
            }
            //Solution 6 - Call Method to return the expected result

            Console.WriteLine("Enter the value of k as required by the algorithm.");
            int k = 0;
            string temp1 = Console.ReadLine();
            try
            {

                k = Convert.ToInt32(temp1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Solution 6 - Write Output from the Method to the Console
            Boolean result = method_bibs(charlist, k);

            Console.WriteLine("Result of the method is:" + result);

            //Solution 6 - Define the Method here

            static Boolean method_bibs(List<char> mlist, int q)
            {
                int diff = 0;
                for (int x = 1; x < mlist.Count; x++)
                {
                    for (int y = 0; y < x; y++)
                    {
                        if (mlist[y] == mlist[x])
                            Console.WriteLine("mlist[y]=" + mlist[y] + " and mlist[x]=" + mlist[x]);
                        diff = (x - y);
                    }
                }

                Console.WriteLine("Value of K entered by User is:" + q + " and Value of K calculated by the method is:" + diff);
                if ((diff - q) > 0)
                    return (false);
                else
                    return (true);
            }

            Console.WriteLine("---------- Solution 6 Ends -----------");

            //Solution 6 - Ends Here 

        }

        private static int[] Intersect1(int[] interArray1, int[] interArray2, int[] result)
        {
            return result;
        }

        private static string StringReverse(string inputrevString)
        {
            string result; //string to hold answer
            List<char> charList = new List<char>(inputrevString); //convert string to list of characters
            List<char> reversedList = new List<char>(); //create a list to hold final reversed list of characters
            List<char> word = new List<char>(); //create a list to hold individual words
            List<char> reversedWord = new List<char>(); //create a list to hold individual reversed words
            charList.Add(' '); //add a space on the end of the charList to support loop if/else logic

            foreach (char letter in charList) //iterate through each character in the string
            {
                if (letter == ' ') //if the character is a space (the word has been completed)
                {
                    foreach (char wordletter in word) //iterate through each character in the completed word
                    {
                        reversedWord.Insert(0, wordletter); //insert the character at the beginning of the reversed word (front load)
                    }
                    reversedList.AddRange(reversedWord); //concatenate reversedWord onto the reversedList                    
                    reversedList.Add(letter); //add space to reversedList
                    reversedWord = new List<char>(); //clear out reversedWord
                    word = new List<char>(); //clear out word
                }
                else //if the character is not a space
                {
                    word.Add(letter); //add letter to individual word
                }
            }

            result = new string(reversedList.ToArray()); //convert reversedList char array to string
            result = result.Remove(result.Length - 1, 1); //remove last space that was added before loop

            return result;
        }

        private static int[] targetRange(List<int> marks, int target)
        {
            int[] result; //array to hold answer

            int index = 0; //index counter
            List<int> indexList = new List<int>(); //indexList to hold matching indicies

            foreach (int mark in marks) //iterate through marks array
            {

                if (mark == target) //if there's a match to the target, add the index to the indexList
                {
                    indexList.Add(index);
                }
                index++; //increase index by 1
            }

            if (!indexList.Any()) //if there's nothing in the indexList, return -1,-1
            {
                result = new int[] { -1, -1 };
            }
            else //else, find the first and last index and return them
            {
                int first = indexList[0];
                int last = indexList[indexList.Count - 1];
                result = new int[] { first, last };
            }

            return result;
        }

        public static string FreqSort(string s)
        {
            //Taking the length Of String

            int len = s.Length;


            // accumulate freqeuncy of each character using For Loop

            for (int i = 0; i < len; i++)
            {

                char ch = s[i];
                if (!dict.TryGetValue(ch, out int value))
                    dict.Add(ch, 1);
                else
                    dict[ch] = value + 1;

            }

            // Sorting the keys based on Values and adding in a String

            Console.WriteLine("Sorted by Value");
            Console.WriteLine("=============");
            string dictionaryString = "";
            foreach (KeyValuePair<char, int> ch in dict.OrderByDescending(key => key.Value))
            {

                dictionaryString += ch.Key;
                Console.WriteLine("Key: {0}, Value: {1}", ch.Key, ch.Value);

                // Checking if the value is more than 1 occurance and adding the same char
                if (ch.Value > 1)
                {
                    int val = ch.Value;
                    while (val > 1)
                    {
                        dictionaryString += ch.Key;
                        val--;
                    }
                }

            }

            //returning String to main
            return dictionaryString.TrimEnd(',', ' ');


        }

        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            int l1 = nums1.Length;
            int l2 = nums2.Length;
            Array.Sort(nums1);
            Array.Sort(nums2);
            int x = 0, y = 0;
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

        static int minSum(int[] arr, int n)
        {
            int sum = arr[0];

            for (int i = 1; i < n; i++)
            {
                if (arr[i] == arr[i - 1])
                {

                    // While current element is same as 
                    // previous or has become smaller 
                    // than previous. 
                    int j = i;
                    while (j < n && arr[j] <= arr[j - 1])
                    {
                        arr[j] = arr[j] + 1;
                        j++;
                    }
                }
                sum = sum + arr[i];
            }

            return sum;
        }
    }
}
