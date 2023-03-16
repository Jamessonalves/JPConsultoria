# JPConsultoria
Repositório  criado  com  o  objetivo  de  praticar as possibilidades de criação de tabelas utilizando a arquitetura
MVC e criando uma integração com o banco de dados. 
## Descrição 
Atendendo às seguintes características:
- Uma tabela chamada Cliente, que armazena dados como nome,cpf e e-mail;
- Uma tabela chamada Fornecedor, que armazena dados como nome,cnpj e e-mail;
- Uma tabela chamada Funcionário, que armazena dados como nome,cnpj,e-mail,departamento,
cargo e salário;
- Uma tabela chamada Produto, que armazena dados como nome,descrição e valor.
--- 
## Tecnologias Utilizadas 
Esse projeto foi criado utilizando as tecnologias: 
### Back-End 
- [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)  
- [.NET](https://dotnet.microsoft.com/download) 
### Banco de dados
- [SQL Server](microsoft.com/pt-br/sql-server/sql-server-server-downloads) 
### Editor 
- [Visual Studio Code](https://code.visualstudio.com/)   
---  
## Como rodar o projeto
Clone o projeto com o comando abaixo:
```bash 
# Clone o repositório 
  >git clone https://github.com/Jamessonalves/JPConsultoria.git
# Entre no diretório 
  >cd [JPConsultoria] 
# Integrar com banco de dados
  >Abra o arquivo da classe Program.cs e coloque sua string de conexão com o seu banco de dados
   entre as aspas do código:(options => options.UseSqlServer(""));
  >No terminal execute o comando dotnet ef database update
# Execute o projeto  
  >dotnet run
