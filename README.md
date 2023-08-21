# Astra Lang - Linguagem experimental parcialmente implementada para produção de código compatível os padrões de "Safety-Critical Code" do JPL

**Astra Lang - Experimental language for generating code compliant with JPL's Safety-Critical Code standards.**

![UFABC Logo](assets/logotipo-ufabc-extenso.png)

Universidade Federal do ABC - Bacharelado em Ciência e Tecnologia Compiladores 2023/Q2

Lenin Cristi

{lenin.cristi}@aluno.ufabc.edu.br

## Objetivos

Criação de uma linguagem experimental que gere código em linguagem C já compatível com as especificações do JPL para código crítico de veículos espaciais.

## TL;DR

[The Power of 10 — NASA's Rules for Coding](https://betterprogramming.pub/the-power-of-10-nasas-rules-for-coding-43ae1764f73d)

The Power of 10 Rules was created in 2006 by Gerard J. Holzmann of the NASA/JPL Laboratory for Reliable Software. The rules are intended to eliminate certain C coding practices which made code difficult to review or to statically analyze.

These rules are a complement to the MISRA C guidelines and have been incorporated into the greater set of JPL coding standards.

## Too Long, but I want to read

[C style guide (August 1, 1994)](https://ntrs.nasa.gov/citations/19950022400)
This document discusses recommended practices and style for programmers using the C language in the Flight Dynamics Division environment. Guidelines are based on generally recommended software engineering techniques, industry resources, and local convention. The Guide offers preferred solutions to common C programming issues and illustrates through examples of C Code.

[C++ Coding Standards and Style Guide (May 24, 2005)](https://ntrs.nasa.gov/citations/20080039927)
This document is based on the "C Style Guide" (SEL-94-003). It contains recommendations for C++ implementations that build on, or in some cases replace, the style described in the C style guide. Style guidelines on any topics that are not covered in this document can be found in the "C Style Guide." An attempt has been made to indicate when these recommendations are just guidelines or suggestions versus when they are more strongly encouraged. Using coding standards makes code easier to read and maintain. General principles that maximize the readability and maintainability of C++ are: (1) Organize classes using encapsulation and information hiding techniques. (2) Enhance readability through the use of indentation and blank lines. (3) Add comments to header files to help users of classes. (4) Add comments to implementation files to help maintainers of classes. (5) Create names that are meaningful and readable.

## Requisitos

O compilador está parcialmente implementado em C# utilizando .NET 7 e Antlr

Lista de software recomendado (plataformas Windows ou Linux)

### Git

[Git (Windows)](https://git-scm.com/downloads)

[Git (Linux, Red Hat based)](https://git-scm.com/)

```bash
sudo yum update
sudo yum install git
```

### Frameworks

[.NET SDK](https://dotnet.microsoft.com/pt-br/download)

[Java SE 11](https://www.oracle.com/br/java/technologies/javase/jdk11-archive-downloads.html)

Porque? O Antlr na versão utilizada roda seu tooling no Java 11

> Altere sua variável JAVA_HOME para o Java 11 durante o build

### IDE's

[VS Code](https://code.visualstudio.com/)

[Visual Studio (alternativa ao VS Code, pode ser utilizado o community)](https://visualstudio.microsoft.com/pt-br/vs/community/)

### Compiladores

[GCC via MSYS2 (Windows)](https://www.msys2.org/)

Após a instalação usual do MSYS2, execute o seguinte comando no terminal do MSYS2

```bash
pacman -S mingw-w64-ucrt-x86_64-gcc
```

> Adicione o caminho dos binários MSYS2 a PATH do seu ambiente

[GCC (Linux)](https://gcc.gnu.org/)

```bash
sudo yum update
sudo yum install gcc gcc-c++
```

Verifique a instalação utilizando

```bash
$ gcc --version
```


### Extensões recomendadas do VS Code para o projeto

[ANTLR4 grammar syntax support](https://marketplace.visualstudio.com/items?itemName=mike-lischke.vscode-antlr4)

[C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

Extensões opcionais do VS Code para o projeto

[Python](https://marketplace.visualstudio.com/items?itemName=ms-python.python)

Porque? Existe um meio rápido de iniciar testes com o Antlr utilizando um ambiente python sem instalação adicional de bibliotecas

[C/C++ Extension Pack](https://marketplace.visualstudio.com/items?itemName=ms-vscode.cpptools-extension-pack)

Porque? Facilita o teste do código C gerado

[Extension Pack for Java](https://marketplace.visualstudio.com/items?itemName=vscjava.vscode-java-pack)

Porque? Facilita a exploração dos projetos de referência em Java

## Instalação & Uso

Com o software requerido instalado, fica disponível o comando

```bash
dotnet
```

Clone o repositório, navegue até a pasta do projeto e execute o arquivo de download da biblioteca  Antlr (Ele somente recupera a biblioteca Antlr 4.13 e baixa na pasta ./bin, se preferir fazer manualmente pode ser baixado [nesta página](https://www.antlr.org/download.html) no link **ANTLR tool itself**)

### Windows

```bash
powershell ./antlr-download.ps1
```

### Linux

```bash
./antlr-download.sh
```

Execute o comando de restore de bibliotecas do dotnet

```bash
dotnet restore
```

Para fazer o build do projeto

```bash
dotnet build
```

Para rodar o projeto

```bash
dotnet run
```


## Referências

### Referências de aula

https://github.com/professorisidro/ExpressionAnalyzer

https://github.com/professorisidro/ExpressionLanguage

https://github.com/professorisidro/TypeExpression

https://github.com/professorisidro/IsiLanguageEmbriao

### Referências do estilo

Resumo
https://betterprogramming.pub/the-power-of-10-nasas-rules-for-coding-43ae1764f73d

C
https://ntrs.nasa.gov/citations/19950022400

C++
https://ntrs.nasa.gov/citations/20080039927

Framework & Tooling baseado neste estilo
https://nasa.github.io/fprime/UsersGuide/dev/code-style.html

### Referências do Antlr utilizadas

Antlr
https://www.antlr.org/

Antlr v4
https://github.com/antlr/antlr4

Getting Started with ANTLR v4
https://github.com/antlr/antlr4/blob/master/doc/getting-started.md

Antlr C# Target
https://github.com/antlr/antlr4/blob/master/doc/csharp-target.md

Examples of the book "The Definitive ANTLR 4 Reference" by Terence Parr translated in C#
https://github.com/Philippe-Laval/tpantlr2

Examples of the book "Language Implementation Patterns" by Terence Parr translated in C# and Antrl4
https://github.com/Philippe-Laval/tpdsl

C# target for ANTLR 4
https://github.com/antlr/antlr4/tree/master/runtime/CSharp/src

### Referência de implementação de gramática

Templates de linguagem
https://github.com/kaby76/Antlr4Templates/tree/main

> Apesar do objetivo do repositório ser o de templates Antlr para o dotnet, existem diversos arquivos de gramática uteis como referência

Tiny Language for ANTLR 4
https://github.com/bkiers/tiny-language-antlr4

> Uma linguagem de instruções reduzidas completamente implementada

___

CMCC - Universidade Federal do ABC (UFABC) - Santo André - SP - Brasil