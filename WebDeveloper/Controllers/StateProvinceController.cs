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
    public class StateProvinceController : Controller
    {
        private StateProvinceData _stateProvinceData = new StateProvinceData();
        private CountryRegionData _countryRegionData = new CountryRegionData();

        //1° Listar StateProvince
        // GET: StateProvince
        public ActionResult Index()
        {
            return View(_stateProvinceData.GetList());
        }

        //2° Crear StateProvince
        public ActionResult Create()
        {
            ViewBag.CountryRegions = _countryRegionData.GetList();
            return View(new StateProvince());
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "StateProvinceID")] StateProvince stateProvince)
        {
            if (ModelState.IsValid)
            {
                var stateProvinceFind = _stateProvinceData.GetStateProvince(stateProvince.StateProvinceID);
                if (stateProvinceFind == null)
                {
                    stateProvince.IsOnlyStateProvinceFlag = true;
                    stateProvince.ModifiedDate = DateTime.Now;
                    _stateProvinceData.Add(stateProvince);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("CountryRegionCode", "Cannot insert duplicate key");
                }
            }
            return View();
        }

        //3° Modificar StateProvince
        public ActionResult Edit(int id)
        {
            ViewBag.CountryRegions = _countryRegionData.GetList();
            var stateProvinceFind = _stateProvinceData.GetStateProvince(id);
            if (stateProvinceFind == null)
                RedirectToAction("Index");
            return View(stateProvinceFind);
        }

        [HttpPost]
        public ActionResult Edit(StateProvince stateProvinceEdit)
        {
            if (ModelState.IsValid)
            {
                stateProvinceEdit.IsOnlyStateProvinceFlag = true;
                stateProvinceEdit.ModifiedDate = DateTime.Now;
                _stateProvinceData.Update(stateProvinceEdit);
                return RedirectToAction("Index");
            }
            return View();
        }

        //4° Eliminar StateProvince
        public ActionResult Delete(int id)
        {
            var stateProvince = _stateProvinceData.GetStateProvince(id);
            if (stateProvince == null)
                RedirectToAction("Index");
            return View(stateProvince);
        }

        [HttpPost]
        public ActionResult Delete(StateProvince stateProvince)
        {
            _stateProvinceData.Delete(stateProvince);
            return RedirectToAction("Index");
        }

    }
}