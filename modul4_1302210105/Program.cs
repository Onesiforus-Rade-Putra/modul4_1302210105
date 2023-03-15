// See https://aka.ms/new-console-template for more information
using modul4_1302210105;

kodebuah kb = new kodebuah();
Console.WriteLine("kode buah Apel");
Console.WriteLine(kb.getkodebuah(kodebuah.buah.Apel));

PosisiKarakterGame game= new PosisiKarakterGame();
Console.WriteLine(game.sekarang);
game.action(PosisiKarakterGame.tombol.tombolW);
Console.WriteLine(game.sekarang);
game.action(PosisiKarakterGame.tombol.tombolX);
Console.WriteLine(game.sekarang);

