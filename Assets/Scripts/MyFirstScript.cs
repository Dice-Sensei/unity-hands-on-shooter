using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private bool hasKey;

    [SerializeField]
    private string coolName;

    // Start is called before the first frame update
    private void Start()
    {
        print("On start");
    }

    // Update is called once per frame
    private void Update()
    {
        print("test");
    }
}
