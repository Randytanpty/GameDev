using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSWeapon : MonoBehaviour
{

    private GameObject muzzleFlash;
    // Start is called before the first frame update
    void Awake()
    {
        muzzleFlash = transform.Find("MuzzleFlash").gameObject;
        muzzleFlash.SetActive(false);
    }

    public void shoot() {
        StartCoroutine(TurnOnMuzzleFlash());
    }

    IEnumerator TurnOnMuzzleFlash() {
        muzzleFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        muzzleFlash.SetActive(false);
    }
} // class
