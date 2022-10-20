using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia1 = new Nokia(numero: "123", modelo: "J7", imei: "jsdklak", memoria: 5);
nokia1.ReceberLigacao();
nokia1.Ligar();
nokia1.InstalarAplicativo("Nubank");

Console.WriteLine("\n");

Iphone ipho1 = new Iphone(numero: "123", modelo: "J7", imei: "jsdklak", memoria: 5);
ipho1.ReceberLigacao();
ipho1.Ligar();
ipho1.InstalarAplicativo("Nubank");