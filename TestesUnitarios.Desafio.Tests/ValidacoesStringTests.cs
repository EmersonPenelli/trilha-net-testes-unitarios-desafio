using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
    {
        //TODO: Corrigir a variável "texto" e "resultadoEsperado" da seção Arrange

        // Arrange
        var texto = "dev";
        var resultadoEsperado = 3;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveContemAPalavraAvanadeNoTexto()
    {
        // Arrange
        var texto = "Avanade Do What Matters";
        var textoProcurado = "Avanade";

        //TODO: Corrigir a chamada do método "ContemCaractere" da seção Act
        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.True com base no retorno da chamada ao método
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraDesistenciaNoTexto()
    {
        // Arrange
        var texto = "Não é o fim, mas sim o ponto de partida para novas oportunidades.";
        var textoProcurado = "desistência";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        //TODO: Corrigir o Assert.False com base no retorno da chamada ao método
        Assert.False(resultado);
    }

    //TODO: Corrigir a anotação [Fact]
    [Fact]
    public void TextoDeveTerminarComAPalavraPersistencia()
    {
        //TODO: Corrigir a variável "textoProcurado" seção Arrange

        // Arrange
        var texto = "Paciencia, Resiliência e Persistência";
        var textoProcurado = "Persistência";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }
}
