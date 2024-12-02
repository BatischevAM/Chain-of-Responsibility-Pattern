using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public abstract class EventHandler
    {
        protected EventHandler nextHandler;

        public void SetNext(EventHandler handler)
        {
            nextHandler = handler;
        }

        public abstract void HandleRequest(EventRequest request);
    }
}
