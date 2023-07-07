using Jogos_28._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogos.ViewModel
{
    public class JogoViewModel : PadraoViewModel
    {
        public string descricao { get; set; }
        public double? valorLocacao { get; set; }
        public DateTime dataAquisicao { get; set; }
        public int categoriaID { get; set; }
    }
}
