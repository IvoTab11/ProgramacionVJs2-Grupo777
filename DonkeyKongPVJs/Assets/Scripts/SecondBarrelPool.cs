using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondBarrelPool : MonoBehaviour
{
    [SerializeField] private EnemyConfig config;
    [SerializeField] private GameObject secondPrefab;
    [SerializeField] private List<GameObject> secondList;

    private static SecondBarrelPool instance;
    public static SecondBarrelPool Instance {get {return instance;}}
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
      AddBarrelsToPool(config.poolSize);
      StartCoroutine(SpawnBarrels());
    }
    private void AddBarrelsToPool(int amount)
    {
         for(int i = 0; i < amount; i++)
        {
            GameObject secondBarrel = Instantiate(secondPrefab);
            secondBarrel.SetActive(false);
            secondList.Add(secondBarrel);
            secondBarrel.transform.parent = transform;
        }
    }

    public GameObject RequestSecondBarrel()
    {
        for(int i = 0;i < secondList.Count; i++)
        {
            if(!secondList[i].activeSelf)
            {
                secondList[i].SetActive(true);
                return secondList[i];
            }
        }
        return null;
    }

    private IEnumerator SpawnBarrels()
    {
        while (true)
        {
            GameObject secondBarrel = RequestSecondBarrel();
            if (secondBarrel != null)
            {
                // Coloca el barril en la posición del objeto vacío
                //secondBarrel.transform.position = transform.position;
                float randomX = Random.Range(-4.40f, 3.6f);
                Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);
                secondBarrel.transform.position = spawnPosition;
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
