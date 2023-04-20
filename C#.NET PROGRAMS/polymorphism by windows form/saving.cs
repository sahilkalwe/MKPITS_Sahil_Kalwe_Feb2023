using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_by_windows_form
{ 
        class Saving : account1
        {
            public int intrest = 500;
            public override int deposit(int amt)
            {
                bal = bal + amt + intrest;
            return bal;
            }
        }
      
    }
