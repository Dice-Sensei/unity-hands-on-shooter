using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    [SerializeField]
    private float delay;

    // Start is called before the first frame update
    private void Start()
    {
        Destroy(gameObject, delay);
    }
}
