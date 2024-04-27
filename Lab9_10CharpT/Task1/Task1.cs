namespace Lab9_10CharpT {
    class Task1
    {
        static bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static string PostfixToPrefix(string postfix)
        {
            Stack<string> stack = new();

            for (int i = 0; i < postfix.Length; i++)
            {
                if (Char.IsLetterOrDigit(postfix[i]))
                {
                    stack.Push(postfix[i].ToString());
                }
                else if (IsOperator(postfix[i]))
                {
                    string operand1 = stack.Pop();
                    string operand2 = stack.Pop();
                    string expression = postfix[i] + operand2 + operand1;
                    stack.Push(expression);
                }
            }

            return stack.Pop();
        }
     
        public static void ExecuteTask()
        {
            Console.WriteLine("Enter a postfix expression:");
            string postfixExpression = Console.ReadLine();
            
            string prefixExpression = PostfixToPrefix(postfixExpression);

            Console.WriteLine("Prefix expression: " + prefixExpression);
        }
    }

}