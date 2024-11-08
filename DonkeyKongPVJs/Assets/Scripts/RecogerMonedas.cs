using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerMonedas : MonoBehaviour
{
    //int puntos=0;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision){
      if(collision.gameObject.CompareTag("Moneda")){
        FindObjectOfType<GameManager>().AddScore(100);
        //puntos=puntos+1;
        //Debug.Log("Puntos: "+puntos);
        //enabled=false;
        //FindObjectOfType<GameManager>().LevelComplete();

      }
    }
}
