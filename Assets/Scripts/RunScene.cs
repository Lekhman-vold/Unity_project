using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunScene : MonoBehaviour
{
    public float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
