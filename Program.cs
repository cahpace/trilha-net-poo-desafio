using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//Testando Iphone
Console.WriteLine("Teste Iphone: ");
Iphone iphone1 = new Iphone(numero: "996538542", modelo: "15 Pro", imei: "85632242", memoria: 128);
iphone1.Ligar();
iphone1.InstalarAplicativo("WhatsApp");

//Testando Nokia
Console.WriteLine("Teste Nokia: ");
Iphone nokia1 = new Iphone(numero: "998552364", modelo: "rgt", imei: "8965421", memoria: 64);
nokia1.Ligar();
nokia1.InstalarAplicativo("Google Maps");

