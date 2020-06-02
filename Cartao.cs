namespace aula08Abstracao
{
    public class Cartao : Pagamento
    {
        private string token = "0515625s5s5d45s54s15s";
        public string bandeira { get; set; }
        public int número { get; set; }
        public string titular { get; set; }
        public string cvv { get; set; }


        //validamos o token porque no program deu problema, a validaçao foi atribuida e nao foi utilizada e precisa utilizar
        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }
    }
}