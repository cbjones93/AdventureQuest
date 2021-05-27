using System;
using System.Collections.Generic;

namespace Quest 
{
public class Robe
{
    public List<string> Colors { get; set; }
    public int RobeLength { get; set; }

    public void AddRobeColor(string color){
        Colors.Add(color);
    }
    public Robe(){
        RobeLength = 0; 
        Colors= new List<string>();
    }
}

}