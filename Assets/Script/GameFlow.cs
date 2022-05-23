using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFlow : MonoBehaviour
{
    public Transform tileObj;
    private Vector3 nextTileSpawn;
    public Transform halanganObj;
    private Vector3 nextHalanganSpawn;
    private int randX;
    public Transform halanganObj2;
    private Vector3 nextHalanganSpawn2;
    public Transform halanganObj3;
    private Vector3 nextHalanganSpawn3;
    public Transform car;
    private Vector3 nextCarSpawn;
    private int randChoice;
    public static int totalCoins = 0;
    public Transform coinObj;
    private Vector3 nextCoinSpawn;
    public Transform mushroom;
    public Transform hamburger;
    public Transform floating;
    private Vector3 nextPotionSpawn;


    public Text scoreText;
    public int score = 0;

    public Text invText;


    //public TMP_Text nilaiMarkah;

    void Start()
    {
        nextTileSpawn.z = 24;
        //nilaiMarkah = GetComponent<TMP_Text>();
        StartCoroutine(spawnTile());
        scoreText.text = totalCoins.ToString() + " POINTS";
    }

    void Update()
    {
        scoreText.text = totalCoins.ToString() + " POINTS";
    }

    IEnumerator spawnTile()
    {
        yield return new WaitForSeconds(1);
        randX = Random.Range(-1, 2);
        nextHalanganSpawn = nextTileSpawn;
        nextHalanganSpawn.y = .2f;
        nextHalanganSpawn.x = randX;
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        Instantiate(halanganObj, nextHalanganSpawn, halanganObj.rotation);

        nextTileSpawn.z += 4;
        randX = Random.Range(-1, 2);
        nextHalanganSpawn2.z = nextTileSpawn.z;
        nextHalanganSpawn2.y = .176f;
        nextHalanganSpawn2.x = randX;
        Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        Instantiate(halanganObj2, nextHalanganSpawn2, halanganObj2.rotation);
        
        if (randX == 0)
        {
            randX = 1;
        }
        else if (randX == 1)
        {
            randX = -1;
        }
        else
        {
            randX = 0;
        }

        randChoice = Random.Range(0, 6);
        if (randChoice == 0)
        {
            nextHalanganSpawn3.z = nextTileSpawn.z;
            nextHalanganSpawn3.y = .3f;
            nextHalanganSpawn3.x = randX;
            Instantiate(halanganObj3, nextHalanganSpawn3, halanganObj3.rotation);
        }
        else if (randChoice == 1)
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = .4f;
            nextCarSpawn.x = randX;
            Instantiate(car, nextCarSpawn, car.rotation);
        }
        else if (randChoice == 2)
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = .35f;
            nextCarSpawn.x = randX;
            Instantiate(coinObj, nextCarSpawn, coinObj.rotation);
        }
        else if (randChoice == 3)
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = .35f;
            nextCarSpawn.x = randX;
            Instantiate(mushroom, nextCarSpawn, mushroom.rotation);
        }
        else if (randChoice == 3)
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = .35f;
            nextCarSpawn.x = randX;
            Instantiate(hamburger, nextCarSpawn, hamburger.rotation);
        }
        else
        {
            nextCarSpawn.z = nextTileSpawn.z;
            nextCarSpawn.y = .35f;
            nextCarSpawn.x = randX;
            Instantiate(floating, nextCarSpawn, floating.rotation);
        }

        //else
        //{
        //    nextCarSpawn.z = nextTileSpawn.z;
        //    nextCarSpawn.y = .35f;
        //    nextCarSpawn.x = randX;
        //    CreateCoins(10);
        //}

        nextTileSpawn.z += 8;
        StartCoroutine(spawnTile());

        //void CreateCoins(int coinsNum)
        //{
        //    for(int i = 0; i < coinsNum; i++)
        //    {
        //        //GameObject CoinClone = Instantiate(coinObj, new Vector3(i, coinObj.position.y, i), coinObj.rotation)
        //        //Instantiate(coinObj, new Vector3(i, coinObj.position.y, i), coinObj.rotation);
        //        Instantiate(coinObj, nextCarSpawn, coinObj.rotation);


        //    }
        //}


        //Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        //nextTileSpawn.z += 4;
        //Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        //nextTileSpawn.z += 4;

        //StartCoroutine(spawnTile());

        //if (randX ==0)
        //{
        //    randX = 1;
        //}
        //else if (randX ==1)
        //{
        //    randX = -1;
        //}
        //else
        //{
        //    randX = 0;
        //}

        //nextHalanganSpawn2.z = nextTileSpawn.z;
        //nextHalanganSpawn2.y = 0;
        //nextHalanganSpawn2.x = randX;
        //Instantiate(halanganObj2, nextHalanganSpawn2, halanganObj.rotation);

        //nextTileSpawn.z += 4;


        //randChoice = Random.Range(0, 2);
        //if (randX == 0)
        //{
        //    nextHalanganSpawn.x = -1.7f;
        //    nextHalanganSpawn2.x = 0f;
        //    nextCoinSpawn.x = 1.3f;
        //}
        //else if (randX == 0)
        //{
        //    nextHalanganSpawn.x = -0.2f;
        //    nextHalanganSpawn2.x = 1.5f;
        //    nextCoinSpawn.x = -1.7f;
        //}
        //else if (randX == 1)
        //{
        //    nextHalanganSpawn.x = 1.3f;
        //    nextHalanganSpawn2.x = -1.5f;
        //    nextCoinSpawn.x = 0;
        //}

        //nextHalanganSpawn.z = nextTileSpawn.z;
        ////nextHalanganSpawn.y = 0.5f;
        //Instantiate(halanganObj, nextHalanganSpawn + new Vector3(0, 0, 0), halanganObj.rotation);

        //randChoice = Random.Range(0, 2);

        //if (randChoice > 7)
        //{
        //    nextHalanganSpawn2.z = nextTileSpawn.z;
        //    nextHalanganSpawn2.y = 0.3f;
        //    //nextHalanganSpawn2.x = randX;
        //    Instantiate(halanganObj2, nextHalanganSpawn2, halanganObj2.rotation);
        //}
        //else
        //{
        //    nextCoinSpawn.z = nextTileSpawn.z;
        //    nextCoinSpawn.y = 0.5f;
        //    //nextHalanganSpawn2.x = randX;
        //    Instantiate(coinObj, nextCoinSpawn, coinObj.rotation);
        //}

        //Instantiate(tileObj, nextTileSpawn, tileObj.rotation);
        //nextTileSpawn.z += 2;

        //nilaiMarkah.text = ScoringSystem.Instance.totalScore.ToString();

        //if (ScoringSystem.Instance.Score > ScoringSystem.Instance.highScore)
        //{
        //    ScoringSystem.Instance.highScore = ScoringSystem.Instance.Score;
        //    ScoringSystem.Instance.totalScore = ScoringSystem.Instance.Score;
        //}
        //else
        //{
        //    ScoringSystem.Instance.highScore1 = ScoringSystem.Instance.highScore;
        //}

        //ScoringSystem.Instance.highScore = 0;


    }
}
