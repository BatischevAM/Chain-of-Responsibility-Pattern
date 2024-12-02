using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class ClickEventHandler : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == EventType.Click)
            {
                Console.WriteLine("Обработка события клика: " + request.Content);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
