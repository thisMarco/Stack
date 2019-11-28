using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_array
{
    public interface StackInterface
    {
        //Interface for the Stack
        void push(int element);
        void pop();
        bool stackFull();
        bool stackEmpty();
        void displayStack();
        void destroyStack();
    }
}
