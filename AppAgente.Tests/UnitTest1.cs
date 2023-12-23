using AppAgentes.Entity;

namespace AppAgente.Tests;

public class UnitTest1
{
    [Fact]
    public void CalcularMedia_DebeRetornarValorCorrecto()
    {
        var agente = new AgentA();
        var numeros = new double[] { 1, 2, 3, 4, 5 };
        
        var resultado = agente.CalcularMedia(numeros);
        
        Assert.Equal(3, resultado);
    }
    
    [Fact]
    public void CalcularMedia_CuandoListaVacia_DebeRetornarCero()
    {
        // Arrange
        var agente = new AgentA();
        var numeros = new double[] { };

        // Act & Assert
        Assert.Throws<InvalidOperationException>(() => agente.CalcularMedia(numeros));
    }
    
    [Fact]
    public void GenerarEscalera_ConAlturaValida_DebeRetornarEscaleraCorrecta()
    {
        // Arrange
        var agente = new AgentA();
        var escaleraEsperada = "  #\r\n ##\r\n###\r\n";

        // Act
        var resultado = agente.GenerarEscalera(3);

        // Assert
        Assert.Equal(escaleraEsperada, resultado);
    }

    [Fact]
    public void GenerarEscalera_ConAlturaCero_DebeRetornarVacio()
    {
        // Arrange
        var agente = new AgentA();

        // Act
        var resultado = agente.GenerarEscalera(0);

        // Assert
        Assert.Empty(resultado);
    }
    
    [Fact]
    public void GenerarEscalera_ConValorFueraDeRango_DebeLanzarExcepcion()
    {
        // Arrange
        var agente = new AgentA();
        var valorFueraDeRango = 101;

        var excepcion = Assert.Throws<ArgumentOutOfRangeException>(() => agente.GenerarEscalera(valorFueraDeRango));
        Assert.Equal("El valor de "+valorFueraDeRango+" debe estar entre 1 y 100.", excepcion.ParamName);
    }
}