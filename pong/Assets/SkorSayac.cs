using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkorSayac : MonoBehaviour{

public Text Scoreboard;
public GameObject top;
    private int Sopa1Skor = 0;
    private int Sopa2Skor = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;
        top = GameObject.Find ("Top");
    }

    // Update is called once per frame
    void Update()
    {   
        
         if (top.transform.position.x >= 24.6f) {
           Sopa1Skor ++;
        }
        if (top.transform.position.x <= -24.6f) {
           Sopa2Skor ++;
        }
                Scoreboard.text = Sopa1Skor.ToString () + "-" + Sopa2Skor.ToString ();

        print (Sopa1Skor + "," + Sopa2Skor);

        
    }
}
