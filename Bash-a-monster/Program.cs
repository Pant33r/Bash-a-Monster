// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using Namespace;

Console.WriteLine("Hello, World!");

Sigmawolftiger Jesper = new Sigmawolftiger();
Sigmawolftiger Albin = new Sigmawolftiger();
Sigmawolf Emil = new Sigmawolf();
AlphaWolf Theo = new AlphaWolf();
ToppeG Felix = new ToppeG();

Felix.damage =1000;
Jesper.damage = 50;
Theo.damage = 2;
Albin.damage = 0;
Emil.damage = 1;

Felix.killable =false;
Jesper.killable =true;
Albin.killable =true;
Theo.killable =true;
Emil.killable =true;


Emil.weight = 1;
Jesper.weight = 100;
Theo.weight = 100;
Albin.weight = 100;

Console.WriteLine(Jesper.damage);
Console.ReadLine();
/*

firre
ätbar bool
skada int 
vikt float
stackable bool
*/

