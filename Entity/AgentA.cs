using System.Text;
using AppAgentes.Interfaces;

namespace AppAgentes.Entity;

public class AgentA:IAgent
{
    public double CalcularMedia(double[] numbers)
    {
        return numbers.Average();
    }

    public string GenerarEscalera(int n)
    {
        var escalera = new StringBuilder();
        
        if (n < 0 || n > 100)
        {
            throw new ArgumentOutOfRangeException("El valor de "+n+" debe estar entre 1 y 100.");
        }

        for (int i = 1; i <= n; i++)
        {
            escalera.AppendLine(new String(' ', n - i) + new String('#', i));
        }
        
        return escalera.ToString();
    }
}