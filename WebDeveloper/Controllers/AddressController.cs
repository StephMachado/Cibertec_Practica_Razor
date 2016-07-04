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
    public class AddressController : Controller
    {
        private AddressData _addressData = new AddressData();

        //1° Listar Address
        // GET: Address
        public ActionResult Index()
        {
            return View(_addressData.GetList());
        }

        //2° Crear Address
        public ActionResult Create()
        {
            ViewBag.StateProvinces = _addressData.ListStateProvinces();
            return View(new Address());
        }

        [HttpPost]
        public ActionResult Create([Bind(Exclude = "AddressID")] Address address)
        {
            if (ModelState.IsValid)
            {
                var addressFind = _addressData.GetAdress(address.AddressID);
                if (addressFind == null)
                {
                    address.ModifiedDate = DateTime.Now;
                    _addressData.Add(address);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("StateProvinceID", "Cannot insert duplicate key");
                }
            }
            return View();
        }

        //3° Modificar Address
        public ActionResult Edit(int id)
        {
            ViewBag.StateProvinces = _addressData.ListStateProvinces();
            var addressFind = _addressData.GetAdress(id);
            if (addressFind == null)
                RedirectToAction("Index");
            return View(addressFind);
        }

        [HttpPost]
        public ActionResult Edit(Address addressEdit)
        {
            if (ModelState.IsValid)
            {
                addressEdit.ModifiedDate = DateTime.Now;
                _addressData.Update(addressEdit);
                return RedirectToAction("Index");
            }
            return View();
        }

        //4° Eliminar Address
        public ActionResult Delete(int id)
        {
            var address = _addressData.GetAdress(id);
            if (address == null)
                RedirectToAction("Index");
            return View(address);
        }

        [HttpPost]
        public ActionResult Delete(Address address)
        {
            try
            {
                _addressData.Delete(address);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}