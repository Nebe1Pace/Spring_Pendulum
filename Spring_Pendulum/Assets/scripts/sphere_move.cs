using UnityEngine;
using System.Collections;

public class sphere_move : MonoBehaviour {

    void Update()
    {
        transform.Translate(new Vector3(0,Mathf.Sin(Time.realtimeSinceStartup / 10 * Mathf.PI * 2f), 0));
    }
}
