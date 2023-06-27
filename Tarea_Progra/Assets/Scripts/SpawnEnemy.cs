using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] points;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void InstantiateEnemies()
    {
        int n = Random.Range(0, 5);
        Instantiate(enemy, points[n].transform.position, points[n].transform.rotation);
    }

    private void OnTriggerEnter(Collider other)
    {
        InstantiateEnemies();
    }
}
