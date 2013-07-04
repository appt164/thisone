using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using DTO;

namespace mvc01.Controllers
{
    public class GameController : Controller
    {
        //
        // GET: /Game/

        public ActionResult Index()
        {
            PieceProvider pieceProvider = new PieceProvider();
            List<EntityPiece> pieces = pieceProvider.GetAllPieces();

            return View(pieces);
        }

        [HttpGet]
        public ActionResult UpdatePiece(int ID, int x, int y)
        {
            PieceProvider pieceProvider = new PieceProvider();
            pieceProvider.UpdatePosition(ID, x, y);
            return RedirectToAction("Index");
        }

        //
        // GET: /Game/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Game/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Game/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Game/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Game/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Game/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Game/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
