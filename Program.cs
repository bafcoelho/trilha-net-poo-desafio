using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("155555-7891", "N95", "12345678910", 4);
Console.WriteLine(nokia.Numero);
nokia.ReceberLigacao();
nokia.Ligar();
nokia.InstalarAplicativo("Photo Gallery");

Console.WriteLine("------------------------------");

Iphone iphone = new Iphone("155555-9999", "15 Plus 250g", "12345678888", 8);
Console.WriteLine(iphone.Numero);
iphone.ReceberLigacao();
iphone.Ligar();
iphone.InstalarAplicativo("iMove");