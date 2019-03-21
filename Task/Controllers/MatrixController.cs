using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class MatrixController : Controller
    {
        // GET: Coordinate
        public ActionResult Index()
        {
            return View("CreateMatrix");
        }

        // GET: Coordinate/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Coordinate/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Coordinate/Create
        [HttpPost]
        public ActionResult Create(Matrix matrix)
        {
            if (matrix.X > matrix.Width || matrix.Y > matrix.Height)
            {
                ViewBag.Error= "The size of Matrix not mathes assigning the coordinates";
                return View("CreateMatrix");
            };
            matrix.mas = new int[matrix.Height, matrix.Width];
            for (int i = 0; i < matrix.mas.GetLength(0); i++)
                for (int j = 0; j < matrix.mas.GetLength(1); j++)
                    matrix.mas[i, j] = -1;

            matrix.mas = Fill(matrix.mas, matrix.X, matrix.Y, 0);
                ViewBag.Matrix = matrix.mas;
                ViewBag.X = matrix.X;
                ViewBag.Y = matrix.Y;
                return View("Result");
        }
        int[,] Fill(int[,] mas, int X, int Y, int step)
        {
            int Weig = mas.GetLength(0), Heigh = mas.GetLength(1);
            for (int i = 0; i < Weig; i++)
                for (int j = 0; j < Heigh; j++)
                {
                    if (X + i < Weig && Y + j < Heigh)
                        mas[X + i, Y + j] = i + j;
                    if (X + i < Weig && Y - j >= 0)
                        mas[X + i, Y - j] = i + j;
                    if (X - i >= 0 && Y + j < Heigh)
                        mas[X - i, Y + j] = i + j;
                    if (X - i >= 0 && Y - j >= 0)
                        mas[X - i, Y - j] = i + j;
                }
            return mas;
        }
        // GET: Coordinate/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Coordinate/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Coordinate/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Coordinate/Delete/5
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
