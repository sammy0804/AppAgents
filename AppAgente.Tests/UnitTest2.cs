using AppAgentes.Entity;

namespace AppAgente.Tests;

public class UnitTest2
{
    [Fact]
    public void CalcularMediaArmonica_DebeRetornarValorCorrecto()
    {
        var agente = new AgentB();
        var numeros = new double[] { 1, 2, 3, 4, 5, 6, 7};
        
        var resultado = agente.CalcularMedia(numeros);
        var num = 2.6997245179063363;
        
        Assert.Equal(num, resultado);
    }
    
    [Fact]
    public void CalcularMediaArmonia_CuandoListaVacia_DebeLanzarException()
    {
        var agente = new AgentB();
        var numeros = new double[] { };

        var exception = Assert.Throws<InvalidOperationException>(() => agente.CalcularMedia(numeros));
        Assert.Equal("No se puede dividir entre cero", exception.Message);
    }
    
    [Fact]
    public void GenerarEscalera_ConAlturaValida_DebeRetornarEscaleraCorrecta()
    {
        // Arrange
        var agente = new AgentB();
        var escaleraEsperada = "###\r\n ##\r\n  #\r\n";

        // Act
        var resultado = agente.GenerarEscalera(3);

        // Assert
        Assert.Equal(escaleraEsperada, resultado);
    }

    [Fact]
    public void GenerarEscalera_ConAlturaCero_DebeRetornarVacio()
    {
        // Arrange
        var agente = new AgentB();

        // Act
        var resultado = agente.GenerarEscalera(0);

        // Assert
        Assert.Empty(resultado);
    }
    
    [Fact]
    public void GenerarEscalera_ConValorFueraDeRango_DebeLanzarExcepcion()
    {
        // Arrange
        var agente = new AgentB();
        var valorFueraDeRango = 101;

        var excepcion = Assert.Throws<ArgumentOutOfRangeException>(() => agente.GenerarEscalera(valorFueraDeRango));
        Assert.Equal("El valor de "+valorFueraDeRango+" debe estar entre 1 y 100.", excepcion.ParamName);
    }
}