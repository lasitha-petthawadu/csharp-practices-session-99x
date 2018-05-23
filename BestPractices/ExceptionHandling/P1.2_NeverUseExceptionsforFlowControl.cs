using System;

namespace BestPractices
{
    internal class P1_2_Bad
    {
        private void Method()
        {

            try
            {
                // Do work
                var someCondition = true;
                if (someCondition)
                {
                    throw new InvalidOperationException();
                }
            }
            catch (InvalidOperationException)
            {

            }
        }

    }

    internal class P1_2_Good
    {
        private void Method()
        {

            try
            {
                // Do work
                Unit2();
            }
            catch (InvalidOperationException)
            {

            }
        }

        private void Unit2()
        {
            var someCondition = true;
            if (someCondition)
            {
                throw new InvalidOperationException();
            }
        }
    }

}
