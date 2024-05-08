using Microsoft.AspNetCore.Mvc;
using MVCtask.DAL;
using MVCtask.Models;
using MVCtask.ViewModels;

namespace MVCtask.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {

            OrganicProduct product1 = new OrganicProduct
            {
                Name = "Alma",
                Price=5,
                Img="product-1.png"
                
            };

            OrganicProduct product2 = new OrganicProduct
            {
                Name = "Armud",
                Price = 2,
                Img = "product-2.png"
            };

            OrganicProduct product3 = new OrganicProduct
            {
                Name = "Qarpiz",
                Price = 100,
                Img = "product-1.png"
            };


            List<OrganicProduct> products = new List<OrganicProduct> { product1, product2, product3 };


            Farmer farmer1 = new Farmer
            {
                Name = "Ali",
                Img = "team-1.jpg",
                Designation = "Designation",
                Linkedin = "https://az.linkedin.com/",
                InstaLink = "https://www.instagram.com/",
                XLink = "https://www.instagram.com/",

            };
            Farmer farmer2 = new Farmer
            {
                Name = "Veli",
                Img = "team-3.jpg",
                Designation = "Designation",
                Linkedin = "https://az.linkedin.com/",
                InstaLink = "https://www.instagram.com/",
                XLink = "https://www.instagram.com/",

            };
            Farmer farmer3 = new Farmer
            {
                Name ="Esref",
                Img = "team-2.jpg",
                Designation = "Designation",
                Linkedin = "https://az.linkedin.com/",
                InstaLink = "https://www.instagram.com/",
                XLink = "https://www.instagram.com/",

            };

            List<Farmer> farmers= new List<Farmer> { farmer1, farmer2, farmer3 };

            HomeVM vm = new HomeVM()
            {
                Farmers=farmers,
                OrganicProducts=products,

            };

            return View(vm);
        }
    }
}
