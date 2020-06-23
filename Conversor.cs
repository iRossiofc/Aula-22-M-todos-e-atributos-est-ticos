namespace Aula22MetodosEAtributosEstaticos
{
    public static class Conversor
    {
        public static float cotacaoDolar = 5.29f;
        public static float cotacaoEuro = 5.92f;

        /// <summary>
        /// converter dolar para real
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> o valor em real da quantidade de dolar</returns>
        public static float ConverterDolarReal(float valor){
            return valor * cotacaoDolar;
        }
        
        /// <summary>
        /// converter real para dolar
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> o valor em dolar da quantidade de real</returns>
        public static float ConverterRealDolar(float valor){
            return valor / cotacaoDolar;
        }
        
        /// <summary>
        /// converter euro para real
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> o valor em real da quantidade de euro</returns>
        public static float ConverterEuroReal(float valor){
            return valor * cotacaoEuro;
        }

        /// <summary>
        /// converter real para euro
        /// </summary>
        /// <param name="valor"></param>
        /// <returns> o valor em euro da quantidade de real</returns>
        public static float ConverterRealEuro(float valor){
            return valor / cotacaoEuro;
        }


    }
}