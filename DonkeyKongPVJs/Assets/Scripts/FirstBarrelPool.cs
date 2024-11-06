using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstBarrelPool : MonoBehaviour
{
    [SerializeField] private GameObject barrelPrefab;
    [SerializeField] private int poolSize = 10;
    [SerializeField] private List<GameObject> barrelList;
    [SerializeField] private float spawnInterval = 2f;

    private static FirstBarrelPool instance;
    public static FirstBarrelPool Instance {get {return instance;}}
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
      AddBarrelsToPool(poolSize);
      StartCoroutine(SpawnBarrels());
    }
    private void AddBarrelsToPool(int amount)
    {
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
        for(int i = 0;i < barrelList.Count; i++)
        {
            if(!barrelList[i].activeSelf)
            {
                barrelList[i].SetActive(true);
                return barrelList[i];
            }
        }
        return null;
    }

    private IEnumerator SpawnBarrels()
    {
        while (true)
        {
            GameObject barrel = RequestBarrel();
            if (barrel != null)
            {
                // Coloca el barril en la posición del objeto vacío
                barrel.transform.position = transform.position;
            }
            else
            {
                Debug.Log("No hay barriles disponibles en el pool.");
            }

            // Espera el tiempo definido antes de generar el siguiente barril
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
