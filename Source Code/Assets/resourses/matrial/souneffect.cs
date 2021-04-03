using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class souneffect : MonoBehaviour {
    public AudioSource wallsound;
    public AudioSource racketsound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "racketplayer1" || collision.gameObject.name == "racketplayer2")
        {
            this.racketsound.Play();
        }
        else
            this.wallsound.Play();

    }

}
