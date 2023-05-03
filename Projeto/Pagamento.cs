namespace Projeto
{

    public class Pagamento
    {
        public float Valor { get; set; }
        public DateTime Data { get; private set; } = DateTime.Now;

        public string Cancelar()
        {
            return "Operação cancelada.";
        }
    }

}