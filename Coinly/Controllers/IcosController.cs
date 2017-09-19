using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coinly.Models;
using Coinly.ViewModels;

namespace Coinly.Controllers
{
    public class IcosController : Controller
    {

        //[Route("Icos/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        //public ActionResult ByReleaseTear(int Year, int month)
        //{
        //    return Content(Year + "/" + month);

        //}

        //public ActionResult Edit( int id)
        //{
        //    return Content("id=" + id);

        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (String.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex={0}&soryBy={1}",pageIndex ,sortBy));

        //}



        private ApplicationDbContext _context;

        public IcosController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var icos = _context.ico.Include(i => i.IcoTypes).ToList();
            return View(icos);
        }

        //private IEnumerable<Ico> getIcos()
        //{
        //    return new List<Ico>
        //    {
        //        new Ico {Id = 1, Name = "Enigma"},
        //        new Ico {Id = 2, Name = "KyberNetwork"},
        //    };
        //}


        // GET: Icos/Random
        public ActionResult Random()
        {
            var ico = new Ico() { Name = "Enigma!" };

            var customer = new List<Customer>
            {
                new Customer {Name = "Uday"},
                new Customer {Name = "Akash"}
            };

            var viewModel = new RandomIcoViewModel
            {
                Ico = ico,
                Customer = customer
            };
            return View(viewModel);
        }

    }
}