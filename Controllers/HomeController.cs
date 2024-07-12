using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;
using System.Diagnostics;

namespace SportsStore.Controllers
{
    public class HomeController : Controller
    {

        public IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        private IActionResult Index() => View(repository.Products);

        //modified by owner


    }
}
