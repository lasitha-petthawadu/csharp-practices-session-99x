using log4net;
using System;
using System.IO;

namespace BestPractices
{
    internal class P8_1_Bad
    {
        private ILog log;
        private void Method()
        {
            String dataContext = string.Empty;
            try
            {
                //logic
            }
            catch (IOException ex)
            {
                log.Error("Data for error " + dataContext);
                log.Error(ex);
            }

        }

    }

    internal class P8_1_Good
    {
        private ILog log;
        private void Method()
        {
            String dataContext = string.Empty;
            try
            {
                //logic
            }
            catch (IOException ex)
            {
                log.Error("Data for error " + dataContext,ex);
            }

        }
    }
}
