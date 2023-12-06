
void PrintNums(int a, int b, int c)
{
    if (a > b && b > c) Console.WriteLine($"{a} {b} {c}");
}

void GetSumNums(int[] arr, int sum)
{
    HashSet<int> set = new(arr);

    foreach (int num1 in set)
    {
        int sum2 = sum - num1;

        foreach (int num2 in set)
        {
            if (num1 != num2)
            {             
                int num3 = sum2 - num2;
                if (set.Contains(num3))
                    PrintNums(num1, num2, num3);
            }
        }
    }
}
GetSumNums(new int[] { 1, 2, 8, 3, 12, 4, 5, 6, 7, -4, 8, 1, 9 }, 13);




