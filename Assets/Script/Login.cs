using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Login : MonoBehaviour
{
    public Text userName;
    public APISystem api;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void savePlayerName(string sceneMenu)
    {
        if( string.IsNullOrEmpty(userName.text))
        {
            Debug.Log("Enter the username");
        }
        else
        {
            PlayerPrefs.SetString("username", userName.text);
            FindObjectOfType<APISystem>().Register(userName.text, userName.text, userName.text, userName.text);
            Debug.Log(userName.text);
            Debug.Log("My name is : " + PlayerPrefs.GetString("username"));
            SceneManager.LoadScene(sceneMenu);
        }
    }

    public void MainMenuScreen()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("MainMenu");
    }

    public void GameScreen()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("EndlessRunning");
    }

    public void PUN()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("PunScreen");
    }

    public void LoginScreen()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Login");
    }

    public void LeaderboardScreen()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("Login");
    }

}
