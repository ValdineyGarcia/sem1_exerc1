string nomeUsuario, sobrenomeUsuario, corFavorita;
Console.WriteLine("Seja Bem vindo! Favor informar seu nome:");
nomeUsuario = Console.ReadLine();
Console.WriteLine("Informe seu sobrenome:");
sobrenomeUsuario = Console.ReadLine();
Console.WriteLine("Qual a sua cor favorita?");
corFavorita = Console.ReadLine();
int idadeUsuario;
Console.WriteLine("Qual a sua idade?");
idadeUsuario = int.Parse(Console.ReadLine());
Console.WriteLine($"Obrigado por responder as perguntas {nomeUsuario} {sobrenomeUsuario}. Você tem {idadeUsuario} anos e sua cor preferida é {corFavorita}.");

