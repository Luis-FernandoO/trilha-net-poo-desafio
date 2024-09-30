using DesafioPOO.Models;

Console.WriteLine("---------- Nokia -----------");
Smartphone cel1 = new Nokia("897897897897", "Nokia G10","5456445454564", 256);
cel1.Ligar();
cel1.ReceberLigacao();
cel1.InstalarAplicativo("Telegram");

Console.WriteLine("---------- IPhone -----------");
Smartphone cel2 = new Iphone("849848154124", "IPhone 16", "878787564532121", 512);
cel2.Ligar();
cel2.ReceberLigacao();
cel2.InstalarAplicativo("Play Store");