using Jogos.DAO;
using Jogos.ViewModel;
using Jogos_22._1.Models;
using Jogos_26._1.DAO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

namespace Jogos_22._1.Controllers
{
    public class JogoController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                return View(dao.Listagem());
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Create()
        {
            try
            {
                ViewBag.Operacao = "I";

                JogoViewModel jogo = new JogoViewModel();
                jogo.dataAquisicao = DateTime.Now;
                jogo.id = new JogoDAO().ProximoId();

                PreparaListaCategoriasParaCombo();

                return View("Form", jogo);
            }
            catch(Exception erro) {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Salvar(JogoViewModel jogo, string Operacao)
        {
            try
            {
                ValidaDados(jogo, Operacao);
                if (ModelState.IsValid == false)
                {
                    ViewBag.Operacao = Operacao;

                    PreparaListaCategoriasParaCombo();

                    return View("Form", jogo);
                }
                else
                {
                    JogoDAO dao = new JogoDAO();
                    if (Operacao == "I")
                        dao.Insert(jogo);
                    else
                        dao.Update(jogo);

                    return RedirectToAction("index");
                }
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Editar(int id)
        {
            try
            {
                ViewBag.Operacao = "A";

                JogoDAO dao = new JogoDAO();
                JogoViewModel jogo = dao.Consulta(id);

                PreparaListaCategoriasParaCombo();

                if (jogo == null)
                    return RedirectToAction("index");
                else
                    return View("Form", jogo);
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                JogoDAO dao = new JogoDAO();
                dao.Delete(id);
                return RedirectToAction("index");
            }
            catch (Exception erro)
            {
                return View("Error", new ErrorViewModel(erro.ToString()));
            }
        }

        public void ValidaDados(JogoViewModel jogo, String operacao)
        {
            ModelState.Clear();

            JogoDAO dao = new JogoDAO();
            
            if (operacao == "I" && dao.Consulta(jogo.id) != null)
                ModelState.AddModelError("id", "Código já em uso!");

            if (operacao == "A" && dao.Consulta(jogo.id) == null)
                ModelState.AddModelError("id", "Jogo não existe!");

            if (jogo.id < 0)
                ModelState.AddModelError("id", "Id inválido!");

            if (string.IsNullOrEmpty(jogo.descricao))
                ModelState.AddModelError("descricao", "Preencha a decrição!");

            if (jogo.valorLocacao < 0)
                ModelState.AddModelError("valorLocacao", "Valor inválido!");

            if (jogo.dataAquisicao > DateTime.Now)
                ModelState.AddModelError("dataAquisicao", "Data não pode ser maior do que hoje!");

            if (jogo.categoriaID <= 0)
                ModelState.AddModelError("categoriaID", "Categoria inválida!");
        }

        private void PreparaListaCategoriasParaCombo()
        {
            CategoriaDAO dao = new CategoriaDAO();
            var categorias = dao.Listagem();
            List<SelectListItem> listaCategorias = new List<SelectListItem>();

            listaCategorias.Add(new SelectListItem("Selecione uma...", "0"));
            foreach (var categoria in categorias)
            {
                SelectListItem item = new SelectListItem(categoria.descricao, categoria.id.ToString());
                listaCategorias.Add(item);
            }
            ViewBag.Categorias = listaCategorias;
        }

    }
}
