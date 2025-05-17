# 📦 Container Optimization

Este projeto tem como objetivo otimizar a **alocação de containers** em **armazéns** e a posterior distribuição em **caminhões**, respeitando suas respectivas capacidades máximas.

Ele aplica uma variação do algoritmo de **Bin Packing** para agrupar os volumes e fornece um relatório final da organização.

---

## 📋 Funcionalidades

- Entrada de volumes de containers.
- Verificação da capacidade dos armazéns e caminhões (não pode ser menor que o maior container).
- Distribuição dos volumes entre armazéns de forma otimizada.
- Redistribuição dos volumes dos armazéns em caminhões.
- Relatório com:
  - Quantidade de armazéns e caminhões usados.
  - Volumes em cada armazém e caminhão.
  - Origem de cada volume (qual armazém) em cada caminhão.

---

## 🧰 Tecnologias utilizadas

- [.NET 7 ou superior](https://dotnet.microsoft.com/)
- C#
- Console App

---

## 🚀 Como executar o projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/container-optimization.git
cd container-optimization
```

### 2. Restaure as dependências (se necessário)

Como se trata de um projeto `Console App` puro em C#, geralmente não há pacotes externos, mas por via das dúvidas:

```bash
dotnet restore
```

### 3. Execute o projeto

```bash
dotnet run
```

---

## 🗂 Estrutura de Pastas

```bash
ContainerOptimization/
├── Models/
│   └── Armazem.cs
│   └── Caminhao.cs
│   └── Container.cs
├── Services/
│   └── BinPackingService.cs
├── Utils/
│   └── InputHelper.cs
├── Program.cs
└── README.md
```

---

## ✅ Exemplo de uso

```txt
Digite os volumes dos containers separados por vírgula:
40,80,50,10,30

Capacidade dos armazéns: 100  
Capacidade dos caminhões: 80

Armazéns necessários: 3  
Armazém 1: 80 + 10 = 90  
Armazém 2: 50 + 40 = 90  
Armazém 3: 30 = 30

Caminhões necessários: 3  
Caminhão 1: Armazém 1(80) = 80  
Caminhão 2: Armazém 2(50) + Armazém 2(30) = 80  
Caminhão 3: Armazém 3(40) + Armazém 3(10) = 50
```

---

## ⚠️ Observações

- O programa **não permite** que a capacidade do armazém ou caminhão seja menor que o maior container.
- Em caso de erro de entrada, o sistema solicitará a digitação novamente.

---
