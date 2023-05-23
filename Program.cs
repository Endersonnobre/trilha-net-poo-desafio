using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone smt1 = new Nokia("IXT222", "Lumia", "AX9383439843", 6);
smt1.Ligar();
smt1.ReceberLigacao();
smt1.InstalarAplicativo("WhatsApp");


Smartphone smt2 = new Iphone("APT488", "C4", "FTV888999", 8);
smt2.Ligar();
smt2.ReceberLigacao();
smt2.InstalarAplicativo("WhatsApp");