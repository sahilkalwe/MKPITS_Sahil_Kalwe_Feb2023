using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_by_windows_form
{
    class Current : account1
    {
        public override int deposit(int amt)
        {
            bal = bal + amt;
            return bal;
        }
    }
}
