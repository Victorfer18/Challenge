using Fiap.Aula03.Web.Models;
using Fiap.Aula03.Web.Persistencias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private MercadoContext _context;

        public ProdutoRepository(MercadoContext context)
        {
            _context = context;
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public IList<Produto> Listar()
        {
            return _context.Produtos.ToList();
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
