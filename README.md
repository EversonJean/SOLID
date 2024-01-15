Princípios de SOLID implementados em C#:

Princípio da Responsabilidade Única (Single Responsibility Principle - SRP):

Um objeto deve ter apenas uma razão para ser modificado.
Este princípio afirma que uma classe deve ter apenas uma responsabilidade, ou seja, deve ter apenas um motivo para ser alterada. Isso facilita a manutenção e evita que a classe se torne complexa devido a várias responsabilidades.

Princípio Aberto/Fechado (Open/Closed Principle - OCP):

Entidades de software (classes, módulos, funções, etc.) devem ser abertas para extensão, mas fechadas para modificação.
Este princípio incentiva a extensibilidade do sistema sem modificar o código existente. Isso é frequentemente alcançado por meio do uso de herança, interfaces e polimorfismo.

Princípio da Substituição de Liskov (Liskov Substitution Principle - LSP):

Objetos de uma classe derivada devem poder substituir objetos de sua classe base sem afetar a corretude do programa.
Isso garante que as subclasses possam ser usadas em qualquer lugar que suas classes base sejam usadas, mantendo a consistência do sistema.

Princípio da Segregação de Interface (Interface Segregation Principle - ISP):

Uma classe não deve ser forçada a implementar interfaces que ela não usa.
Esse princípio destaca a importância de interfaces coesas, ou seja, interfaces que são específicas para as necessidades de uma classe, evitando interfaces grandes e genéricas.

Princípio da Inversão de Dependência (Dependency Inversion Principle - DIP):

Módulos de alto nível não devem depender de módulos de baixo nível. Ambos devem depender de abstrações.
Abstrações não devem depender de detalhes. Detalhes devem depender de abstrações.
Esse princípio incentiva o uso de abstrações (interfaces ou classes abstratas) para reduzir acoplamento, facilitando a substituição de componentes e promovendo a flexibilidade do sistema.
