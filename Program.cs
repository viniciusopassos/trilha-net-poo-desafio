using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "M123456", imei: "654321", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "123456", modelo: "M123456", imei: "654321", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");