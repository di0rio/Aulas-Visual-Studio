using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoMVC.Models;

namespace ProjetoMVC.Controllers
{
	public class ProdutosController : Controller
	{
		// GET: ProdutosController
		public ActionResult Index()
		{
			List<Produtos> lista = new List<Produtos>();
			lista.Add(new Produtos(1, "Cadeira", 100.00));
			lista.Add(new Produtos(2, "Mesa", 200.00));
			lista.Add(new Produtos(3, "Geladeira", 300.00));
			lista.Add(new Produtos(4, "Fogão", 400.00));
			lista.Add(new Produtos(5, "TV", 500.00));
			lista.Add(new Produtos(6, "Sofá", 600.00));
			lista.Add(new Produtos(7, "Cama", 700.00));
			lista.Add(new Produtos(8, "Guarda-roupa", 800.00));
			lista.Add(new Produtos(9, "Armário", 900.00));
			lista.Add(new Produtos(10, "Estante", 1000.00));
			return View(lista);
		}

		// GET: ProdutosController/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: ProdutosController/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: ProdutosController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ProdutosController/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: ProdutosController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: ProdutosController/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: ProdutosController/Delete/5
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
		}
	}
}
