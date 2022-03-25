using System;

namespace WebSalesMvc.Views.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException(string message) : base(message)
        {
             
        }

    }
}
