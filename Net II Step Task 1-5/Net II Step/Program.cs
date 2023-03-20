using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Net_II_Step
{
	internal class Program
	{
		static void Main(string[] args)
		{

			// --------------------------- Task 1 --------------------------- 


			/*bool sPalindrome(string text)
			{
				var fromFirstCharacter = new List<char>();
				var fromLastCharacter = new List<char>();

				for (int i = 0;  i < text.Length; i++)
				{
					fromFirstCharacter.Add(text[i]);
				}

				for (int i = text.Length - 1; i >= 0; i--)
				{
					fromLastCharacter.Add(text[i]);
				}

				bool isEqual = Enumerable.SequenceEqual(fromFirstCharacter, fromLastCharacter);

				if (isEqual)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			Console.WriteLine(sPalindrome("level"));*/


			// --------------------------- Task 2 ---------------------------


			/*int MinSplit(int amount)
			{
				int[] cents = { 50, 20, 10, 5, 1 };
				int numberOfMonetsUsed = 0;
				int leftAmount = amount;
				int centIndex = 0;
				
				while (leftAmount > 0)
				{
					int remainder = leftAmount % cents[centIndex];
					int quotient = (leftAmount - remainder) / cents[centIndex];

					leftAmount = remainder;
					numberOfMonetsUsed += quotient;
					centIndex++;
				}

				return numberOfMonetsUsed;
			}

			Console.WriteLine(MinSplit(697));*/


			// --------------------------- Task 3 ---------------------------


			/*int notContains(int[] array)
			{
				Array.Sort(array);
				int minWholeNumber = 0;

				for (int i = 0; i < array.Length; i++)
				{
					int numberToCheck = array[i] + 1;
					bool exists = Array.Exists(array, element => element == numberToCheck);

					if ((array[i] + 1) > 0 && exists != true)
					{
						minWholeNumber = array[i] + 1;
						break;
					}
				}

				return minWholeNumber;
			}

			int[] arrayToInsert = { 189, 200, 77, 91, -23, 89 };
			
			Console.WriteLine(notContains(arrayToInsert));*/


			// --------------------------- Task 4 ---------------------------


			/*bool IsProperly(string sequence)
			{
				Stack<char> stack = new Stack<char>();
				
				for(int i = 0; i < sequence.Length; i++)
				{
					if (sequence[i] == '(')
					{
						stack.Push(sequence[i]);
					}
					else if (sequence[i] == ')')
					{
						if (stack.Count == 0)
						{
							return false;
						}
						else if (stack.Peek() == '(')
						{
							stack.Pop();
						}
					}
					else
					{
						continue;
					}
				}

				if (stack.Count == 0)
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			Console.WriteLine(IsProperly("((()))"));*/



			// --------------------------- Task 5 ---------------------------

			/*int possibleAlternatives(int currentStep, int targetStep)
			{
				int firstAlternative = currentStep + 1;
				int secondAlternative = currentStep + 2;

				if (currentStep == targetStep - 1)
				{
					return 1;
				}
				else if (currentStep == targetStep || currentStep > targetStep)
				{
					return 0;
				}
				else
					return 2 + (possibleAlternatives(firstAlternative, targetStep) + possibleAlternatives(secondAlternative, targetStep));
				
			}

			int CountVariants(int currentStep, int targetStep)
			{
				int stairCount = possibleAlternatives(currentStep, targetStep);

				return stairCount;
			}


			Console.WriteLine(CountVariants(0, 5));
*/



		}
	}
}
