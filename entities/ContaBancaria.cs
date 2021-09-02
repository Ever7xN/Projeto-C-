using System;

namespace Mentoria1
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public int DigitoVerificador { get; private set; }
        public decimal Saldo { get; protected set; }
        public DateTime ? DataAbertura { get; private set; }
        public DateTime ? DataEncerramento { get; private set; }
        public string Senha { get; private set; }
        public Cliente Cliente { get; private set; }
        public SituacaoContaEnum Situacao { get; private set; }

        public ContaBancaria(Cliente cliente)
        {
            Random random = new Random();
            NumeroConta = random.Next(100000, 9000000);
            DigitoVerificador = random.Next(0, 9);

            Situacao = SituacaoContaEnum.Criada;

            Cliente = cliente ?? throw new Exception("Informe os dados!");
        }
    }
}