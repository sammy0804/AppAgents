using AppAgentes.Entity;

namespace AppAgente.Tests;

public class UnitTest3
{
    [Fact]
    public void CalcularMediana_DebeRetornarValorCorrecto()
    {
        var agente = new AgentC();
        var numeros = new double[] { 1, 2, 3, 5, 6, 7};
        
        var resultado = agente.CalcularMedia(numeros);
        var num = 4;
        
        Assert.Equal(num, resultado);
    }
    
    [Fact]
    public void CalcularMediana_CuandoListaVacia_DebeLanzarException()
    {
        var agente = new AgentC();
        var numeros = new double[] { };

        var exception = Assert.Throws<InvalidOperationException>(() => agente.CalcularMedia(numeros));
        Assert.Equal("No se puede dividir entre cero", exception.Message);
    }
    
    [Fact]
    public void GenerarEscalera_ConAlturaValida_DebeRetornarEscaleraCorrecta()
    {
        // Arrange
        var agente = new AgentC();
        var escaleraEsperada = "  ###\r\n #####\r\n#######\r\n #####\r\n  ###\r\n";

        // Act
        var resultado = agente.GenerarEscalera(3);

        // Assert
        Assert.Equal(escaleraEsperada, resultado);
    }

    [Fact]
    public void GenerarEscalera_ConAlturaCero_DebeRetornarVacio()
    {
        // Arrange
        var agente = new AgentC();

        // Act
        var resultado = agente.GenerarEscalera(0);

        // Assert
        Assert.Empty(resultado);
    }
    
    [Fact]
    public void GenerarEscalera_ConValorFueraDeRango_DebeLanzarExcepcion()
    {
        // Arrange
        var agente = new AgentC();
        var valorFueraDeRango = 101;

        var excepcion = Assert.Throws<ArgumentOutOfRangeException>(() => agente.GenerarEscalera(valorFueraDeRango));
        Assert.Equal("El valor de "+valorFueraDeRango+" debe estar entre 1 y 100.", excepcion.ParamName);
    }
}