using Cat_Pro.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cat_Pro.Controllers
{
    public class ProduitController : Controller
    {
        private readonly IProduitService _prodService;

        public ProduitController(IProduitService prodService)
        {
            _prodService = prodService;
        }
        public ActionResult<IEnumerable<Produit>> Index()
        {
            IEnumerable<Produit> liste = _prodService.GetAllProduct();
            return View(liste);
        }

        //Get
        public ActionResult Chercher(string motCle)
        {
            if (motCle == null)
            {
                ModelState.AddModelError("motCle", " Attention! il me faut un mot clé pour fonctionner");
            }
            if (ModelState.IsValid)
            {
                IEnumerable<Produit> liste = _prodService.GetProduitByMotCle(motCle);
                ViewBag.motCle = motCle;
                return View("Index", liste);
            }
            else
            {
                return View("Index", _prodService.GetAllProduct());
            }

        }
        [HttpGet]
        public ActionResult AjoutNProd()
        {
            Produit prod = new Produit();
            return View(prod);
        }

        [HttpPost]
        public ActionResult Save(Produit p)
        {
            if (ModelState.IsValid)
            {
                _prodService.Save(p);
                return RedirectToAction("Index");
            }
            return View("AjoutNProd");
        }

        [HttpGet] 
        public ActionResult Delete(int id)
        {
           
            _prodService.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet] 
        public ActionResult Edit(int id)
        {
           Produit p =  _prodService.GetOne(id);
            return View(p);
        }

        [HttpPost]
        public ActionResult Update(Produit p)
        {
            if (ModelState.IsValid)
            {
                _prodService.Update(p);
                return RedirectToAction("Index");
            }
            return View("Edit");
        }
    }
}
