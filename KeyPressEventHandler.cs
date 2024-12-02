using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class KeyPressEventHandler : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == EventType.KeyPress)
            {
                Console.WriteLine("Обработка события нажатия клавиши: " + request.Content);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
