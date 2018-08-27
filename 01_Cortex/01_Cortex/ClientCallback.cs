using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ChattingInterfaces;

namespace _01_Cortex
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ClientCallback : IClient
    {
        public void PlaceHolder()
        {
            throw new NotImplementedException();
        }
    }
}
