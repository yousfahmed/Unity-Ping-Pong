using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scorecontroller : MonoBehaviour {
    private int  scoreplayer1=0;
    private int scoreplayer2 = 0;

    public GameObject scoreTextplayer1;
    public GameObject scoreTextplayer2;
    public int GoalsWin;

    // Update is called once per frame
    void Update() {

        if (this.scoreplayer1 >= this.GoalsWin || this.scoreplayer2 >= GoalsWin)
        {
            SceneManager.LoadScene("GameOver");

            Debug.Log("Game end");
        }


	}

    private void FixedUpdate()
    {

        Text uiScorePlayer1 = this.scoreTextplayer1.GetComponent<Text>();
        uiScorePlayer1.text = this.scoreplayer1.ToString();



        Text uiScorePlayer2 = this.scoreTextplayer2.GetComponent<Text>();
        uiScorePlayer2.text = this.scoreplayer2.ToString();

    }




    public void GoalPlayer1()
    {
        this.scoreplayer1++;

    }
    public void GoalPlayer2()
    {
        this.scoreplayer2++;

    }

}
