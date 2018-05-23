using log4net;
using System;
using System.IO;

namespace BestPractices
{
    internal class P5_1_Bad
    {
        private ILog log; 
        private void Method()
        {

            try
            {

            }
            catch (IOException ex)
            {
                log.Error(ex);
                throw ex;
            }
        }
        
    }

    internal class P5_1_Good
    {
        private ILog log;
        private void Method()
        {

            try
            {

            }
            catch (IOException ex)
            {
                log.Error(ex);
                // Remember that you are responsible to handle the exception fully!
            }
        }

    }

    internal class P5_1_Good_2
    {
        private ILog log;
        private void Method()
        {

            try
            {

            }
            /// Re-throw with purpose
            catch (IOException ex)
            {
                throw new CustomException(ex);
            }
        }

    }

}
