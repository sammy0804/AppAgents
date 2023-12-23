using AppAgentes.Entity;
using AppAgentes.Interfaces;
using AppAgentes.Model.Enum;

namespace AppAgentes.Services;

public class AgentFactoryServices
{
    public static IAgent CreateAgent(TypeAgent typeAgent)
    {
        switch (typeAgent)
        {
            case TypeAgent.AgenteA:
                return new AgentA();
            case TypeAgent.AgenteB:
                return new AgentB();
            case TypeAgent.AgenteC:
                return new AgentC();
            default:
                throw new ArgumentException("Tipo de agente no válido");
        }
    }
}