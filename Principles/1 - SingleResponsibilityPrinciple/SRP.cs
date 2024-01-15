namespace Principles.SingleResponsibilityPrinciple
{
    //SRP - Single Responsibility Principle (Princípio da Responsabilidade Única)

    #region Violation

    public class SRPViolation
    {
        //Classe com múltiplas responsabilidades
        public class EmailSender
        {
            public void SendEmail(string to, string subject, string message)
            {
                //Lógica para enviar o email
            }

            public void LogEmail(string to, string subject, string message)
            {
                //Lógica para registrar o email em um arquivo de log
            }
        }
    }

    #endregion

    #region Solution

    public class SRPSolution
    {
        //Separação das responsabilidades em duas classes distintas
        public class EmailSender
        {
            public void SendEmail(string to, string subject, string message)
            {
                //Lógica para enviar o email
            }
        }

        public class EmailLogger
        {
            public void LogEmail(string to, string subject, string message)
            {
                //Lógica para registrar o email em um arquivo de log
            }
        }
    }

    #endregion
}
