namespace Principles.DependencyInversionPrinciple
{
    //DIP - Dependency Inversion Principle (Princípio da Inversão de Dependência)

    public class DIPViolation
    {
        //Classe de baixo nível
        public class LightBulb
        {
            public void TurnOn()
            {
                Console.WriteLine("Lâmpada acesa");
            }

            public void TurnOff()
            {
                Console.WriteLine("Lâmpada apagada");
            }
        }

        //Classe de alto nível que depende diretamente da classe de baixo nível
        public class Switch
        {
            private readonly LightBulb _lightBulb;

            public Switch()
            {
                _lightBulb = new LightBulb();
            }

            public void Operate()
            {
                _lightBulb.TurnOn();
                _lightBulb.TurnOff();
            }
        }
    }

    public class DIPSolution
    {
        //Interface que representa o dispositivo controlado
        public interface ILightBulb
        {
            void TurnOn();
            void TurnOff();
        }

        //Classe de baixo nível implementando a abstração
        public class LightBulb : ILightBulb
        {
            public void TurnOn()
            {
                Console.WriteLine("Lâmpada acesa");
            }

            public void TurnOff()
            {
                Console.WriteLine("Lâmpada apagada");
            }
        }

        //Classe de alto nível dependendo da abstração
        public class Switch
        {
            private readonly ILightBulb _device;

            public Switch(ILightBulb device)
            {
                _device = device;
            }

            public void Operate()
            {
                _device.TurnOn();
                _device.TurnOff();
            }
        }
    }
}
