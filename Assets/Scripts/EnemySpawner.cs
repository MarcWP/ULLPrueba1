using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public List<GameObject> Enemies;
    private int index;
    Vector3 pos;
    public float timing;
    // Start is called before the first frame update
    void Awake()
    {
        InvokeRepeating("spawn", 0f, timing);
    }

    // Instanciamos enemigos en posiciones aleatorias
    void spawn()
    {
        pos = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F),0);
        index=Random.Range(0, 1);
        Instantiate(Enemies[index], pos, new Quaternion(0,0,0,0));
    }
}
