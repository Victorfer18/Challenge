using Fiap.Aula03.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.ViewModels
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }

        public IList<Produto> Lista { get; set; }
    }
}
