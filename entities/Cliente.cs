namespace Mentoria1
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get;  private set; } 
        public string RG { get;  private set; }
        public Endereco Endereco { get; private set; }

        public Cliente (string nome, string cpf, string rg, Endereco endereco) 
        {
            Nome = nome.ValidaStringVazia();
            CPF = cpf.ValidaStringVazia();
            RG = rg.ValidaStringVazia();
            Endereco = endereco ?? throw new System.Exception("Informe os dados!");
        }
    }
}