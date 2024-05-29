using ProjetoCalculadoraTDD;

namespace CalculadoraTest
{
    public class Tests
    {
        private Calculadora _calculadora;

        public Tests()
        {
            _calculadora = new Calculadora(DateTime.Now);
            return;
        }

        [Theory]
        [InlineData(5, 2)]
        public void SomarXYTest(int x, int y)
        {
            //Act
            var result = _calculadora.Somar(x, y);

            //Assert
            Assert.Equal(7, result);
        }

        [Theory]
        [InlineData(5, 2, 7)]
        [InlineData(8, 2, 10)]
        public void SomarXYResultTest(int x, int y, int result)
        {
            //Act & Assert
            Assert.Equal(result, _calculadora.Somar(x, y));
        }

        [Theory]
        [InlineData(5, 2)]
        public void SubtrairXYTest(int x, int y)
        {
            //Act
            var result = _calculadora.Subtrair(x, y);

            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(8, 2, 6)]
        public void SubtrairXYResultTest(int x, int y, int result)
        {
            //Act & Assert
            Assert.Equal(result, _calculadora.Subtrair(x, y));
        }

        [Theory]
        [InlineData(5, 2)]
        public void MultiplicarXYTest(int x, int y)
        {
            //Act
            var result = _calculadora.Multiplicar(x, y);

            //Assert
            Assert.Equal(10, result);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(8, 2, 16)]
        public void MultiplicarXYResultTest(int x, int y, int result)
        {
            //Act & Assert
            Assert.Equal(result, _calculadora.Multiplicar(x, y));
        }

        [Theory]
        [InlineData(6, 2)]
        public void DividirXYTest(int x, int y)
        {
            //Act
            var result = _calculadora.Dividir(x, y);

            //Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(8, 2, 4)]
        public void DividirXYResultTest(int x, int y, int result)
        {
            //Act & Assert
            Assert.Equal(result, _calculadora.Dividir(x, y));
        }

        [Fact]
        public void Dividir0Test()
        {
            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(8, 0));
        }

        [Fact]
        public void HistoricoTest()
        {
            _calculadora.Somar(31, 2);
            _calculadora.Somar(81, 1);
            _calculadora.Somar(5, 1);
            _calculadora.Somar(10, 1);
            _calculadora.Somar(51, 1);
            var list = _calculadora.Historico();
            Assert.NotEmpty(list);
            Assert.Equal(3, list.Count);
        }
    }
}