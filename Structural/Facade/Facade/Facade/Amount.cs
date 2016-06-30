using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Amount
    {
        public float _amount;
        public Amount(float f)
        {
            _amount = f;
        }
        //uses the value of WTW class to calculate the profit
        public float returnProfit(float[] t)
        {
            float scrips = _amount / t[0];
            return _amount - (scrips * t[1]);
        }
    }
}
