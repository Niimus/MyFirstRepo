using System.Collections.Generic;
using SportsStore.Domain.Entities;
using SportsStore.WebUI.HtmlHelpers;

namespace SportsStore.WebUI.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}