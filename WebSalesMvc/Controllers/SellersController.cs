using Microsoft.AspNetCore.Mvc;
using WebSalesMvc.Models;
using WebSalesMvc.Models.ViewModels;
using WebSalesMvc.Services;


namespace WebSalesMvc.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        private readonly Departmentservice _derpartmentService;
        public SellersController(SellerService sellerService, Departmentservice departmentservice)
        {
            _sellerService = sellerService;
            _derpartmentService = departmentservice;    
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }
        public IActionResult Create()
        {
            var departments = _derpartmentService.FindAll();
            var viewModel = new SellerFormViewModel { Departments = departments };  
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
