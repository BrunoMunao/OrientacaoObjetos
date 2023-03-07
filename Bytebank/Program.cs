using Bytebank;
using Bytebank.Pessoas;
using Bytebank.Contas;

ContaCorrente contaDoBruno = new ContaCorrente("Bruno de Avila", 1, "1");
ContaCorrente contaDaJulia = new ContaCorrente("Júlia Franche", 2, "1");

contaDoBruno.EscreveDados();
contaDaJulia.EscreveDados();

contaDoBruno.Depositar(2906);
contaDaJulia.Depositar(1701);

Console.WriteLine();
Console.WriteLine();

contaDoBruno.EscreveDados();
contaDaJulia.EscreveDados();

Console.WriteLine($"Número de contas do banco: {ContaCorrente.NumeroContas}");

Console.ReadKey();
