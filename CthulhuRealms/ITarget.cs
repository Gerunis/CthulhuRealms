using System;
using System.Collections.Generic;
using System.Text;

namespace CthulhuRealms
{
    interface ITarget
    {
        int HP { get; }
        public void TakeDamage(int count);
    }
}
