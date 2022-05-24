using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GoPlay()
    {
        SceneManager.LoadScene("Login");
    }

    public void leaderboard()
    {
        SceneManager.LoadScene("Leaderboard");
    }

    public void StorytellingScreen()
    {
        SceneManager.LoadScene("Storytelling");
    }

}
