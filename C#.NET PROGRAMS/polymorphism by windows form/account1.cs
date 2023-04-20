using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_by_windows_form
{
     class  account1
    {
            public int bal = 1000;
            public virtual int deposit(int amt)
            {
            return bal;
            }
        }
        
    }

