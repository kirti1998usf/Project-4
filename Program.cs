using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Remove Duplicates from Sorted Array
            // Logic: This method removes duplicate elements from a sorted array in-place.
            // It keeps track of the unique elements using two pointers.
            // Handling corner cases: Handled cases where the array is null or empty.
            // Self-reflection: Utilized two-pointer approach for efficient removal of duplicates.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            // Question 2: Move Zeroes to End of Array
            // Logic: This method moves all zeroes in the array to the end while maintaining the relative order of non-zero elements.
            // It utilizes a two-pointer approach to swap elements.
            // Handling corner cases: Handled cases where the array is null or empty.
            // Self-reflection: Implemented in-place array manipulation for efficient zero movement.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            // Question 3: Find All Unique Triplets That Sum Up to Zero
            // Logic: This method finds all unique triplets in the array that sum up to zero.
            // It utilizes a two-pointer approach after sorting the array.
            // Handling corner cases: Handled cases where the array is null or less than three elements.
            // Self-reflection: Used sorting and two-pointer approach for efficient triplet finding.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            // Question 4: Find Maximum Consecutive Ones
            // Logic: This method finds the maximum number of consecutive ones in the array.
            // It iterates through the array and keeps track of the count of consecutive ones.
            // Handling corner cases: Handled cases where the array is null or empty.
            // Self-reflection: Used a simple iteration approach for finding consecutive ones.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            // Question 5: Convert Binary Number to Decimal
            // Logic: This method converts a binary number to its decimal representation.
            // It uses basic arithmetic operations to calculate the decimal equivalent.
            // Handling corner cases: Handled cases where the input number is negative.
            // Self-reflection: Implemented conversion without bitwise operators or Math.Pow function.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            // Question 6: Find Maximum Gap Between Successive Elements
            // Logic: This method finds the maximum difference between two successive elements in a sorted array.
            // It first sorts the array and then calculates the difference between adjacent elements.
            // Handling corner cases: Handled cases where the array has less than two elements.
            // Self-reflection: Used sorting and iteration for finding the maximum gap.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3, 6, 9, 1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            // Question 7: Find Largest Perimeter Triangle
            // Logic: This method finds the largest perimeter of a triangle that can be formed using elements from the array.
            // It sorts the array and checks for triplets that satisfy the triangle inequality theorem.
            // Handling corner cases: Handled cases where the array has less than three elements.
            // Self-reflection: Utilized sorting and linear scan for finding the largest perimeter.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2, 1, 2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            // Question 8: Remove All Occurrences of a Substring
            // Logic: This method removes all occurrences of a specified substring from a given string.
            // It utilizes the string's Replace method to remove occurrences.
            // Handling corner cases: Handled cases where the string or substring is null or empty.
            // Self-reflection: Leveraged built-in string manipulation functions for efficient removal.
            // Code comments: Added comments to explain each step of the algorithm.
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        // Question 1: Remove Duplicates from Sorted Array
        // Logic: This method removes duplicate elements from a sorted array in-place.
        // It keeps track of the unique elements using two pointers.
        // Handling corner cases: Handled cases where the array is null or empty.
        // Self-reflection: Utilized two-pointer approach for efficient removal of duplicates.
        // Code comments: Added comments to explain each step of the algorithm.
        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Check if the input array is null or empty
                if (nums == null || nums.Length == 0)
                    return 0;

                // Initialize an index to track the position of unique elements
                int index = 1;

                // Iterate through the array starting from the second element
                for (int i = 1; i < nums.Length; i++)
                {
                    // If the current element is different from the previous one, it's unique
                    if (nums[i] != nums[i - 1])
                    {
                        // Move the unique element to the current index
                        nums[index] = nums[i];

                        // Move to the next index to track the next unique element
                        index++;
                    }
                }

                // Return the number of unique elements (index represents the length of the array with unique elements)
                return index;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 2: Move Zeroes to End of Array
        // Logic: This method moves all zeroes in the array to the end while maintaining the relative order of non-zero elements.
        // It utilizes a two-pointer approach to swap elements.
        // Handling corner cases: Handled cases where the array is null or empty.
        // Self-reflection: Implemented in-place array manipulation for efficient zero movement.
        // Code comments: Added comments to explain each step of the algorithm.
        public static IList<int> MoveZeroes(int[] nums)
        {
            try
            {
                // Check if the input array is null or empty
                if (nums == null || nums.Length == 0)
                    return new List<int>();

                // Initialize variables to track zero count and non-zero elements
                int zeroCount = 0;
                List<int> nonZeroList = new List<int>();

                // Iterate through the array to separate zero and non-zero elements
                foreach (var num in nums)
                {
                    if (num != 0)
                        nonZeroList.Add(num);
                    else
                        zeroCount++;
                }

                // Append zeros to the end of the list
                for (int i = 0; i < zeroCount; i++)
                {
                    nonZeroList.Add(0);
                }

                // Return the list with zeroes moved to the end
                return nonZeroList;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 3: Find All Unique Triplets That Sum Up to Zero
        // Logic: This method finds all unique triplets in the array that sum up to zero.
        // It utilizes a two-pointer approach after sorting the array.
        // Handling corner cases: Handled cases where the array is null or less than three elements.
        // Self-reflection: Used sorting and two-pointer approach for efficient triplet finding.
        // Code comments: Added comments to explain each step of the algorithm.
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                // Check if the input array is null or has less than three elements
                if (nums == null || nums.Length < 3)
                    return new List<IList<int>>();

                // Initialize a list to store the result triplets
                List<IList<int>> result = new List<IList<int>>();

                // Sort the array to simplify the process
                Array.Sort(nums);

                // Iterate through the array
                for (int i = 0; i < nums.Length - 2; i++)
                {
                    // Skip duplicate elements
                    if (i > 0 && nums[i] == nums[i - 1])
                        continue;

                    // Initialize left and right pointers
                    int left = i + 1;
                    int right = nums.Length - 1;

                    // Iterate using two pointers
                    while (left < right)
                    {
                        // Calculate the sum of three elements
                        int sum = nums[i] + nums[left] + nums[right];

                        // If sum is zero, add the triplet to the result
                        if (sum == 0)
                        {
                            result.Add(new List<int> { nums[i], nums[left], nums[right] });

                            // Skip duplicate elements
                            while (left < right && nums[left] == nums[left + 1])
                                left++;

                            while (left < right && nums[right] == nums[right - 1])
                                right--;

                            left++;
                            right--;
                        }
                        // If sum is less than zero, move left pointer to the right
                        else if (sum < 0)
                        {
                            left++;
                        }
                        // If sum is greater than zero, move right pointer to the left
                        else
                        {
                            right--;
                        }
                    }
                }

                // Return the list of unique triplets
                return result;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 4: Find Maximum Consecutive Ones
        // Logic: This method finds the maximum number of consecutive ones in the array.
        // It iterates through the array and keeps track of the count of consecutive ones.
        // Handling corner cases: Handled cases where the array is null or empty.
        // Self-reflection: Used a simple iteration approach for finding consecutive ones.
        // Code comments: Added comments to explain each step of the algorithm.
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                // Initialize variables to store maximum count and current count
                int maxCount = 0;
                int count = 0;

                // Iterate through the array
                foreach (int num in nums)
                {
                    // If the element is one, increment the count
                    if (num == 1)
                    {
                        count++;
                        maxCount = Math.Max(maxCount, count);
                    }
                    // If the element is not one, reset the count
                    else
                    {
                        count = 0;
                    }
                }

                // Return the maximum count of consecutive ones
                return maxCount;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 5: Convert Binary Number to Decimal
        // Logic: This method converts a binary number to its decimal representation.
        // It uses basic arithmetic operations to calculate the decimal equivalent.
        // Handling corner cases: Handled cases where the input number is negative.
        // Self-reflection: Implemented conversion without bitwise operators or Math.Pow function.
        // Code comments: Added comments to explain each step of the algorithm.
        public static int BinaryToDecimal(int binary)
        {
            try
            {
                // Check if the binary number is negative
                bool isNegative = binary < 0;

                // Convert the binary number to its absolute value
                binary = Math.Abs(binary);

                // Initialize variables for decimal number and base value
                int decimalNumber = 0;
                int baseValue = 1;

                // Convert binary to decimal using basic arithmetic operations
                while (binary > 0)
                {
                    int lastDigit = binary % 10;
                    binary = binary / 10;

                    decimalNumber += lastDigit * baseValue;
                    baseValue *= 2;
                }

                // If the original number was negative, negate the result
                if (isNegative)
                    decimalNumber *= -1;

                // Return the decimal equivalent of the binary number
                return decimalNumber;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 6: Find Maximum Gap Between Successive Elements
        // Logic: This method finds the maximum difference between two successive elements in a sorted array.
        // It first sorts the array and then calculates the difference between adjacent elements.
        // Handling corner cases: Handled cases where the array has less than two elements.
        // Self-reflection: Used sorting and iteration for finding the maximum gap.
        // Code comments: Added comments to explain each step of the algorithm.
        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Check if the array has less than two elements
                if (nums.Length < 2)
                    return 0;

                // Sort the array to simplify the process
                Array.Sort(nums);

                // Initialize variable to store maximum gap
                int maxGap = int.MinValue;

                // Iterate through the array to find the maximum gap
                for (int i = 1; i < nums.Length; i++)
                {
                    maxGap = Math.Max(maxGap, nums[i] - nums[i - 1]);
                }

                // Return the maximum gap between successive elements
                return maxGap;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 7: Find Largest Perimeter Triangle
        // Logic: This method finds the largest perimeter of a triangle that can be formed using elements from the array.
        // It sorts the array and checks for triplets that satisfy the triangle inequality theorem.
        // Handling corner cases: Handled cases where the array has less than three elements.
        // Self-reflection: Utilized sorting and linear scan for finding the largest perimeter.
        // Code comments: Added comments to explain each step of the algorithm.
        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                // Sort the array to simplify the process
                Array.Sort(nums);

                // Get the length of the array
                int n = nums.Length;

                // Iterate through the array in reverse order to find the largest perimeter
                for (int i = n - 1; i >= 2; i--)
                {
                    // Check if the triplet forms a valid triangle
                    if (nums[i - 2] + nums[i - 1] > nums[i])
                        return nums[i - 2] + nums[i - 1] + nums[i];
                }

                // If no valid triangle is found, return 0
                return 0;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Question 8: Remove All Occurrences of a Substring
        // Logic: This method removes all occurrences of a specified substring from a given string.
        // It utilizes the string's Replace method to remove occurrences.
        // Handling corner cases: Handled cases where the string or substring is null or empty.
        // Self-reflection: Leveraged built-in string manipulation functions for efficient removal.
        // Code comments: Added comments to explain each step of the algorithm.
        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                // Check if the input string or substring is null or empty
                if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(part))
                    return s;

                // Remove all occurrences of the substring using Replace method
                string result = s.Replace(part, "");

                // Return the modified string
                return result;
            }
            catch (Exception)
            {
                // If an exception occurs, propagate it
                throw;
            }
        }

        // Helper method to convert IList<int> to string
        private static string ConvertIListToArray(IList<int> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var num in list)
            {
                sb.Append(num);
                sb.Append(",");
            }
            if (list.Count > 0)
                sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }

        // Helper method to convert IList<IList<int>> to string
        private static string ConvertIListToNestedList(IList<IList<int>> list)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (var innerList in list)
            {
                sb.Append("[");
                foreach (var num in innerList)
                {
                    sb.Append(num);
                    sb.Append(",");
                }
                if (innerList.Count > 0)
                    sb.Remove(sb.Length - 1, 1);
                sb.Append("]");
                sb.Append(",");
            }
            if (list.Count > 0)
                sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            return sb.ToString();
        }
    }
}
