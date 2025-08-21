using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Nokia 6.1", imei: "111222333444555", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "555444333222111", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
