using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameData
{
    
    
   
        
    

    public static GameData Instance
    {
        get
        {
            if (instance == null) instance = new GameData();
            {
                return Instance;
            }
        }
    }
        private static GameData instance;
     private GameData() { }
    
}
