using DropShop.Models;
using DropShop.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace DropShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly DropShopDbContext? _context;
        List<string> sizes = new List<string>() {"xs", "s", "m", "l", "xl", "xxl", "xxxl"};

        public HomeController(DropShopDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var item = _context?.Products;
            return View(item);
        }

        public IActionResult Item(int ProductsID) // will get the ProductsId parameter value from the http link automatically when it's passed from index.cshtml
        {
            dynamic item = new ExpandoObject();

            Products? SelectedItemFromProducts = _context?.Products?.First(x => x.ProductsId == ProductsID);
            Category? SelectedItemCategory = _context?.Category?.First(x => x.CategoryId == SelectedItemFromProducts.FK_Category_Products);
            List<Product>? SelectedItemsFromProduct = new List<Product>();

            foreach (Product? product in _context?.Product)
            {
                if (product.ProductId == ProductsID)
                {
                    SelectedItemsFromProduct.Add(product);
                }
            }
/*
#pragma warning disable CS8601 // Possible null reference assignment.
            Product[] SortedSelectedProduct = new Product[7];
            for(int i = 0; i < sizes.Count(); i++)
            {
                SortedSelectedProduct[i] = SelectedItemsFromProduct?.Find(x => x.Size?.ToLower() == sizes[i]);
            }
#pragma warning restore CS8601 // Possible null reference assignment.
*/
            item.SelectedItemFromProducts = SelectedItemFromProducts;
            item.SelectedItemCategory = SelectedItemCategory;
            item.SelectedItemsFromProduct = SelectedItemsFromProduct;

            return item != null ? View(item) : Problem("Entity sets are null!");
        }

        public IActionResult Login()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}