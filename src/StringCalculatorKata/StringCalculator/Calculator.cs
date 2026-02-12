
using System;
using System.Linq;

public class Calculator
{
    public int Add(string numbers)
    {

        if (string.IsNullOrEmpty(numbers))
        {
            return 0;
        }

        var delimitors = new List<String> { ",", "\n" };

        if (numbers.StartsWith("//"))
        {
            if (numbers.Length > 3 && numbers[3] == '\n')
            {
                    delimitors.Add(numbers[2].ToString());
                    numbers = numbers.Substring(4);

            }
        }

        var nums = numbers.Split(delimitors.ToArray(), StringSplitOptions.RemoveEmptyEntries);

        var sum = 0;

        foreach (var number in nums)
        {
            sum += int.Parse(number);
        }



        return sum;
    }
}
