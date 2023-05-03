namespace Projeto
{

    public class Pagamento
    {
        //propriedades
        public float Valor { get; set; }
        //data atual
        public DateTime Data { get; private set; } = DateTime.Now;
        //métodos
        public string Cancelar()
        {
            return "Operação cancelada.";
        }
    }

}