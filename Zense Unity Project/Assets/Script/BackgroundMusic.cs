using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic bm;

    void Playing()
    {
        if(bm == null)
        {
            bm = this;
            DontDestroyOnLoad(bm);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
