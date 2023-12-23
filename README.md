# AppAgents
Este proyecto implementa un sistema de agentes para calcular medias estadísticas y generar patrones de escaleras. Está desarrollado en .NET 6 y sigue los principios de la arquitectura limpia.

## Características
- Cálculo de diferentes tipos de medias (aritmética, armónica, mediana).
- Generación de patrones de escaleras con alineaciones variadas.
- Implementación siguiendo los principios de la arquitectura limpia.
  
## Requisitos
- .NET 6 SDK
  
## Instalación y Ejecución
- Clonar el repositorio:
```
git clone [URL del repositorio]
```
- Navegar al directorio del proyecto:
```
cd AppAgentes
```
- Construir y ejecutar el proyecto:
```
dotnet build
dotnet run
```

## Uso
A continuación se muestran ejemplos de cómo utilizar las funcionalidades principales del proyecto.

### Cálculo de Medias

Para calcular la media aritmética de una serie de números:

```csharp
var agente = new AgenteA();
double[] numeros = { 1, 2, 3, 4, 5 };
double media = agente.CalcularMedia(numeros);
```
### Generación de Escaleras
Para generar una escalera alineada a la derecha:
```csharp
var agente = new AgenteA();
string escalera = agente.GenerarEscalera(5);
```

## Pruebas
Para ejecutar las pruebas unitarias, navegue al directorio de pruebas y ejecute:
```
dotnet test
```
## Autor
Samara Rincón Montaña
