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
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnSpikes();
        }

    }

    void spawnSpikes()
    {
        Instantiate(spike, new Vector3(14, Random.Range(-8f, 8f), 0), transform.rotation);
        timer = 0;
    }
}
