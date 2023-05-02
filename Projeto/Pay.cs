using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_em_grupo
{
   
    public class Pagamento
    {
        public float Valor;
        private DateTime Data = DateTime.Now;

        public string Cancelar()
        {
            return "Cancelando operação";
        }
    }

}