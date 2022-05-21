using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;

    private void Awake()
    {
        isGameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            gameOverScreen.SetActive(true);
            //FindObjectOfType<APISystem>().InsertPlayerActivity(PlayerPrefs.GetString("username"), "Score_Point_Endless", "add", ScoreManager.instance.ToString());
            //FindObjectOfType<APISystem>().InsertPlayerActivity(PlayerPrefs.GetString("username"), "Score_Point_Endless", "add", ScoreManager.instance.scoreText.ToString());


        }
    }

    public void ReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void leaderboardScreen()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Leaderboard2");
    }

    public void MainMenuScreen()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SceneManager.LoadScene("MainMenu");
    }

    public void changeScene(string value)
    {
        SceneManager.LoadScene(value);
    }

}
