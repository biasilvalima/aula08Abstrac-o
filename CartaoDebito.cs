namespace aula08Abstracao
{
    public class CartaoDebito : Cartao
    {
        public float  saldo { get; set; }
        public string Transferir(float valor){
            return  $" R$ (Valor) transferido de sua conta";
        }
        public string PagarTitulo(){
            return "Titulo pago com cartão de debito";
        }
    }
}