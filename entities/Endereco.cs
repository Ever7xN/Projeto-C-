namespace Mentoria1
{
    public class Endereco
    {
        public string Logradouro{get; private set; }
        public string Cidade { get; private set; }
        public string  Estado { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }

        public Endereco(string logradouro, string cidade, string estado, string cep, string bairro)
        {
            Logradouro = logradouro.ValidaStringVazia();
            Cidade = cidade.ValidaStringVazia();
            Estado = estado.ValidaStringVazia();
            CEP = cep.ValidaStringVazia();
            Bairro = bairro.ValidaStringVazia();
        }
    }

}