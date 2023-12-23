using AppAgentes.Interfaces;
using AppAgentes.Model.Enum;
using Microsoft.AspNetCore.Mvc;

namespace AppAgentes.Controllers;

[ApiController]
[Route("[controller]")]
public class AgentController : ControllerBase
{
    private IAgentServices _agentServices;

    public AgentController(IAgentServices agentServices)
    {
        _agentServices = agentServices;
    }

    [HttpPost( "{typeAgent}/calcularMedia")]
    public IActionResult CalcularMedia(int typeAgent, [FromBody] double[] numbers)
    {
        var isAgentDefined = Enum.IsDefined(typeof(TypeAgent), typeAgent);
        if (!isAgentDefined)
        {
            return BadRequest("El valor ingresado no corresponde a un agente");
        }
        var result = _agentServices.CalcularMedia((TypeAgent)typeAgent, numbers);
        return Ok(result);
    }

    [HttpGet("{typeAgent}/generarEscalera")]
    public IActionResult GenerarEscalera(int typeAgent, [FromQuery] int n)
    {
        var isAgentDefined = Enum.IsDefined(typeof(TypeAgent), typeAgent);
        if (!isAgentDefined)
        {
            return BadRequest("El valor ingresado no corresponde a un agente");
        }
        var result = _agentServices.GenerarEscalera((TypeAgent)typeAgent, n);
        return Ok(result);
    }
}