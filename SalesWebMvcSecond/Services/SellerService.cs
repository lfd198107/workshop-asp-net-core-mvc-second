using SalesWebMvcSecond.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcSecond.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcSecondContext _context;

        public SellerService(SalesWebMvcSecondContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }

   
}
