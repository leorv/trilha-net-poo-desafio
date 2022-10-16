using DesafioPOO.Models;

// Realizando os testes

Nokia nokia = new Nokia(numero: "14-2345-6789", modelo: "C30", imei: "ABC2139837GBFD", memoria: 64);
System.Console.WriteLine($"Smartphone Nokia de número: {nokia.Numero}");
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Santander");

Iphone iphone = new Iphone(numero: "11-1234-4321", modelo: "IPhone 13", imei: "jcsncs9723d287g", memoria: 512);
System.Console.WriteLine($"Smartphone Iphone de número: {iphone.Numero}");
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("trei.no");