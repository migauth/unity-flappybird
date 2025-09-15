using UnityEngine;

public class SpikeSpawnScript : MonoBehaviour
{

    public GameObject spike;
    public float spawnRate = 2;
    private float timer = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(spike, transform.position, transform.rotation);
    }
}
