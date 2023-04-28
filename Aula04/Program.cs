using System;
namespace Aula04;
class Program
{
    static void Main(string[] args)
    {
        string preparo;
        Cafe cafe = new Cafe() {Grao="grao 1", Temperatura=45};
        Cafe cafe2 = new Cafe() {Grao="grao 2", Temperatura=50};
        Suco suco = new Suco() {fruta="abacaxi", Temperatura=12};
        Suco suco2 = new Suco() {fruta="uva", Temperatura=17};
        preparo = cafe.Preparar();
        Console.WriteLine(preparo);
    }
}

