using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSShootingControls : MonoBehaviour
{
    private Camera mainCam;
    private float  fireRate = 15f;
    private float nextTimeToFire = 0f;

    [SerializeField]
    private GameObject concrete_Impact;

    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot() {
        if (Input.GetMouseButtonDown(0) && Time.time > nextTimeToFire) {
            nextTimeToFire = Time.time + 1f / fireRate;

            RaycastHit hit;

            if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward, out hit)) {
                // print("We hit" + hit.collider.gameObject.name);
                // print("The position of the object is" + hit.transform.position);
                // print("The point is" + hit.point);
                Instantiate(concrete_Impact, hit.point, Quaternion.LookRotation(hit.normal));
            }
        }
    }


} // class
