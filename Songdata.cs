using System;


internal class Songdata {

  // song data point fields
  string trackID;
  string name;
  string artist;
  string spotifypreviewURL;
  string spotifyID;
  string[] tags;
  string genre;
  int year;
  int durationMS;
  double danceability;
  double energy;
  int key;
  double loudness;
  int mode;
  double speechiness;
  double acousticness;
  double instrumentalness;
  double liveness;
  double valence;
  double tempo;
  int timesignature;

  Songdata(string rawinput = "") {
    string current = "";
    int i = 0, variableno = 0;
    bool inquotations = false;
    while (i < rawinput.Length){
      if (!inquotations){
        if (rawinput[i] == ','){ 
          switch (variableno){ 
            case 0:
              trackID = current;
              break;
            case 1:
              name = current;
              break;
            case 2:
              artist = current;
              break;
            case 3:
              spotifypreviewURL = current;
              break;
            case 4:
              spotifyID = current;
              break;
            case 5:
              // implement tags de-delimiter here
              Console.WriteLine("implementme");
              break;
            case 6:
              genre = current;
              break;
            case 7:
              year = Convert.ToInt32(current);
              break;
            case 8:
              durationMS = Convert.ToInt32(current);
              break;
            case 9:
              danceability = Convert.ToDouble(current);
              break;
            case 10:
              energy = Convert.ToDouble(current);
              break;
            case 11:
              key = Convert.ToInt32(current);
              break;
            case 12:
              loudness = Convert.ToDouble(current);
              break;
            case 13:
              mode = Convert.ToInt32(current);
              break;
            case 14:
              speechiness = Convert.ToDouble(current);
              break;
            case 15:
              acousticness = Convert.ToDouble(current);
              break;
            case 16:
              instrumentalness = Convert.ToDouble(current);
              break;
            case 17:
              liveness = Convert.ToDouble(current);
              break;
            case 18:
              valence = Convert.ToDouble(current);
              break;
            case 19:
              tempo = Convert.ToDouble(current);
              break;
            case 20:
              timesignature = Convert.ToInt32(current);
              break;
            default:
              break;
          }
        } else {
          if (rawinput[i] == '"'){ 
            inquotations = true;
          } else {
            current += rawinput[i];
          }
        }
      } else if (rawinput[i] == '"'){
        inquotations = false;
      } else { 
        current += rawinput[i];
      }
      i++;
    }
  }

}