using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisoncontroller : MonoBehaviour {
    public scorecontroller scoreController;

    public ballmovment ballMovment;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballposition = this.transform.position;
        Vector3 racketposition = c.gameObject.transform.position;
        float racketHight = c.collider.bounds.size.y;
        float x;
        if (c.gameObject.name == "racketplayer1")
        {
            x = 1;

        }
        else
            x = -1;
        float y = (ballposition.y - racketposition.y) / racketHight;
        this.ballMovment.increaseHitCounter();
        this.ballMovment.moveball(new Vector2(x, y));
         
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "racketplayer1" || collision.gameObject.name == "racketplayer2")
        {
            this.BounceFromRacket(collision);


        }
        else if (collision.gameObject.name== "wallRight")
        {
            Debug.Log("collesin on left");
            this.scoreController.GoalPlayer2();
            StartCoroutine(this.ballMovment.StartBall(true));
        }
        else if (collision.gameObject.name== "wallLeft")
        {
            Debug.Log("collesion on right!");
            this.scoreController.GoalPlayer1();
            StartCoroutine(this.ballMovment.StartBall(false));
        }


    }
}
