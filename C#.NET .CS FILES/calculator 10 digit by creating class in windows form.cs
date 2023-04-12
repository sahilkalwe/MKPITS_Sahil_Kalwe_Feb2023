using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator_10_digit_by_creating_class_in_windows_form
{
    internal class calculator
    {
        int prevno;

        char op;
        int result = 0;
        public char plusclick(int prevno)
        {
            this.prevno = prevno;
            op = '+';
            return op;
        }
        public char minusclick(int prevno)
        {
            this.prevno = prevno;
            op = '-';
            return op;
        }
        public char multiplyclick(int prevno)
        {
            this.prevno = prevno;
            op = '*';
            return op;
        }
        public char divideclick(int prevno)
        {
            this.prevno = prevno;
            op = '/';
            return op;
        }

        public int calculate1result(int num)
        {
            switch (op)
            {
                case '+':
                    result = prevno + num;
                    break;
                case '-':
                    result = prevno - num;
                    break;
                case '*':
                    result = prevno * num;
                    break;
                case '/':
                    result = prevno / num;
                    break;

            }
            return result;
        }
    }
}
