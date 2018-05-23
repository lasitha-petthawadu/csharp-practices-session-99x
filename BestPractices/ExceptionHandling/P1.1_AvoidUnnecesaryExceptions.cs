using System;
using System.Data;
using System.Data.SqlClient;

namespace BestPractices
{
    internal class P1_Bad
    {

        private void ConnectionClosing()
        {
            SqlConnection conn = CreateConnection();
            try
            {
                conn.Close();
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }
        }

        private SqlConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
    
    internal class P1_Good
    {
        // Check state and conditionally avoid the cause of exceptions.
        private void ConnectionClosing()
        {
            SqlConnection conn = CreateConnection();
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        private SqlConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
   
}
