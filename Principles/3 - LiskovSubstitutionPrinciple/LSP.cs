namespace Principles.LiskovSubstitutionPrinciple
{
    //LSP - Liskov Substitution Principle (Princípio da Substituição de Liskov)

    #region Violation

    public class LSPViolation
    {
        //Classe base que representa um retângulo
        public class Rectangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int Area()
            {
                return Width * Height;
            }
        }

        //Classe derivada que representa um quadrado
        public class Square : Rectangle
        {
            //Todos os lados de um quadrado são iguais
            public override int Width
            {
                set { base.Width = base.Height = value; }
            }

            public override int Height
            {
                set { base.Width = base.Height = value; }
            }
        }

        public static void Example()
        {
            Rectangle rectangle = new Square
            {
                Width = 5,
                Height = 10
            };

            //Espera-se 50, mas resultará em 100 (Square)
            Console.WriteLine(rectangle.Area()); 
        }
    }

    #endregion

    #region Solution

    public class LSPSolution
    {
        //Interface base que representa uma forma
        public interface IShape
        {
            int Area();
        }

        //Implementação para retângulo
        public class Rectangle : IShape
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int Area()
            {
                return Width * Height;
            }
        }

        //Implementação para quadrado
        public class Square : IShape
        {
            public int Side { get; set; }

            public int Area()
            {
                return Side * Side;
            }
        }

        public static void Example()
        {
            var square = new Square
            {
                Side = 5
            };

            Console.WriteLine(square.Area());
        }
    }

    #endregion
}
