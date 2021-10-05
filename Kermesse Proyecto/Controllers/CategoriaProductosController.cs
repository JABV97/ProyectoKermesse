using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kermesse_Proyecto.Models;

namespace Kermesse_Proyecto.Controllers
{
    public class CategoriaProductosController : Controller
    {
        private BDKermesseEntities db = new BDKermesseEntities();

        // GET: CategoriaProductos
        public ActionResult Index()
        {
            return View(db.CategoriaProducto.ToList());
        }

        // GET: CategoriaProductos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProducto);
        }

        // GET: CategoriaProductos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaProductos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCatProd,nombre,descripcion,estado")] CategoriaProducto categoriaProducto)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaProducto.Add(categoriaProducto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaProducto);
        }

        // GET: CategoriaProductos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProducto);
        }

        // POST: CategoriaProductos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCatProd,nombre,descripcion,estado")] CategoriaProducto categoriaProducto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaProducto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaProducto);
        }

        // GET: CategoriaProductos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            if (categoriaProducto == null)
            {
                return HttpNotFound();
            }
            return View(categoriaProducto);
        }

        // POST: CategoriaProductos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaProducto categoriaProducto = db.CategoriaProducto.Find(id);
            db.CategoriaProducto.Remove(categoriaProducto);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
