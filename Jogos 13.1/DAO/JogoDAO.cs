using Jogos.ViewModel;
using Jogos_28._1.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.DAO
{
    public class JogoDAO : PadraoDAO<JogoViewModel>
    {

        protected override SqlParameter[] CriaParametros(JogoViewModel model)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", model.id);
            parametros[1] = new SqlParameter("descricao", model.descricao);
            if (model.valorLocacao != null)
                parametros[2] = new SqlParameter("valor_locacao", model.valorLocacao);
            else
                parametros[2] = new SqlParameter("valor_locacao", DBNull.Value);
            parametros[3] = new SqlParameter("data_aquisicao", model.dataAquisicao);
            parametros[4] = new SqlParameter("categoriaID", model.categoriaID);

            return parametros;
        }

        protected override JogoViewModel MontaModel(DataRow registro)
        {
            JogoViewModel jogo = new JogoViewModel();

            jogo.id = Convert.ToInt32(registro["id"]);
            jogo.descricao = registro["descricao"].ToString();
            jogo.dataAquisicao = Convert.ToDateTime(registro["data_aquisicao"]);

            if (registro["valor_locacao"] != DBNull.Value)
                jogo.valorLocacao = Convert.ToDouble(registro["valor_locacao"]);

            jogo.categoriaID = Convert.ToInt32(registro["categoriaID"]);

            return jogo;
        }

        protected override void SetTabela()
        {
            Tabela = "jogos";
        }
    }
}
