using UnityEngine;

public class ForwardMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
