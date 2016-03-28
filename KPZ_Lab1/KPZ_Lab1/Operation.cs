using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPZ_Lab1
{
    class Operation
    {
        public char Character { get; private set; }
        public int Prioryty { get; private set; }
        public int Size { get; set; }

        public Operation(char ch)
        {
            Character = ch;
            int prioryty;
            switch (ch)
            {
                case '=': prioryty = 0; break;
                case '+': prioryty = 1; break;
                case '-': prioryty = 1; break;
                case '*': prioryty = 2; break;
                case '/': prioryty = 2; break;
                default: prioryty = -1; break;
            }
            Prioryty = prioryty;
        }

        public static bool isOperation(char ch)
        {
            char[] oprs = { '=', '+', '-', '*', '/', ';' };
            foreach (char opr in oprs)
            {
                if (ch == opr)
                    return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var op = obj as Operation;
            return op.Prioryty == Prioryty && op.Character == Character;

        }

        public override int GetHashCode()
        {
            return Character.GetHashCode() + Prioryty;
        }

        public static bool operator <(Operation op1, Operation op2)
        {
            return op1.Prioryty < op2.Prioryty;
        }

        public static bool operator >(Operation op1, Operation op2)
        {
            return op1.Prioryty > op2.Prioryty;
        }

        public static bool operator >=(Operation op1, Operation op2)
        {
            return !(op1 < op2);
        }

        public static bool operator <=(Operation op1, Operation op2)
        {
            return !(op1 > op2);
        }

        public static bool operator ==(Operation op1, Operation op2)
        {
            return op1.Equals(op2);
        }

        public static bool operator !=(Operation op1, Operation op2)
        {
            return !(op1 == op2);
        }

        public override string ToString()
        {
            return Character.ToString();
        }
    }
}
