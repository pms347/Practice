using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Sorting
    {
        public void sortStringAsc()
        {
            char temp;
            string inputStr = "dcasdasdsadasdasba";
            inputStr = inputStr.ToLower();
            char[] inputcharArr = inputStr.ToCharArray();

            for (int i=0; i< inputcharArr.Length; i++)
            {
                for(int j=0; j< inputcharArr.Length -1 ; j++)
                {
                    if(inputcharArr[j] > inputcharArr[j+1])
                    {
                        temp = inputcharArr[j];
                        inputcharArr[j] = inputcharArr[j+1];
                        inputcharArr[j+1] = temp;
                    }
                }
            }
            Console.Write(inputcharArr);
        }
        public void sortStringDesc()
        {
            Console.WriteLine();
            char temp;
            string inputStr = "dcasdasdsadasdasba";
            inputStr = inputStr.ToLower();
            char[] inputcharArr = inputStr.ToCharArray();

            for (int i = 0; i < inputcharArr.Length; i++)
            {
                for (int j = 0; j < inputcharArr.Length - 1; j++)
                {
                    if (inputcharArr[j] < inputcharArr[j + 1])
                    {
                        temp = inputcharArr[j];
                        inputcharArr[j] = inputcharArr[j + 1];
                        inputcharArr[j + 1] = temp;
                    }
                }
            }
            Console.Write(inputcharArr);
        }

        public void sortNumAsc()
        {
            Console.WriteLine();
            int[] inputArr = { 10, 20, 30, 40 , 60 ,20,30,45,89,90};
            int temp = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j] < inputArr[j + 1])
                    {
                        temp = inputArr[j];
                        inputArr[j] = inputArr[j + 1];
                        inputArr[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < inputArr.Length; i++)
            {
                Console.Write(" {0},", inputArr[i]);
            }
        }
        public void sortNumDesc()
        {
            Console.WriteLine();
            int[] inputArr = { 10, 20, 30, 40, 60, 20, 30, 45, 89, 90 };
            int temp = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 0; j < inputArr.Length - 1; j++)
                {
                    if (inputArr[j] > inputArr[j + 1])
                    {
                        temp = inputArr[j];
                        inputArr[j] = inputArr[j + 1];
                        inputArr[j + 1] = temp;
                    }
                }
            }
            for(int i=0; i< inputArr.Length; i++)
            {
                Console.Write(" {0},", inputArr[i]);
            }
        }
    }
}
