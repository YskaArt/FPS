using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour
{
    [SerializeField] private float MaxTempo;
    public Faia disparo;
    private float TiempoActual;
    public GameObject GameOver;
    public ControllerVisor POV;
    public bool TiempoActivo = false;
    [SerializeField] private Slider slider;
    [SerializeField] private BoxCollider trigger;

    private void Update()
    {
        if (TiempoActivo)
        {
            Contador();
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActivarTemporizador();
            TiempoActivo = true;
            trigger.enabled = false;
        }

    }
    

    private void Contador ()
    {
        TiempoActual -= Time.deltaTime;

        if(TiempoActual >= 0)
        {
            slider.value = TiempoActual;

        }

        if(TiempoActual <= 0)
        {
            Time.timeScale = 0f;
            GameOver.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            Debug.Log("Derrota");
            TiempoActivo = false;
            disparo.enabled = false;
            POV.enabled = false;
        }

    }
   
    public void ActivarTemporizador()
    {
        TiempoActual = MaxTempo;
        slider.maxValue = MaxTempo;
       

    }
  





}

