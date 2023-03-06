using Bytebank;

ContaCorrente contaDaJulia = new ContaCorrente();
ContaCorrente contaDoBruno = new ContaCorrente();

contaDaJulia.titular = "Júlia Franche";
contaDaJulia.conta = 1;
contaDaJulia.agencia = "000-1";
contaDaJulia.saldo = 130000.13;

contaDoBruno.titular = "Bruno de Avila";
contaDoBruno.conta = 2;
contaDoBruno.agencia = "000-1";
contaDoBruno.saldo = 13000.13;


Console.WriteLine($"Titular da conta: {contaDaJulia.titular}");
Console.WriteLine($"Número da conta: {contaDaJulia.conta}");
Console.WriteLine($"Agência: {contaDaJulia.agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDaJulia.saldo)}");

Console.WriteLine($"Titular da conta: {contaDoBruno.titular}");
Console.WriteLine($"Número da conta: {contaDoBruno.conta}");
Console.WriteLine($"Agência: {contaDoBruno.agencia}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoBruno.saldo)}");

contaDaJulia.Depositar(13);
if (!contaDaJulia.Sacar(200000))
    Console.WriteLine("Impossível sacar!");
if (!contaDaJulia.Sacar(200))
    Console.WriteLine("Impossível sacar!");

Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDaJulia.saldo)}");

if (!contaDaJulia.Transferir(200000, contaDoBruno))
    Console.WriteLine("Impossível transferir!");
if (!contaDaJulia.Transferir(200, contaDoBruno))
    Console.WriteLine("Impossível transferir!");

Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDaJulia.saldo)}");
Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", contaDoBruno.saldo)}");

Console.ReadKey();
