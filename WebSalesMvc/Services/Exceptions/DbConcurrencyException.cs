using System;

namespace WebSalesMvc.Views.Exceptions
{
    public class DbConcurrencyException :ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
