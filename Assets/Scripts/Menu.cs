using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   

    [SerializeField] public int NivelActual;
    public void Play()
    {

        SceneManager.LoadScene(NivelActual + 1);

    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Salir. . .");

    }

    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
