using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDeveloper.DataAccess;
using WebDeveloper.DataAccess.ClassData;
using WebDeveloper.Model;

namespace WebDeveloper.Controllers
{
    public class CountryRegionController : Controller
    {
        private CountryRegionData _countryRegionData = new CountryRegionData();

        //1° Listar CountryRegion
        // GET: CountryRegion
        public ActionResult Index()
        {
            return View(_countryRegionData.GetList());
        }

        //2° Crear CountryRegion
        public ActionResult Create()
        {
            return View(new CountryRegion());
        }

        [HttpPost]
        public ActionResult Create(CountryRegion countryRegion)
        {
            if (ModelState.IsValid)
            {
                var countryRegionFind = _countryRegionData.GetCountryRegion(countryRegion.CountryRegionCode);
                if (countryRegionFind == null)
                {
                    countryRegion.ModifiedDate = DateTime.Now;
                    _countryRegionData.Add(countryRegion);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("CountryRegionCode", "Cannot insert duplicate key");
                }
            }
            return View();
        }

        //3° Modificar CountryRegion
        public ActionResult Edit(string id)
        {
            var countryRegionFind = _countryRegionData.GetCountryRegion(id);
            if (countryRegionFind == null)
                RedirectToAction("Index");
            return View(countryRegionFind);
        }

        [HttpPost]
        public ActionResult Edit(CountryRegion countryRegionEdit)
        {
            if (ModelState.IsValid)
            {
                countryRegionEdit.ModifiedDate = DateTime.Now;
                _countryRegionData.Update(countryRegionEdit);
                return RedirectToAction("Index");
            }
            return View();
        }

        //4° Eliminar CountryRegion
        public ActionResult Delete(string id)
        {
            var countryRegion = _countryRegionData.GetCountryRegion(id);
            if (countryRegion == null)
                RedirectToAction("Index");
            return View(countryRegion);
        }

        [HttpPost]
        public ActionResult Delete(CountryRegion countryRegion)
        {
            if (ModelState.IsValid)
            {
                _countryRegionData.Delete(countryRegion);
                return RedirectToAction("Index");
            }
            return View();
        }        
    }
}