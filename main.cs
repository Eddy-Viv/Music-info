using System;



internal class Musicdata
{
  static int Main(string[] args) {
    Filereader fp = new Filereader("C:\\Users\\ed\\Desktop\\Csharp\\Musicdata\\archive\\Music info.csv");
    string thing = fp.getcontents();
    Console.WriteLine(thing);
    return 0;
  }
}

