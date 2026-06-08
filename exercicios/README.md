Exercícios da disciplina — Trabalho (C#)

Arquivos:

- `boas_vindas.cs` — lê o nome e exibe mensagem de boas-vindas.
- `soma.cs` — lê dois inteiros e exibe a soma.
- `total_compra.cs` — lê preço e quantidade e exibe o total.
- `maioridade.cs` — verifica se a pessoa é maior ou menor de idade.
- `avaliacao.cs` — avalia nota (0-100) e informa resultado.

Como executar:

1) Usando o compilador C# do Visual Studio ou Build Tools no Windows:

```powershell
csc boas_vindas.cs
./boas_vindas.exe
```

2) Usando o .NET SDK em qualquer plataforma:

```powershell
dotnet new console -o tempApp --no-restore
move boas_vindas.cs tempApp/Program.cs
cd tempApp
dotnet run
cd ..
Remove-Item -Recurse -Force tempApp
```

Repita trocando `boas_vindas.cs` pelo arquivo desejado: `soma.cs`, `total_compra.cs`, `maioridade.cs` ou `avaliacao.cs`.

3) Outra opção é abrir a pasta `exercicios` no Visual Studio ou no VS Code, criar um projeto de console e copiar o conteúdo do arquivo desejado para `Program.cs`.

Observação: os exemplos acima usam PowerShell; se estiver em Linux/macOS, substitua `move` por `mv` e `Remove-Item` por `rm -rf`.
