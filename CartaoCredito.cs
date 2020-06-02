namespace aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        public void AumentarLimite(float acrescimo){
            limite = limite + acrescimo;
        }

        public string BloquearCartaoDeCredito(){
            return "Cartão de Crédito bloqueado";
        }
    }
}