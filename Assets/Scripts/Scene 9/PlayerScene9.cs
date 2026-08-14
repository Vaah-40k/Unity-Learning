using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScene9 : MonoBehaviour
{
    private Scene9 input;

    private List<GameObject> bullets = new List<GameObject>();

    [SerializeField]
    private int countBullets = 10;

    [SerializeField]
    private float speedPlayer = 5f;

    [SerializeField]
    private float speedBullet = 3f;

    [SerializeField]
    private GameObject bulletPrefab;

    private void Awake()
    {
        input = new Scene9();
        for (int i = 0; i < countBullets; ++i)
        {
            GameObject bullet = Instantiate(
                bulletPrefab,
                transform.position,
                bulletPrefab.transform.rotation
            );
            bullet.SetActive(false);
            bullets.Add(bullet);
        }
    }

    private GameObject GetBullet()
    {
        for (int i = 0; i < bullets.Count; i++)
        {
            if (!bullets[i].activeSelf)
            {
                return bullets[i];
            }
        }
        return null;
    }

    private void OnEnable()
    {
        input.Player.Shot.performed += Shoot;
        input.Player.Enable();
    }

    private void OnDisable()
    {
        input.Player.Shot.performed -= Shoot;
        input.Player.Disable();
    }

    private void Update()
    {
        Move();
    }

    private void Shoot(InputAction.CallbackContext context)
    {
        GameObject bullet = GetBullet();
        if (bullet == null)
            return;
        bullet.transform.position = transform.position + Vector3.forward;
        bullet.SetActive(true);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(0, 0, speedBullet);
    }

    private void Move()
    {
        Vector2 receivedData = input.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(receivedData.x, 0, receivedData.y);
        transform.position += move * speedPlayer * Time.deltaTime;
    }
}
