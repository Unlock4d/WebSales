using System.Collections.Generic;
using System.Linq;
using WebSalesMvc.Data;
using WebSalesMvc.Models;
namespace WebSalesMvc.Services
{
    public class SellerService
    {
        private readonly WebSalesMvcContext _context;

        public SellerService(WebSalesMvcContext context)
        {
            _context = context; 
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
