using Jogos_26._1.DAO;
using Jogos_26._1.Models;
using Jogos_28._1.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Jogos_13._1.Controllers
{
    public class CategoriaController : PadraoController<CategoriaViewModel>
    {
        public CategoriaController()
        {
            DAO = new CategoriaDAO();
            GeraProximoId = true;
        }

        protected override void ValidaDados(CategoriaViewModel model, string operacao)
        {
            base.ValidaDados(model, operacao);
            if (string.IsNullOrEmpty(model.descricao))
                ModelState.AddModelError("descricao", "Preencha a descrição!");
        }

    }
}
