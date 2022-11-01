using DesafioPOO.Models;

Iphone iphone = new Iphone("9999-9999" , "11", "IMEI IPHONE", 10);
Nokia nokia = new Nokia("9999-9999", "Lumia", "IMEI NOKIA", 8);

Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");