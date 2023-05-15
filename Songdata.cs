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

  internal Songdata(string rawinput = "") {
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
              if (current.Length != 0){
                int numberelements = 1;
                for (int ii = 0; ii < current.Length; ii++){ 
                  if (current[ii] == ','){ 
                    numberelements++;
                  }
                }
                tags = new string [numberelements];
                string ccurrent = "";
                int currentelement = 0;
                for (int ii = 0; ii < current.Length; ii++){ 
                  if (current[ii] == ','){
                    if (ccurrent[0] == ' '){ 
                      ccurrent = ccurrent.Substring(1);
                    }
                    tags[currentelement] = ccurrent;
                    currentelement++;
                    ccurrent = "";
                  } else { 
                    ccurrent += current[ii];
                  }
                }
              }
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
          variableno++;
          current = "";
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
  
  public void Printme (){ 
    Console.WriteLine(trackID);
    Console.WriteLine(name);
    Console.WriteLine(artist);
    Console.WriteLine(spotifypreviewURL);
    Console.WriteLine(spotifyID);
    for (int i = 0; i < tags.Length; i++){ 
      Console.Write(tags[i] + " ");
    }
    Console.WriteLine("");
    Console.WriteLine(genre);
    Console.WriteLine(year);
    Console.WriteLine(durationMS);
    Console.WriteLine(danceability);
    Console.WriteLine(energy);
    Console.WriteLine(key);
    Console.WriteLine(loudness);
    Console.WriteLine(mode);
    Console.WriteLine(speechiness);
    Console.WriteLine(acousticness);
    Console.WriteLine(instrumentalness);
    Console.WriteLine(liveness);
    Console.WriteLine(valence);
    Console.WriteLine(tempo);
    Console.WriteLine(timesignature);

  }

}