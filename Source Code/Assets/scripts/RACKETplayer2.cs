using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RACKETplayer2 : MonoBehaviour {

    public float movmentSpeed;
    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movmentSpeed;

    }
}
