using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NorthwindCoModels;
using NorthwindCoViewModels;

namespace NorthwindCoWeb.Controllers
{
    public class HomeController : Controller
    {
        private List<Country> _countries = new List<Country>();
        private List<State> _states = new List<State>();
        private List<Town> _towns = new List<Town>();

        public ActionResult Index()
        {
            var model = new CascadingDropdownViewModel();

            return View(model.LoadModel());
        }

        public ActionResult LoadCountriesList()
        {
            var model = new CascadingDropdownViewModel();

            model = model.LoadModel();

            _countries = model.AllCountries;

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                        _countries,
                        "Id",
                        "Description"), JsonRequestBehavior.AllowGet
                );
            return null;
        }

        public ActionResult LoadStateList(int id)
        {
            var model = new CascadingDropdownViewModel();

            model = model.LoadModel();

            _states = model.AllStates.Where(x => x.CountryId == id).ToList();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                        _states,
                        "Id",
                        "Description"), JsonRequestBehavior.AllowGet
                );

            return null;
        }

        public ActionResult LoadTownList(int id)
        {
            var model = new CascadingDropdownViewModel();

            model = model.LoadModel();

            _towns = model.AllTowns.Where(x => x.StateId == id).ToList();

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                        _towns,
                        "Id",
                        "Description"), JsonRequestBehavior.AllowGet
                );

            return null;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}