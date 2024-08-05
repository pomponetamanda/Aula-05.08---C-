using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculadora
{

    public int numero1;
    public int numero2;
    public float resultado;

    public Calculadora(int numero1, int numero2, float resultado)
    {
        this.numero1 = numero1;
        this.numero2 = numero2;
    }

    public void Adicao()
    {
        resultado = numero1 + numero2;
        Console.WriteLine("O resultado da soma é: " + resultado);
    };

    public void Subtracao() 
    {
        resultado = numero1 - numero2;
        Console.WriteLine("O resultado da subtração é: " + resultado);
    }

    public void Multiplicacao()
    {
        resultado = numero1 * numero2;
        Console.WriteLine("O resultado da mulktiplicação é: " + resultado);
    }

    public void Divisao()
    {
        resultado = numero1 / numero2;
        Console.WriteLine("O resultado da divisão é: " + resultado);
    }
}