using System;

using Xunit;

using Calculadora;

namespace Calculadora.Tests
{
    public class CalculadoraTests
    {

        [Fact]
        public void TestSoma()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.somar(2, 3);
            Assert.Equal(5, resultado);
        }

        public void TestSubtrair()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.subtrair(3, 2);
            Assert.Equal(1, resultado);
        }

        public void TestMultiplicar()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.multiplicar(2, 3);
            Assert.Equal(6, resultado);
        }

        public void TestDividir()
        {
            var calculadora = new Calculadora();
            var resultado = calculadora.dividir(4, 2);
            Assert.Equal(2, resultado);
        }
    }   
}     