using Jogos.DAO;
using Jogos_26._1.Models;
using Jogos_28._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Jogos_26._1.DAO
{
    public class CategoriaDAO : PadraoDAO<CategoriaViewModel>
    {
        protected override SqlParameter[] CriaParametros(CategoriaViewModel model)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("id", model.id),
                new SqlParameter("descricao", model.descricao)
            };

            return parameters;
        }

        protected override CategoriaViewModel MontaModel(DataRow registro)
        {
            CategoriaViewModel c = new CategoriaViewModel()
            {
                id = Convert.ToInt32(registro["id"]),
                descricao = registro["descricao"].ToString()
            };

            return c;
        }

        protected override void SetTabela()
        {
            Tabela = "Categorias";
        }

    }
}
