using System;

namespace Mentoria1
{
    public static class Validacao
    {
        public static string ValidaStringVazia(this string texto)
        {
            return string.IsNullOrWhiteSpace(texto) ? throw new Exception("Informe os dados!"): texto;
        }
    }
}