using System;
using System.Runtime.InteropServices;

class For
{
	static void Main()
	{
		int sum = 0;
		Console.Write("1부터 N까지의 수를 입력하세요 : ");
		int n = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i <= n; i++)
		{
			if(i % 2 == 0)
			{
				sum += i;
			}
		}
        Console.WriteLine($"1부터 {n}까지의 합은 {sum}입니다");

	}
} 
