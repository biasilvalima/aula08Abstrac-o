using System;

namespace aula08Abstracao
{
    public class Boleto : Pagamento
    {
        public DateTime dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string condidoDeBarras { get; set; }

        public string RegistrarBoletoNoSistema(){
            return "Boleto registrado em nosso sistema";
        }
    }
}