﻿using System.Collections.Generic;
using System.Linq;
using WebSalesMvc.Data;
using WebSalesMvc.Models;

namespace WebSalesMvc.Services
{
    public class Departmentservice
    {

        private readonly WebSalesMvcContext _context;

        public Departmentservice(WebSalesMvcContext context)
        {
            _context = context;
        }
        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
