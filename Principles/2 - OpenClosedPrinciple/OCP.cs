namespace Principles.OpenClosedPrinciple
{
    //OCP - Open/Closed Principle (Princípio Aberto/Fechado)

    #region Violation

    public class OCPViolation
    {
        //Classe que representa uma forma
        private class Shape
        {
            public string Type { get; set; }

            public double CalculateArea()
            {
                double area = 0;

                if (Type == "Circle")
                {
                    Console.WriteLine("Calculando a área do círculo");
                }
                else if (Type == "Square")
                {
                    Console.WriteLine("Calculando a área do quadrado");
                }
                else
                {
                    Console.WriteLine("Tipo de forma inválido");
                }

                return area;
            }
        }

        public static void Example()
        {
            var shapes = new List<Shape>
            {
               new() { Type = "Circle" },
               new() { Type = "Square" },
               new() { Type = "Rectangle" },
            };

            foreach (var shape in shapes)
                shape.CalculateArea();

            //Para poder calcular a area do retangulo, teriamos de alterar a classe base
        }
    }

    #endregion

    #region Solution

    public class OCPSolution
    {
        //Classe base que representa uma forma
        private abstract class Shape
        {
            public abstract void CalculateArea();
        }

        //Classe derivada representando um círculo
        private class Circle : Shape
        {
            public override void CalculateArea()
            {
                Console.WriteLine("Calculando a área do circulo");
            }
        }

        //Classe derivada representando um quadrado
        private class Square : Shape
        {
            public override void CalculateArea()
            {
                Console.WriteLine("Calculando a área do quadrado");
            }
        }

        //Classe derivada representando um retângulo
        private class Rectangle : Shape
        {
            public override void CalculateArea()
            {
                Console.WriteLine("Calculando a área do retangulo");
            }
        }

        public static void Example()
        {
            var shapes = new List<Shape>
            {
               new Circle(),
               new Square(),
               new Rectangle(),
            };

            foreach (var shape in shapes)
                shape.CalculateArea();
        }
    }

    #endregion
}
