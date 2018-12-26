using System;
namespace Reverse_String

/*Task:
Your task is to write a function which returns the sum of following series upto nth term(parameter).

Series: 1 + 1/4 + 1/7 + 1/10 + 1/13 + 1/16 +...
Rules:
You need to round the answer to 2 decimal places and return it as String.

If the given value is 0 then it should return 0.00

You will only be given Natural Numbers as arguments.*/


{

    public class NthSedries
    {




        public static class NthSeries
        {

            public static string seriesSum(int n)
            {
                double result = 0;
                double reverage = 1;
                for (int i = 0; i < n; i += 1)
                {
                    if (i == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        reverage += 3;
                        result = result + (1 / reverage);
                    }
                }
                result = Math.Round(result, 2);
                return result.ToString("N2");
            }
        }

    }
}
