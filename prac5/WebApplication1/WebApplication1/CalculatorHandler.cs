using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class CalculatorHandler
    {
        private const string Operators = "+-/*";
        private const string Digits = "0123456789";
        public static long GetResult(string expression)
        {
            if (expression == null) { return 0; }
            if (expression.Length == 0) {  return 0; }

            List<long> numbers = new List<long>();
            List<char> operators = new List<char>();

            int startPosition = 0;
            int position = 0;

            if (expression[0] == '-')
            {
                numbers.Add(0);
                operators.Add('-');
                position = 1;
                startPosition = 1;
            }
            else
            {
                while (position < expression.Length && !Digits.Contains(expression[position]))
                    position++;
                startPosition = position;
            }

            for (; position < expression.Length; position++)
            {
                if (Operators.Contains(expression[position]))
                {
                    numbers.Add(int.Parse(expression.Substring(startPosition, position - startPosition)));
                    operators.Add(expression[position]);

                    while (Operators.Contains(expression[position]) && position < expression.Length - 1)
                    {
                        position++;
                    }
                    startPosition = position;
                }
            }

            numbers.Add(int.Parse(expression.Substring(startPosition, position - startPosition)));


            for (int i = 0; i < operators.Count; i++)
            {
                if (operators[i] == '*')
                {
                    numbers[i] *= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i -= 1;
                }

                else if (operators[i] == '/')
                {
                    numbers[i] /= numbers[i + 1];
                    numbers.RemoveAt(i + 1);
                    operators.RemoveAt(i);
                    i -= 1;
                }
            }

            while (operators.Count > 0)
            {
                if (operators[0] == '+')
                    numbers[0] += numbers[1];

                else
                    numbers[0] -= numbers[1];

                numbers.RemoveAt(1);
                operators.RemoveAt(0);
            }

            return numbers[0];
        }
    }
}