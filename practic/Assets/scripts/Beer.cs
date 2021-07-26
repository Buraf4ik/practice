using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beer : MonoBehaviour
{

    public GameObject beer;
    public GameObject BeerinArm;

  public void OnHit()
    {
        beer.SetActive(false);
        BeerinArm.SetActive(true);
    }
    
}
