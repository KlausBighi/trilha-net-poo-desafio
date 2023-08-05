using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia1 = new Nokia("98539-4185", "Lumia 720", "12345678987654321", "64GB");
nokia1.ExibirDados();
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Facebook");

Console.WriteLine("");

Iphone iphone1 = new Iphone("95467-1719", "Iphone 14", "98765432123456789", "128GB");
iphone1.ExibirDados();
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Whatsapp");