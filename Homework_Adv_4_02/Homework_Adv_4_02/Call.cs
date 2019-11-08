using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Adv_4_02
{
    class Call
    {
        public event Action PhoneCall;
        public void DoEvent()
        {
            PhoneCall?.Invoke();
        }
    }
}
