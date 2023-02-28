using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace ConsoleApp1.PruebasUnitarias
{
    [TestClass]
    public class FiguraTest
    {
        
            [TestMethod]
            public void CalcularAreaCirculo_ConRadioCero_DebeDevolverCero()
            {
                // Arreglar
                Figura figura = new Figura();
                double radio = 0;
                double expected = 0;

                // Act
                double actual = figura.CalcularAreaCirculo(radio);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void CalcularAreaCirculo_ConRadioUno_DebeDevolverPi()
            {
                // Arreglar
                Figura figura = new Figura();
                double radio = 1;
                double expected = Math.PI;

                // Actuar
                double actual = figura.CalcularAreaCirculo(radio);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void CalcularAreaRectangulo_ConBaseCero_DebeDevolverCero()
            {
                // Arreglar
                Figura figura = new Figura();
                double baseRectangulo = 0;
                double alturaRectangulo = 5;
                double expected = 0;

                // Actuar
                double actual = figura.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void CalcularAreaRectangulo_ConAlturaCero_DebeDevolverCero()
            {
                // Arreglar
                Figura figura = new Figura();
                double baseRectangulo = 5;
                double alturaRectangulo = 0;
                double expected = 0;

                // Actuar
                double actual = figura.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);

                // Assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void CalcularAreaRectangulo_ConBaseYAlturaIguales_DebeDevolverValorCorrecto()
            {
                // Arreglar
                Figura figura = new Figura();
                double baseRectangulo = 5;
                double alturaRectangulo = 5;
                double expected = 25;

                // Actuar
                double actual = figura.CalcularAreaRectangulo(baseRectangulo, alturaRectangulo);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
}
