using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Victory : MonoBehaviour
{
    public Text NumeroEnemys;
    public Text EnemysRestantes;
    public int CantidadDeEnemigos;
    public int EnemigosTotales;

    public Menu menu;
    void Start()
    {
        
        CantidadDeEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
        EnemigosTotales = CantidadDeEnemigos;
    }

   
    void Update()
    {
        CantidadDeEnemigos = GameObject.FindGameObjectsWithTag("Enemy").Length;
        NumeroEnemys.text = ("Enemigos Totales: " + EnemigosTotales);
        EnemysRestantes.text = ("Enemigos Restantes: " + CantidadDeEnemigos);
        
        if(CantidadDeEnemigos == (EnemigosTotales-EnemigosTotales))
        {
            victory();
        }
    }

    void victory()
    {
        SceneManager.LoadScene(menu.NivelActual + 1);
        Cursor.lockState = CursorLockMode.Confined;
    }
}
