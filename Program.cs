// See https://aka.ms/new-console-template for more information

//instanciar um objeto da classe cliente
cliente objcliente = new cliente();
cliente objcliente2 = new cliente();

objcliente.nome = "Pedro de Lara";
objcliente.cpf = "888";
objcliente.idade = 11;

objcliente2.nome = "Araci de Almeida";
objcliente2.cpf = "999";
objcliente2.idade = 22;

Console.WriteLine(objcliente.cpf);
Console.WriteLine(objcliente.nome);
Console.WriteLine(objcliente2.nome);

objcliente.salvar();

//Console.WriteLine("Hello, World!");
