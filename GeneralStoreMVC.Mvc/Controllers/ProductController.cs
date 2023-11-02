using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreMVC.Models.ProductModels;
using GeneralStoreMVC.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace GeneralStoreMVC.Mvc.Controllers
{
    public class ProductController : Controller
    {   
        private readonly IProductService _productService;
        // public IActionResult Index()
        // {
        //     // List<ProductIndex> products = await _productService.GetAllCustomersAsync();

        //     // return View(products);
        // }
    }
}