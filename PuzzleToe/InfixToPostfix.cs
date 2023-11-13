using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BracketQuest
{
    internal class InfixToPostfix
    {
        private Stack<double> stack = new Stack<double>();

        public static int GetPrecedence(char @operator)
        {
            switch (@operator)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
            }
            return -1;
        }

        public static bool IsOperator(char c)
        {
            return (c == '+' || c == '-' || c == '*' || c == '/' || c == '^');
        }

        public static bool IsNegativeNumber(string s, int i)
        {
            if (i == 0)
            {
                return false;
            }
            char prevChar = s[i - 1];
            return (prevChar == '(' || IsOperator(prevChar));
        }

        public string InfixToPostfixConverter(string infix)
        {
            Stack<char> operatorStack = new Stack<char>();
            StringBuilder postfix = new StringBuilder();

            string token = "";
            for (int i = 0; i < infix.Length; i++)
            {
                char c = infix[i];

                if (char.IsDigit(c) || (c == '-' && IsNegativeNumber(infix, i)) || c == '.')
                {
                    token += c;
                }
                else
                {
                    postfix.Append(token + " ");
                    token = "";
                    switch (c)
                    {
                        case '(':
                            operatorStack.Push(c);
                            break;
                        case ')':
                            while (operatorStack.Count > 0 && operatorStack.Peek() != '(')
                            {
                                postfix.Append(operatorStack.Pop());
                            }
                            if (operatorStack.Count > 0 && operatorStack.Peek() == '(')
                            {
                                operatorStack.Pop();
                            }
                            break;
                        default:
                            while (operatorStack.Count > 0 && GetPrecedence(c) <= GetPrecedence(operatorStack.Peek()))
                            {
                                postfix.Remove(postfix.Length - 1, 1);
                                postfix.Append(operatorStack.Pop());
                                postfix.Append(" ");
                            }
                            operatorStack.Push(c);
                            break;
                    }
                }

                if (char.IsDigit(c) && i == infix.Length - 1)
                {
                    postfix.Append(token);
                }
            }

            while (operatorStack.Count > 0)
            {
                postfix.Append(operatorStack.Pop());
            }

            return postfix.ToString().Trim();
        }

        public bool HasDecimalValue(double num)
        {
            return (num.ToString().IndexOf('.') == -1 || num % 1 == 0);
        }

        public String GetValue(string pfExpression)
        {

            GetResult(InfixToPostfixConverter(pfExpression));

            double answer = stack.Pop();
            if (HasDecimalValue(answer))
            {
                return $"{answer:F0}";

            }
            return $"{answer:F2}";
        }

        public void GetResult(string pfExpression)
        {
            if (!Regex.IsMatch(pfExpression, "[0-9 .+\\-*/]+"))
            {
                MessageBox.Show("Invalid input string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string token = "";
            for (int i = 0; i < pfExpression.Length; i++)
            {
                double a, b, result;

                char c = pfExpression[i];
                if (char.IsDigit(c) || c == '.')
                {
                    token += c;
                }
                else if (c == ' ')
                {
                    if (!string.IsNullOrEmpty(token))
                    {
                        stack.Push(double.Parse(token));
                        token = "";
                    }
                }
                else
                {
                    if (!(token.Length == 0))
                    {
                        stack.Push(double.Parse(token));
                        token = "";
                    }
                    switch (pfExpression[i])
                    {
                        case '+':
                            if (stack.Count < 2)
                            {
                                a = stack.Pop();
                                result = a;
                                stack.Push(result);
                            }
                            else
                            {
                                a = stack.Pop();
                                b = stack.Pop();
                                result = a + b;
                                stack.Push(result);
                            }
                            break;
                        case '-':
                            if (stack.Count < 2)
                            {
                                a = stack.Pop();
                                result = a;
                                stack.Push(result);
                            }
                            else
                            {
                                a = stack.Pop();
                                b = stack.Pop();
                                result = b - a;
                                stack.Push(result);
                            }
                            break;
                        case '*':
                            if (stack.Count < 2)
                            {
                                a = stack.Pop();
                                result = a;
                                stack.Push(result);
                            }
                            else
                            {
                                a = stack.Pop();
                                b = stack.Pop();
                                result = a * b;
                                stack.Push(result);
                            }
                            break;
                        case '/':
                            if (stack.Count < 2)
                            {
                                a = stack.Pop();
                                result = a;
                                stack.Push(result);
                            }
                            else
                            {
                                a = stack.Pop();
                                b = stack.Pop();
                                result = b / a;
                                stack.Push(result);
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;
                    }
                }
            }

            
        }
    }
}
