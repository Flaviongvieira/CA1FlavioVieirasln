using CA1FlavioVieira.Models;
using CA1FlavioVieira.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CA1FlavioVieira.Controllers
{
    public class PackageController : Controller
    {
        // Initiate Repository
        IRepository _repo;
        public PackageController(IRepository repo) { _repo = repo; }

        // GET: PackageController
        public ActionResult Index()
        {
            var packages = _repo.DisplayPackages();
            return View(packages);
        }

        // GET: PackageController/Details/5
        public ActionResult Details(int id)
        {
            var package = _repo.GetPackage(id);
            var shipinfo = _repo.ShippingInfo(package);
            return View(shipinfo);
        }

        // GET: PackageController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PackageController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Package package)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repo.AddPackage(package);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(package);
            }
        }

        // GET: PackageController/Edit/5
        public ActionResult Edit(int id)
        {
            var package = _repo.GetPackage(id);
            return View(package);
        }

        // POST: PackageController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Package package)
        {
            try
            {
                _repo.UpdatePackage(package);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(package);
            }
        }

        /*// GET: PackageController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PackageController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }*/
    }
}
