using Fiap.Aula03.Web.Models;
using Fiap.Aula03.Web.Persistencias;
using Fiap.Aula03.Web.Repositories;
using Fiap.Aula03.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Controllers
{
    public class ProdutoController : Controller
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Produto produto)
        {
            _produtoRepository.Cadastrar(produto);
            _produtoRepository.Salvar();
            TempData["msg"] = "Produto cadastrado";
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            var produtos = _produtoRepository.Listar();
            var viewModel = new ProdutoViewModel()
            {
                Lista = produtos
            };
            return View(viewModel);
        }
    }
}
