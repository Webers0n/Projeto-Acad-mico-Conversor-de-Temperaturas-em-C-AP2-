# 🌡️ Conversor de Temperaturas - Linguagem C# AP2

Aplicativo **Windows Forms** desenvolvido em **C#** para conversão entre as escalas **Celsius**, **Kelvin** e **Fahrenheit**.  
Permite realizar todas as combinações de conversão, com validação de dados, mensagens de erro amigáveis e uma interface simples e funcional.  
Projeto criado como atividade prática da disciplina **Linguagem C# AP2**.

---

## 🧩 Funcionalidades

- 🔹 Conversão de **Celsius → Fahrenheit**
- 🔹 Conversão de **Kelvin → Fahrenheit**
- 🔹 Conversão de **Kelvin → Celsius**
- 🔹 Conversão de **Celsius → Kelvin**
- 🔹 Conversão de **Fahrenheit → Kelvin**
- 🔹 Conversão de **Fahrenheit → Celsius**
- 🔹 Validação de campos vazios e valores inválidos
- 🔹 Botão de **encerrar aplicação**

---

## 🖥️ Interface

A interface foi criada no **Windows Forms**, com botões para cada tipo de conversão e caixas de texto para entrada e saída dos valores.  
Mensagens de aviso e erro são exibidas por meio de **MessageBox**, garantindo uma boa experiência ao usuário.

---

## 🖥️ Captura de Tela

![Tela Principal](imagens/tela-principal.png)
![Tela Principal](https://github.com/Weber0n/Linguagem-C-AP2/blob/main/imagens/tela-principal.png?raw=true)




---

## 📁 Estrutura do Projeto

```
Linguagem C# AP2/
│
├── bin/
├── obj/
├── Properties/
├── Resources/
├── App.config
├── Atividade Pratica 2.cs # Código principal com as conversões
├── Atividade Pratica 2.Designer.cs # Layout e componentes do formulário
├── Atividade Pratica 2.resx # Recursos visuais do formulário
├── Program.cs # Classe principal (ponto de entrada)
├── Linguagem C# AP2.csproj # Arquivo do projeto
└── Linguagem C# AP2.sln # Solução do Visual Studio
```

---

## ⚙️ Como Executar

1. Abra o projeto no **Visual Studio**.  
2. Compile (Ctrl + Shift + B) para gerar os arquivos necessários.  
3. Execute com **F5** ou clique em **Iniciar**.  
4. Digite um valor em uma escala e selecione o botão da conversão desejada.

---

## 🧮 Fórmulas Utilizadas

| Conversão | Fórmula |
|------------|----------|
| Celsius → Fahrenheit | `F = (C × 1.8) + 32` |
| Fahrenheit → Celsius | `C = (F - 32) × 5/9` |
| Celsius → Kelvin | `K = C + 273.15` |
| Kelvin → Celsius | `C = K - 273.15` |
| Fahrenheit → Kelvin | `K = (F - 32) × 5/9 + 273.15` |
| Kelvin → Fahrenheit | `F = (K - 273.15) × 1.8 + 32` |

---

## 🚀 Tecnologias Utilizadas

- 💻 **C#**
- 🪟 **.NET Framework / Windows Forms**
- 🧱 **Visual Studio**

---

## 👨‍💻 Autor

**Weberson Oliveira**  
📍 Desenvolvedor Desktop
💡 Projeto criado como atividade prática da disciplina **Linguagem C# AP2**

---

📘 **Licença:**  
Este projeto é de uso educacional e livre para estudos e adaptações.
