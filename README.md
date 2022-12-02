# knowledge-C-
Criei esse repositório para meus conhecimentos de C#

(Orientação a objetos)

Na aula de introdução aprendi:
Preparar o ambiante;
Toda aplicação .NET é escrita em uma linguagem compilada para o código intermediário MSIL (Microsoft intermediate language);
O .NET Framework é uma biblioteca utilizada pelas aplicações .NET;
Uma aplicação .NET é compilada para o MSIL;
O código MSIL é executado pela máquina virtual do .NET, a CLR (common language runtime);
O just-in-time compiler é uma parte da CLR que transforma MSIL em código de máquina, apenas em tempo de execução;


Aula-2:

Para manipular os valores dos campos de um objeto, nós indicamos o objeto através do operador ponto (.) e acessamos o campo para inserir um valor usando o operador de igualdade (=);
Valores padrão para campos de uma classe são definidos de maneira automática, o que permite declarar o campo sem a necessidade de inserir um valor;
Atribuímos uma referência a uma variável fazendo ela apontar para um espaço na memória que contém um objeto;
Os tipos por referência só apontam para um objeto criado na memória do computador.

Aula-3:

Criamos métodos que recebem parâmetros e retornam algum valor para simular os comportamentos (operações) de uma classe;
Quando desenvolvemos um método, ele recebe como parâmetro uma referência para um objeto;
Como criar um método que não retorna nenhum valor, mas que encapsula uma ação existente no mundo real usando a palavra reservada void.

Aula-4:

Como adicionar uma nova classe ao projeto usando as facilidades oferecidas pela IDE do Visual Studio Community, tal qual criar uma classe com base em um modelo com a sintaxe básica;
Podemos organizar a estrutura do nosso projeto usando os namespaces;
Utilizamos a diretiva using e o nome completo qualificado para usar uma classe do projeto que esteja em um namespace;
Utilizamos o conceito de composição para criar classes compostas por outras classes;
Entendemos que as referências nulas no nosso código apontarão para espaços em memória que não contenham um objeto;
Verificamos se uma referência está nula para evitar erros como “Exceção Sem Tratamento — System.NullReferenceException: 'Referência de objeto não definida para uma instância de um objeto”.

Aula-5:

Restringimos a visibilidade de campos de uma classe para que não sejam acessados de outros pontos do código;
Criamos métodos públicos para manipulação de campos privados, aplicando uma boa prática e implementando o conceito de encapsulamento de campos de uma classe;
A sintaxe utilizada pelo C# para definir uma propriedade, que facilita a criação de operações para leitura e escrita de informação em um objeto;
As propriedades autoimplementadas podem ajudar na legibilidade do código.

Aula-6:

Métodos construtores são chamados quando criamos um objeto usando o operador new. Por meio deles, podemos informar os valores dos campos no momento da criação do objeto;
Construtores explícitos são definidos por quem desenvolve e construtores implícitos são criados pelo próprio .NET quando não definimos explicitamente;
A palavra reservada static é utilizada para definir um campo ou propriedade como membro de uma classe. Assim conseguimos compartilhar informações com todos os objetos de uma classe.

