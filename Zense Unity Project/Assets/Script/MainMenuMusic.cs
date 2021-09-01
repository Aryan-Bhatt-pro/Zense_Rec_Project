using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
   private static MainMenuMusic music;

   void AwakeMenu()
   {
       if(music == null)
       {
           music = this;
           DontDestroyOnLoad(music);

       }

       else
       {
           Destroy(gameObject);
       }
   }
    
}
