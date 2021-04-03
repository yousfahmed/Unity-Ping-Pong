using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovment : MonoBehaviour {

    public float MovmentSpeed;
    public float ExtraSpeedPerHit;
    public float MaxExtraSpeed;
    int hitCounter = 0;



	void Start () {
        StartCoroutine(this.StartBall());
	}

    void ballposition (bool isStartingplayer1)
    {

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        if (isStartingplayer1)
        {

            this.gameObject.transform.localPosition = new Vector3(-100, 0, 0);


        }
        else
            this.gameObject.transform.localPosition = new Vector3(100, 0, 0);


    }


    public IEnumerator StartBall(bool isStartingplayer1=true)
    {
        this.ballposition(isStartingplayer1);

        this.hitCounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingplayer1)
            this.moveball(new Vector2(-1, 0));
        else
            this.moveball(new Vector2(1, 0));



    }
	
    public void moveball(Vector2 dir)
    {

        dir = dir.normalized;
        float speed = this.MovmentSpeed + this.ExtraSpeedPerHit * hitCounter;
        Rigidbody2D rigidBody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidBody2D.velocity = dir * speed;

    }
    public void increaseHitCounter  ()
    {

        if (this.hitCounter*this.ExtraSpeedPerHit<=MaxExtraSpeed)
        {
            this.hitCounter++;
        }
    }

}
