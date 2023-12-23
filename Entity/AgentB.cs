using System.Text;
using AppAgentes.Interfaces;

namespace AppAgentes.Entity;

public class AgentB : IAgent
{
    public double CalcularMedia(double[] numbers)
    {
        if (numbers.Length==0)
        {
            throw new InvalidOperationException("No se puede dividir entre cero");
        }
        return numbers.Length / numbers.Sum(x => 1 / x);
    }

    public string GenerarEscalera(int n)
    {
        var escalera = new StringBuilder();
        
        if (n < 0 || n > 100)
        {
            throw new ArgumentOutOfRangeException( "El valor de "+n+" debe estar entre 1 y 100.");
        }
        
        for (int i = n; i > 0; i--)
        {
            escalera.AppendLine(new String(' ', n - i) + new String('#', i));
        }
        return escalera.ToString();
    }
}