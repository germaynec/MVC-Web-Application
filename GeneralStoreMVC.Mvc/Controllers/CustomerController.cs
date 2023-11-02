using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using GeneralStoreMVC.Models.CustomerModels;
using GeneralStoreMVC.Services.CustomerServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace GeneralStoreMVC.Mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly ICustomerService _customerService;

        public CustomerController(ILogger<CustomerController> logger, 
                ICustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        public async Task<IActionResult> Index()
        {
            List<CustomerIndex> customers = await _customerService.GetAllCustomersAsync();

            return View(customers);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}