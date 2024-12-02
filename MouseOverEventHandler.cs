using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class MouseOverEventHandler : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == EventType.MouseOver)
            {
                Console.WriteLine("Обработка события наведения мыши: " + request.Content);
            }
            else if (nextHandler != null)
            {
                nextHandler.HandleRequest(request);
            }
        }
    }
}
