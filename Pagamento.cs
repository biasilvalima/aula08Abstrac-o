using System;

namespace aula08Abstracao
{
    public class Pagamento
    {
       public DateTime data { get; set; }
        public float valor { get; set; }
        public string Pagar(float valor){
            return "Pagamento efetuado";
        }

        public string Cancelar(){
            return "pagamento cancelado";
        }
    }
}