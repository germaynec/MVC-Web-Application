using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GeneralStoreMVC.Data;
using GeneralStoreMVC.Data.Entities;
using GeneralStoreMVC.Models.CustomerModels;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreMVC.Services.CustomerServices;

public class CustomerService : ICustomerService
{
    private readonly GeneralStoreDbContext _dbContext;
    private readonly IMapper _mapper;

    public CustomerService(GeneralStoreDbContext dbContext, IMapper mapper)
    {   
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public Task<CustomerIndex> CreateNewCustomerAsync(CustomerCreate request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteCustomerAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> EditCustomerInfoAsync(CustomerEdit request)
    {
        throw new NotImplementedException();
    }

    public async Task<List<CustomerIndex>> GetAllCustomersAsync()
    {
        var customers = await _dbContext.Customers
            .Select(entity => _mapper.Map<CustomerEntity, CustomerIndex>(entity))
            .ToListAsync();

            return customers; 
        // List<CustomerIndex> customers = await _dbContext.Customers
        //     .Select(r => new CustomerIndex()
        //     {
        //         Id = r.Id,
        //         Name = r.Name,
        //         Email = r.Email
        //     }).ToListAsync();

        // return customers;
    }

    public Task<CustomerDetail> GetCustomerByIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}
