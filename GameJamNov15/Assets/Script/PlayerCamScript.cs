using UnityEngine;
using System.Collections;

public class PlayerCamScript: MonoBehaviour
{

    public GameObject player;
  

    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}