using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Gestiona la escena de derrota.
public class EscenaPerder : MonoBehaviour
{
    //Permite volver al Menú Principal.
    public void Volver(){
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        //Permite regresar al nivel 1 al presionar la barra espaciadora.
        if(Input.GetKeyDown(KeyCode.Space)){
            //SceneManager.LoadScene(1);
            if((SceneManager.GetActiveScene().buildIndex - 3) == 1){
                SceneManager.LoadScene(1);
            }else{
                SceneManager.LoadScene(2);
            }
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
