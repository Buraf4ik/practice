using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameObject beeronfinish;
    public GameObject BeerinArm;
    public void Finish()
    {
        beeronfinish.SetActive(true);
        BeerinArm.SetActive(false);
    }
}
