class Program
{
    static void Main(string[] args)
    {
        Calculadora minhacalculadora = new Calculadora(20, 2);

        minhacalculadora.Adicao();
        minhacalculadora.Subtracao();
        minhacalculadora.Multiplicacao();
        minhacalculadora.Divisao();
    }
}