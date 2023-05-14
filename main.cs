using System;



internal class Musicdata
{
  static int Main(string[] args) {
    if (args.Length == 0) {
      Console.WriteLine("no path for reading data file specified in args");
      return 1;
    }
    Filereader fp = new Filereader(args[0]);
    string readout = fp.getcontents();
    int readoutit = 0;
    while (readout[readoutit] != '\xA'){ 
      readoutit++;
    }
    readout = readout.Substring(readoutit + 1);
    readoutit = 0;
    int nodatapoints = 0;
    while (readoutit < readout.Length){ 
      if (readout[readoutit] == '\xA'){ 
        nodatapoints++;
      }
      readoutit++;
    }
    Songdata [] dataset = new Songdata [nodatapoints];






    Console.WriteLine(readout.Substring(0, 2000));
    return 0;
  }
}

