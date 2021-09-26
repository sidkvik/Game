
using UnityEngine;
using UnityEngine.UI;

public class GunScript : MonoBehaviour
{


    public Camera fpsCam;
    public ParticleSystem shooting;
    public GameObject impactEffect;

    public float fireRate = 20f;
    public float impactForce = 30;
    public float damage = 10f;
    public float range = 100f;

    float nextTimeToFire = 0f;
    static public bool shootingIsAllowed = true;

    // Update is called once per frame
    void Update()
    {
       
      if(Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();

        }
    //    GameObject.Find("Kontrola").GetComponent<Text>().text = "Damage je: " + damage.ToString() + " Fire rate je: " + fireRate.ToString() + "\n Impact force je: " + impactForce.ToString() + "\n Range je: " + range.ToString();
    }

    void Shoot()
    {
        if (shootingIsAllowed == true) 
        {
            shooting.Play();
            RaycastHit hit;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
            {
                Debug.Log("You hit " + hit.transform.name);

                targetScript target = hit.transform.GetComponent<targetScript>();
                if (target != null)
                {
                    target.TakeDamage(damage);

                }

                if (hit.rigidbody != null)
                    hit.rigidbody.AddForce(-hit.normal * impactForce);

                GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(impactGO, 2f);
            }
        }
       

    }



}


