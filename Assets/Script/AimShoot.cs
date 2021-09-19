using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AimShoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform fireAim;
    public float bulletSpeed = 50;

    Vector2 lookDirection;
    float lookAngle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      lookDirection = Camera.main.WorldToScreenPoint(Input.mousePosition);
      lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;

      fireAim.rotation = Quaternion.Euler(0, 0, lookAngle);

      if(Input.GetMouseButtonDown(0)){
          GameObject bulletClone = Instantiate(bullet);
          bulletClone.transform.position = fireAim.position;
          bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

        bulletClone.GetComponent<Rigidbody2D>().velocity = fireAim.right * bulletSpeed;
      }
    }
}
