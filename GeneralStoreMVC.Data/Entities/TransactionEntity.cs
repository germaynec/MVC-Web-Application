using System.Runtime.InteropServices.ComTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralStoreMVC.Data.Entities;

public class TransactionEntity
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public DateTime DateOfTransaction { get; set; }

    [ForeignKey(nameof(Customer))]
    public int CustomerId { get; set; }
    public virtual CustomerEntity Customer { get; set; }

    [ForeignKey(nameof(Product))]
    public int ProductId { get; set; }
    public virtual ProductEntity Product { get; set; }
}
