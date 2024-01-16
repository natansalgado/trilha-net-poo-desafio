using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "11 92623-4536", modelo: "Modelo 32", imei: "3427542", memoria: 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "11 99341-9683", modelo: "Modelo 12", imei: "9853241", memoria: 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");