using System;

namespace BestPractices
{
    internal class P6_1_Bad
    {
        private int Method()
        {
            int condition = 10;
            switch (condition)
            {
                case 10: return -1;
                case 5: return -10;
                default: return 50;
            } 
          
        }

    }

    internal class P6_1_Good
    {
        private void Method()
        {
            int condition = 10;
            if (condition<10)
            {
                throw new InvalidOperationException("Op failed 1 - "+condition);
            }

        }
    }
}
