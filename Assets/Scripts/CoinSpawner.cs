using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Coin;
    [SerializeField] private float CoinSpawnTime;

    private void SpawnCoins()
    {
        Instantiate(Coin, transform.position, transform.rotation);
        CoinSpawnTime = Random.Range(.2f,.8f);
    }

    void Update()
    {
        CoinSpawnTime -= Time.deltaTime;
       if (CoinSpawnTime <= 0)
        {
            SpawnCoins();
        }
    }
}
