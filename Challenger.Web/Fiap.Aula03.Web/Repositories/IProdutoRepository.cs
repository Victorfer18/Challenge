using Fiap.Aula03.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Repositories
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);

        IList<Produto> Listar();
        void Salvar();
    }
}
