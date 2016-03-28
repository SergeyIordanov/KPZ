using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab1
{
    class Translator
    {
        private string poliz;
        private Stack<Operation> operationStack;

        public string Translate(string input)
        {
            poliz = "";
            operationStack = new Stack<Operation>();

            foreach (char ch in input)
            {
                putChar(ch);
            }
            while (operationStack.Count > 0)
            {
                poliz += operationStack.Pop();
            }
            return poliz;
        }

        private void putChar(char ch)
        {
            if (Operation.isOperation(ch))
            {
                Operation newOp = new Operation(ch);
                Operation prevOp;
                while (true)
                {
                    if (operationStack.Count == 0)
                        break;
                    prevOp = operationStack.Peek();

                    if (prevOp.Prioryty >= newOp.Prioryty)
                    {
                        poliz += prevOp.Character;
                        operationStack.Pop();
                    }
                    else
                        break;
                }
                operationStack.Push(newOp);
            }
            else
            {
                if (ch == '(')
                    operationStack.Push(new Operation('('));
                else if (ch == ')')
                {
                    while (true)
                    {
                        Operation op = operationStack.Pop();
                        if (op.Character == '(')
                            break;
                        poliz += op.Character;
                    }
                }
                else
                    poliz += ch;
            }
        }
    }
}
