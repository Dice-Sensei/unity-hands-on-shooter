using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float startTime;

    [SerializeField]
    private float endTime;

    [SerializeField]
    private float spawnRate;

    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating(nameof(Spawn), startTime, spawnRate);
        Invoke(nameof(CancelInvoke), endTime);
    }

    private void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
