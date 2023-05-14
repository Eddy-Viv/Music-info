using System;
using System.IO;


 
internal class Filereader {
  string filecontents = "";

  public Filereader(string path) {
    filecontents = File.ReadAllText(path);
  }

  internal string getcontents() {

    return filecontents;
  }

  internal string getcontents(int start, int length = 10) {
    return filecontents.Substring(start, length);
  }


}

