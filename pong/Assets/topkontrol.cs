using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class topkontrol : MonoBehaviour

{
private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {   rb = GetComponent<Rigidbody2D> () ;

        StartCoroutine (Pause());
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(this.transform.position.x) >= 25f) {
           this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine (Pause());
        }
        
    }

    IEnumerator Pause () {

        int directionX = Random.Range (-1, 2);
        int directionY = Random.Range (-1, 2);

        if (directionX == 0) {
            directionX = 1;}

        rb.velocity = new Vector2 (0f,0f) ;
        yield return new  WaitForSeconds (2) ;
        rb.velocity = new Vector2 (10f * directionX, 10f * directionY) ;
    }
}
