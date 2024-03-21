
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public GameObject creditsource;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void credits()
    {
        creditsource.SetActive(true);
    }
    public void back()
    {
        creditsource.SetActive(false);
    }
    public void mm()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); 
    
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
