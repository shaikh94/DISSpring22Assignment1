using System;

namespace Assignment1
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Question 1
            Console.WriteLine("Q1: Enter the string:");
            string s = Console.ReadLine();
            string final_string = RemoveVowels(s);
            Console.WriteLine("Final string after removing the Vowels: {0}", final_string);
            Console.WriteLine();

            //Question 2:
            string[] bulls_string1 = new string[] { "Marshall", "Student", "Center" };
            string[] bulls_string2 = new string[] { "MarshallStudent", "Center" };
            bool flag = ArrayStringsAreEqual(bulls_string1, bulls_string2);
            Console.WriteLine("Q2");
            if (flag)
            {
                Console.WriteLine("Yes, Both the array’s represent the same string");
            }
            else
            {
                Console.WriteLine("No, Both the array’s don’t represent the same string ");
            }
            Console.WriteLine();




            //Question 4:
            Console.Write("Enter the length and width of array");
            int lb = int.Parse(Console.ReadLine()); // Read the dimensions
            int[,] bulls_grid = new int[lb, lb];

            for (int i = 0; i < lb; i++)
            {
                for (int j = 0; j < lb; j++)
                {
                    bulls_grid[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int diagSum = DiagonalSum(bulls_grid, lb);
            Console.WriteLine("The sum of diagonal elements in the bulls grid is {0}:", diagSum);

            //Question 5:
            Console.WriteLine("Q5:");
            String bulls_string = "aiohn";
            int[] indices = { 3, 1, 4, 2, 0 };
            String rotated_string = RestoreString(bulls_string, indices);
            Console.WriteLine("The  Final string after rotation is {0} ", rotated_string);
            Console.WriteLine();

            //Quesiton 6:
            string bulls_string6 = "mumacollegeofbusiness";
            char ch = 'c';
            string reversed_string = ReversePrefix(bulls_string6, ch);
            Console.WriteLine("Q6:");
            Console.WriteLine("Resultant string are reversing the prefix:{0}", reversed_string);
            Console.WriteLine();
        }

        public static string RemoveVowels(this string s)
        {
            string[] vowels = new string[] { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" }; //create an array of all vowels
            foreach (string c in vowels)
            {
                s = s.Replace(c, ""); //replace all occurences of characters defined in "vowels" apperaing in "s" with empty
            }

            return s;
        }

        public static bool ArrayStringsAreEqual(string[] bulls_string1, string[] bulls_string2)
        {
            string a = "";
            string b = "";
            for (int i = 0; i < bulls_string1.Length; i++)  // here, I'm concatenating all elements of first array into a
            {
                a = a + bulls_string1[i];
            }
            Console.WriteLine(a);

            for (int i = 0; i < bulls_string2.Length; i++) // here, I'm concatenating all elements of 2nd array into b
            {
                b = b + bulls_string2[i];
            }
            Console.WriteLine(b);

            bool result = a.Equals(b); //comparing the strings
            return result;
        }

        public static int DiagonalSum(int[,] bulls_grid, int lb)
        {
            int cnt = 0;
            for (int i = 0; i < lb; i++)
            {
                for (int j = 0; j < lb; j++)
                {

                    if (i == j || i + j == lb - 1) // if the indices match and the sum of indices = the dimension -1, numbers in these places represent the diagnol elements
                    {
                        cnt = bulls_grid[i, j] + cnt;
                    }
                }
            }

            return cnt;
        }

        public static string RestoreString(string bulls_string, int[] indices)
        {

            char[] ch = new char[bulls_string.Length]; // CREATE A DUMMY ARRAY
            for (int i = 0; i < bulls_string.Length; i++) // CONVERT BULLSTRING TO ARRAY
            {
                ch[i] = bulls_string[i];
            }
            char[] dummy = new char[bulls_string.Length]; // CREATE ANOTHER DUMMY ARRAY
            int cnt = 0;
            foreach (var item in indices) // ASSIGN THE VALUES FROM CH TO DUMMY BASED ON THE INDEX VALUE; SOLVE THE PROBLEM HERE
            {
                dummy[cnt] = ch[item];
                cnt++;
            }
            string result = string.Join("", dummy); //CONVERT ARRAY BACK TO STRING

            return result;

        }

        public static string ReversePrefix(string bulls_string, char ch)
        {
            int cnt = 0;
            for (int i = 0; i < bulls_string.Length; i++)  // here, I'm retrieving the place where the character is located
            {
                if (bulls_string[i] == ch)
                {
                    cnt = i;
                }
            }

            char[] dummy1 = new char[bulls_string.Length];
            int j = 0;
            for (int i = cnt; i >= 0; i--)  // here, I'm reversing the string from the placeholder we obtained earlier
            {
                dummy1[j] = bulls_string[i];
                j++;
            }


            int k = cnt;
            for (int i = cnt + 1; i < bulls_string.Length; i++) // here, I'm concatenating the reversed string with the remaining string
            {
                dummy1[k] = bulls_string[i];
                k++;
            }
            string result = string.Join("", dummy1);
            return result;


        }


    }
}
