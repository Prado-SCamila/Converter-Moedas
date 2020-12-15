namespace Converter_Moedas.classes
{
    public static  class Conversor
    {
        private static float CotacaoDolar = 5.24f;

        private static float CotacaoLibra = 6.82f;

        public static float RealParaDolar (float valorRS){
            return valorRS / CotacaoDolar;
        }

        public static float DolarParaReal (float valorRS){
            return CotacaoDolar * valorRS;
        }

        public static float LibraParaReal (float valorRS){
            return CotacaoLibra * valorRS;
        }
        
        public static float RealParaLibra(float valorRS){
            return valorRS / CotacaoLibra;
        }
    }
}