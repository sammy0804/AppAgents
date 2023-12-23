using AppAgentes.Interfaces;
using AppAgentes.Model.Enum;

namespace AppAgentes.Services;

public class AgentServices : IAgentServices
{
    public double CalcularMedia(TypeAgent typeAgent, double[] numbers)
    {
        var agent = AgentFactoryServices.CreateAgent(typeAgent);
        return agent.CalcularMedia(numbers);
    }

    public string GenerarEscalera(TypeAgent typeAgent, int n)
    {
        var agent = AgentFactoryServices.CreateAgent(typeAgent);
        return agent.GenerarEscalera(n);
    }
}