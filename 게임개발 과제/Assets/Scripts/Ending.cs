using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending : MonoBehaviour
{
    public GameObject go;

    void OnTriggerStady2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            go.SetActive(true);
        }
    }
}
