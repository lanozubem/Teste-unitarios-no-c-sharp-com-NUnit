namespace calculos;
public class Calculadora
{
    public int Soma(int operator1, int operator2) => operator1 + operator2;
    public int Subtracao(int operator1, int operator2) => operator1 - operator2;
    public int Multiplicacao(int operator1, int operator2) => operator1 * operator2;
    public int Divisao(int dividendo, int divisor) => dividendo / divisor;
    public (int quociente, int resto) RestoDivisao(int dividendo, int divisor) => (dividendo / divisor, dividendo % divisor);
}
