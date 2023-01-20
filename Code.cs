using System;

class Program
{

	private static void nthFibonnacci(int nthTern)
	{
		int number1 = 0;
		int number2 = 1;
		int nthNumber;

		if (nthTern == 0)
		{
			Console.WriteLine("Term #0: 0");
		}
		else if (nthTern == 1)
		{
			Console.WriteLine("Term #1: 1");
		}
		else
		{
			for (int i = 0; i < nthTern; i++)
			{
				Console.WriteLine("Term #" + i + ": " + number1);
				nthNumber = number1 + number2;
				number1 = number2;
				number2 = nthNumber;
			}
		}
	}
    public static void Main(string[] args)
    {
        while(true)
        {
			try
			{
				Console.WriteLine("Please enter a number to calculate: ");
				int nthNumber = int.Parse(Console.ReadLine());

				nthFibonnacci(nthNumber);
			}
			catch (Exception)
			{
				Console.Clear();
				Console.WriteLine("Invalid number. Please try again.");

			}
        }
    }
}





































