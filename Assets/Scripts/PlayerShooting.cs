using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private GameObject shootingPoint;

    public void OnFire(InputValue inputValue)
    {
        if (inputValue.isPressed)
        {
            Instantiate(bulletPrefab, shootingPoint.transform.position, shootingPoint.transform.rotation);
        }
    }
}
