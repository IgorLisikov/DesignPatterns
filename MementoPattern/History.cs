using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    public class History
    {
        private IList<DocumentState> _states;

        public History()
        {
            _states = new List<DocumentState>();
        }

        public void Push(DocumentState state)
        {
            _states.Add(state);
        }
        public DocumentState Pop()
        {
            int lastIndex = _states.Count - 1;
            var lastState = _states[lastIndex];
            _states.Remove(lastState);

            return lastState;
        }
    }
}
