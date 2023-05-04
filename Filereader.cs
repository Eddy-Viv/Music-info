using System;
using System.IO;


 
internal class Filereader {
  string filecontents = "";

  public Filereader(string path) {
    filecontents = File.ReadAllText(path);
  }

  public string getcontents() {

    return filecontents;
  }

  public string getcontents(int start, int length = 10) {
    return filecontents.Substring(start, length);
  }


}

