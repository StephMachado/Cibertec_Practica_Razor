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
    public class ContactTypeController : Controller
    {
        private ContactTypeData _contactTypeData = new ContactTypeData();

        // GET: ContactType
        public ActionResult Index()
        {
            return View(_contactTypeData.GetList());
        }

        // GET: ContactType/Create
        public ActionResult Create()
        {
            return View(new ContactType());
        }

        // POST: ContactType/Create
        [HttpPost]
        public ActionResult Create([Bind(Exclude = "ContactTypeID")] ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                var contactTypeFind = _contactTypeData.GetContactTypeName(contactType.Name);
                if (contactTypeFind == null)
                {
                    contactType.ModifiedDate = DateTime.Now;
                    _contactTypeData.Add(contactType);
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError("Name", "Registered name");
                }
            }
            return View();
        }

        // GET: ContactType/Edit/
        public ActionResult Edit(int id)
        {
            var contactTypeFind = _contactTypeData.GetContactType(id);
            if (contactTypeFind == null)
                RedirectToAction("Index");
            return View(contactTypeFind);
        }

        // POST: ContactType/Edit/
        [HttpPost]
        public ActionResult Edit(ContactType contactTypeEdit)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    contactTypeEdit.ModifiedDate = DateTime.Now;
                    _contactTypeData.Update(contactTypeEdit);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View();

        }

        // GET: ContactType/Delete/
        public ActionResult Delete(int id)
        {
            var contactType = _contactTypeData.GetContactType(id);
            if (contactType == null)
                RedirectToAction("Index");
            return View(contactType);
        }

        // POST: ContactType/Delete/
        [HttpPost]
        public ActionResult Delete(int id, ContactType contactType)
        {
            try
            {
                _contactTypeData.Delete(contactType);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
