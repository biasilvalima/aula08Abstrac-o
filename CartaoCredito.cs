namespace aula08Abstracao
{
    public class CartaoCredito : Cartao
    {
        public float limite { get; set; }

        //demos outra funçao ao void no calculo direto do limete atual mais o acrescimo
        public void AumentarLimite(float acrescimo){
            limite = limite + acrescimo;
        }

        public string BloquearCartaoDeCredito(){
            return "Cartão de Crédito bloqueado";
        }
    }
}