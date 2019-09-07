using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform firePoint1;
    public GameObject bulletPrefab1;

    public Transform muzzleFlash;
    public GameObject MuzzleFlashPrefab;

    public Transform muzzleFlash1;
    public GameObject MuzzleFlashPrefab1;

    public float bulletForce = 60f;
    public float bulletForce1 = 15f;

    public float gunFireRate = 0.2F;
    public float missileFireRate = 2f;
    private float nextFire = 0.0F;


    private void Update() {
       

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
                nextFire = Time.time + gunFireRate;
                RightTurretShooting();
        }

        if(Input.GetButtonDown("Fire3") && Time.time > nextFire)
        {
            nextFire = Time.time + missileFireRate;
            LeftTurretShooting();
        }
    }
    
    void RightTurretShooting()
    {
        GameObject muzzleeffect = Instantiate(MuzzleFlashPrefab, muzzleFlash.position, muzzleFlash.rotation);
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 3f);
    }

    void LeftTurretShooting()
    {
        GameObject muzzleeffect1 = Instantiate(MuzzleFlashPrefab1, muzzleFlash1.position, muzzleFlash1.rotation);
        GameObject bullet1 = Instantiate(bulletPrefab1, firePoint1.position, firePoint1.rotation);
        Rigidbody2D rigidbody1 = bullet1.GetComponent<Rigidbody2D>();
        rigidbody1.AddForce(firePoint1.up * bulletForce1, ForceMode2D.Impulse);
        Destroy(bullet1, 3f);
    }
}
