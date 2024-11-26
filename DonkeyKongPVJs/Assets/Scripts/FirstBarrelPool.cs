using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBarrelPool : MonoBehaviour
{
    [SerializeField] private EnemyConfig config;
    /** Prefab del barril a instanciar en el pool*/
    [SerializeField] private GameObject barrelPrefab;
     /** Lista para almacenar los barriles del pool */
    [SerializeField] private List<GameObject> barrelList;

    /** Instancia única del pool (Singleton) */
    private static FirstBarrelPool instance;
    /** Propiedad para acceder al Singleton desde otras clases*/
    public static FirstBarrelPool Instance {get {return instance;}}
    private void Awake()
    {
        // Asegura que solo haya una instancia de FirstBarrelPool en la escena
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            // Destruye cualquier instancia duplicada
            Destroy(gameObject);
        }
    }
    void Start()
    {
      // Agrega barriles al pool al iniciar
      AddBarrelsToPool(config.poolSize);
      // Comienza a generar barriles de manera periódica
      StartCoroutine(SpawnBarrels());
    }
    private void AddBarrelsToPool(int amount)
    {
        // Instancia 'amount' de barriles y los desactiva para almacenarlos en el pool
         for(int i = 0; i < amount; i++)
        {
            GameObject barrel = Instantiate(barrelPrefab);
            barrel.SetActive(false);
            barrelList.Add(barrel);
            barrel.transform.parent = transform;
        }
    }

    public GameObject RequestBarrel()
    {
        // Busca un barril desactivado en la lista del pool
        for(int i = 0;i < barrelList.Count; i++)
        {
            if(!barrelList[i].activeSelf)
            {
                // Activa el barril encontrado
                barrelList[i].SetActive(true);
                return barrelList[i];
            }
        }
        return null;
    }

    // Rutina que genera barriles en intervalos definidos
    private IEnumerator SpawnBarrels()
    {
        while (true)
        {
            // Solicita un barril del pool
            GameObject barrel = RequestBarrel();
            if (barrel != null)
            {
                // Coloca el barril en la posición del BarrelPool
                barrel.transform.position = transform.position;
            }
            else
            {
                Debug.Log("No hay barriles disponibles en el pool.");
            }

            // Espera el tiempo definido antes de generar el siguiente barril
            yield return new WaitForSeconds(config.spawnInterval);
        }
    }
}
