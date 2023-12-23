using AppAgentes.Model.Enum;

namespace AppAgentes.Interfaces;

public interface IAgentServices
{
    double CalcularMedia(TypeAgent typeAgent, double[] numbers);
    string GenerarEscalera(TypeAgent typeAgent, int n);
}