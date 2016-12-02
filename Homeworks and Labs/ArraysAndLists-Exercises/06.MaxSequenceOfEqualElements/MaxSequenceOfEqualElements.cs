﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSequenceOfEqualElements
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int maxLength = 1;
        int length = 1;
        string digit = string.Empty;

        GetMaxLengthOfEqualsElement(nums, ref maxLength, ref length, ref digit);
        PrintEqualsDigits(maxLength, digit);
    }

    private static void GetMaxLengthOfEqualsElement(int[] nums, ref int maxLength, ref int length, ref string digit)
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] == nums[i + 1])
            {
                length++;

                if (i == nums.Length - 2)
                {
                    if (length > maxLength)
                    {
                        maxLength = length;
                        digit = nums[i].ToString();
                    }
                }
            }
            else
            {
                if (length > maxLength)
                {
                    maxLength = length;
                    digit = nums[i].ToString();
                }

                length = 1;
            }
        }
    }

    private static void PrintEqualsDigits(int maxLength, string digit)
    {
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(digit + " ");
        }
    }
}

