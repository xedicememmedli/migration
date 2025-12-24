using Front_to_Back.DAL;
using Front_to_Back.Models;
using Front_to_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;


namespace Front_to_Back.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
    

        public IActionResult Index()
        {
            List<Slide> slides = new List<Slide>()
            {
                new Slide
                {
                    Title="Title 1",
                    Discount=20,
                    Description="Lorem ipsum ipsum",
                    Order=1,
                    Image="1-1-524x617.png"
                },
                new Slide 
                {
                    Title="Title 2",
                    Discount=20,
                    Description="Lorem ipsum ipsum",
                    Order=3,
                    Image="1-1-524x617.png"
                },
                 new Slide
                 {
                    Title="Title 3",
                    Discount=20,
                    Description="Lorem ipsum ipsum",
                    Order=2,
                    Image="1-1-524x617.png"
                }
            };

            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Title="Title 1",
                    Price=20,
                    Order=1,
                    Image="1-1-270x300.jpg"
                },
                new Product
                {
                    Title="Title 2",
                    Price=22,
                    Order=5,
                    Image="1-2-270x300.jpg"
                },
                 new Product
                 {
                    Title="Title 3",
                    Price=23,
                    Order=6,
                    Image="1-3-270x300.jpg"
                },
                  new Product
                 {
                    Title="Title 4",
                    Price=24,
                    Order=4,
                    Image="1-1-270x300.jpg"
                 },
                  new Product
                 {
                    Title="Title 5",
                    Price=25, 
                    Order=7,
                    Image="1-4-270x300.jpg"
                 },
                  new Product
                 {
                    Title="Title 6",
                    Price=26,
                    Order=3,
                    Image="1-4-270x300.jpg"
                 },
                  new Product
                 {
                    Title="Title 7",
                    Price=27,
                    Order=2,
                    Image="1-3-270x300.jpg"
                 },
                  new Product
                 {
                    Title="Title 8",
                    Price=28,
                    Order=8,
                    Image="1-2-270x300.jpg"
                }
            };
        

            List<Blog> blogs = new List<Blog>()
            {
                new Blog
                {
                    Title="Title 1",
                    Description="Lorem ipsum ipsum",
                    Image="1-3-310x220.jpg",
                   Author = "Admin"
                },
                new Blog
                {
                    Title="Title 2",
                    Description="Lorem ipsum ipsum",
                    Image="1-3-310x220.jpg",
                    Author = "Tree Guardian"
                },
                 new Blog
                 {
                    Title="Title 3",
                    Description="Lorem ipsum ipsum",
                    Image="1-3-310x220.jpg",
                    Author = "Green Forest"
                }
            };


            //_context.Slides.AddRange(slides);
            //_context.SaveChanges();

            //_context.Blogs.AddRange(blogs);
            //_context.SaveChanges();

            //_context.Products.AddRange(products);
            //_context.SaveChanges();






            HomeVM homeVM = new HomeVM()
            {
                Slides = slides.OrderBy(s => s.Order).Take(2).ToList(),
                Products=products.OrderBy(s=>s.Order).ToList(),
                    Blogs = blogs
            }
            ;
           
            return View(homeVM);
        }
    }
}
