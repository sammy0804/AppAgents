using System.Text;
using AppAgentes.Interfaces;

namespace AppAgentes.Entity;

public class AgentC : IAgent
{
    public double CalcularMedia(double[] numbers)
    {
        if (numbers.Length==0)
        {
            throw new InvalidOperationException("No se puede dividir entre cero");
        }
        
        Array.Sort(numbers);
        int size = numbers.Length;
        int mid = size / 2;
        return (size % 2 != 0) ? numbers[mid] : (numbers[mid] + numbers[mid - 1]) / 2;
    }

    public string GenerarEscalera(int n)
    {
        var escalera = new StringBuilder();
        
        if (n < 0 || n > 100)
        {
            throw new ArgumentOutOfRangeException( "El valor de "+n+" debe estar entre 1 y 100.");
        }
        
        for (int i = 1; i <= n; i++)
        {
            escalera.AppendLine(new String(' ', n - i) + new String('#', n+2 * (i - 1)));
        }

        for (int j = n-1; j > 0 ; j--)
        {
            escalera.AppendLine(new String(' ', n - j) + new String('#', n+2 * (j - 1)));
        }
        
        return escalera.ToString();
    }
}