using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningDead : MonoBehaviour
{

    private string laneChange = "n";
    private string midJump = "n";
    public APISystem api;

    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
    }

    void Update()
    {
        if ((Input.GetKey("a")) && (laneChange == "n") && (transform.position.x > -.9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 5);
            laneChange = "y";
            StartCoroutine(stopLaneCh());
        }

        if ((Input.GetKey("d")) && (laneChange == "n") && (transform.position.x < .9) && (midJump == "n"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(1, 0, 5);
            laneChange = "y";
            StartCoroutine(stopLaneCh());

        }

        if ((Input.GetKey("space")) && (midJump == "n") && (laneChange == "n"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 1, 5);
            midJump = "y";
            StartCoroutine(stopJump());
        }
    }

    IEnumerator stopJump()
    {
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, -1, 5);
        yield return new WaitForSeconds(.75f);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        midJump = "n";

    }

    IEnumerator stopLaneCh()
    {
        yield return new WaitForSeconds(1);
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        laneChange = "n";
       // Debug.Log(GetComponent<Transform>().position);

    }

    void PauseGame()
    {
        Time.timeScale = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "obstacle")
        {
            //Debug.Log("Game Over");
            //PlayerManager.isGameOver = true;
            //gameObject.SetActive(false);
            
            StartCoroutine(saveScore());

        }
        
    }

    IEnumerator saveScore()
    {
        yield return new WaitForSeconds(.1f);
        //FindObjectOfType<APISystem>().InsertPlayerActivity(PlayerPrefs.GetString("username"), "Score_Point_Endless", "add", ScoreManager.instance.ToString());
        FindObjectOfType<APISystem>().InsertPlayerActivity(PlayerPrefs.GetString("username"), "rankPoint", "add", GameFlow.totalCoins.ToString());

       
        Time.timeScale = 0;

        Debug.Log("Game Over");
        PlayerManager.isGameOver = true;
        gameObject.SetActive(false);
    }

}
