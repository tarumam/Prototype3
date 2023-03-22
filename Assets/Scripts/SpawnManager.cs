using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    float startDelay = 2.0f, repeatRate = 2.0f;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void spawnObject()
    {
        if (!playerControllerScript.gameOver)
            Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}
