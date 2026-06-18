# csharp-logic-exercises

Repositório de estudos e exercícios práticos em C#, desenvolvido durante minha transição para a área de desenvolvimento de software. Os exercícios evoluem progressivamente — do básico de lógica até estruturas de dados e orientação a objetos.

## Sobre o projeto

O projeto é uma aplicação console .NET organizada por módulos de aprendizado. Cada exercício é executado a partir do `Program.cs` e está separado em sua própria classe, com namespace refletindo a categoria do tópico.

Todos os exercícios foram escritos, testados e commitados individualmente — o histórico do repositório documenta a evolução do aprendizado.

## Estrutura

```
csharp-logic-exercises/
├── Program.cs                  # Ponto de entrada — chama o Executar() de cada exercício
└── Exercicios/
    ├── 01_basico/              # Tipos, variáveis, operadores, interpolação
    ├── 02_condicoes/           # if/else, switch, operador ternário, validações
    ├── 03_loops/               # for, while, do/while, break, continue, laços aninhados
    ├── 04_logica/              # Problemas progressivos: primo, FizzBuzz, sequências
    └── 05_listas/              # List<T>, LINQ básico, coleções
```

## Tópicos cobertos

| Módulo | Tópicos |
|---|---|
| Básico | Tipos primitivos, `decimal` para valores monetários, interpolação, `CultureInfo`, conversão de tipos |
| Condições | `if/else`, `switch expression`, operador ternário, pattern matching (`>= x and <= y`) |
| Laços | `for`, `while`, `do/while`, `foreach`, `break`, `continue`, laços aninhados |
| Lógica | Par/ímpar, divisibilidade, número primo com `Math.Sqrt`, FizzBuzz, pirâmide, jogo de dados |
| Listas | `List<T>`, `foreach`, `LINQ` (`Max()`, `Min()`), histórico de operações |

## Destaques técnicos

- Validação de entrada com `TryParse` em todos os exercícios — o programa nunca quebra com entrada inválida
- Uso de `CultureInfo.InvariantCulture` para parsing de decimais
- Pattern matching com `switch expression` (C# 9+)
- `Random` para simulações (jogo de dados, adivinhe o número)
- Estrutura de namespaces organizada por módulo de aprendizado

## Como executar

**Pré-requisitos:** .NET 6+ instalado

```bash
git clone https://github.com/seu-usuario/csharp-logic-exercises.git
cd csharp-logic-exercises
dotnet run
```

No `Program.cs`, comente/descomente a linha do exercício que deseja executar.

## Stack

- C# / .NET 6+
- Visual Studio Code
- Git para versionamento — 1 commit por exercício

## Próximos passos

- [ ] Orientação a objetos — herança, polimorfismo, interfaces
- [ ] Tratamento de exceções
- [ ] Conexão com banco de dados (SQL Server)
- [ ] Projeto full stack com API REST em C# e front em React

---

Desenvolvido por [diegoapolaro](https://github.com/diegoapolaro) · Em formação — 4º semestre de Ciência da Computação
