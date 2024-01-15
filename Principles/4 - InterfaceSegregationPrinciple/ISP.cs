namespace Principles.InterfaceSegregationPrinciple
{
    //ISP - Interface Segregation Principle (Princípio da Segregação de Interface)

    #region Violation

    public class ISPViolation
    {
        //Interface base que representa uma forma
        public interface IShape
        {
            void Draw();
            void Rotate();
            void Resize();
        }

        //Implementação para círculo
        public class Circle : IShape
        {
            public void Draw()
            {
                //Lógica para desenhar um círculo
            }

            public void Rotate()
            {
                //Lógica para rotacionar um círculo
            }

            public void Resize()
            {
                //Lógica para redimensionar um círculo
            }
        }

        //Implementação para quadrado
        public class Square : IShape
        {
            public void Draw()
            {
                //Lógica para desenhar um quadrado
            }

            public void Rotate()
            {
                //Implementação vazia, pois não faz sentido rotacionar um quadrado
            }

            public void Resize()
            {
                //Lógica para redimensionar um quadrado
            }
        }
    }

    #endregion

    #region Solution

    public class ISPSolution
    {
        //Interface base que representa uma forma
        public interface IShape
        {
            void Draw();
        }

        //Interface base que representa a ação de rotacionar
        public interface IRotatable
        {
            void Rotate();
        }

        //Interface base que representa a ação de redimensionar
        public interface IResizable
        {
            void Resize();
        }

        public class Circle : IShape, IRotatable, IResizable
        {
            public void Draw()
            {
                //Lógica para desenhar um círculo
            }

            public void Rotate()
            {
                //Lógica para rotacionar o circulo
            }

            public void Resize()
            {
                //Lógica para redimensionar um círculo
            }
        }

        public class Square : IShape, IResizable
        {
            public void Draw()
            {
                //Lógica para desenhar um quadrado
            }

            public void Resize()
            {
                //Lógica para redimensionar um quadrado
            }
        }
    }

    #endregion
}
