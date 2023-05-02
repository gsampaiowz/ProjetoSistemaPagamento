namespace Projeto
{

    public class Pagamento
    {
        public float Valor;
        private DateTime Data = DateTime.Now;

        public string Cancelar()
        {
            return "Pagamento cancelado.";
        }
    }

}