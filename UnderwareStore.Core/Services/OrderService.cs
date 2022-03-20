using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderwareStore.Core.Contracts;
using UnderwareStore.Core.Models;
using UnderwareStore.Infrastructure.Data;
using UnderwareStore.Infrastructure.Data.Repositories;

namespace UnderwareStore.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly IApplicatioDbRepository repo;

        public OrderService(IApplicatioDbRepository _repo)
        {
            repo = _repo;
        }

        public async Task PlaceOrder(CustomerOrder order)
        {
            string customerNumber = order.CustomerNumber?.Trim() ?? string.Empty;
            var customer = await repo.All<Customer>()
                .FirstOrDefaultAsync(c => c.PhoneNumber == customerNumber);
            if (customer == null)
            {
                throw new ArgumentException("Unknown custommer");
            }

            var barcodes = order.Items
                .Select(i => i.Barcode)
                .ToArray();

            var products = await repo.All<Item>()
                .Where(i => barcodes.Contains(i.Barcode))
                .ToDictionaryAsync(k => k.Barcode, v => v.Id);

            foreach (var item in order.Items)
            {
                if (!products.ContainsKey(item.Barcode) ||
                    item.Count > products[item.Barcode])
                {
                    throw new ArgumentException("Not enough quantity");
                }
            }
        }
    }
}
