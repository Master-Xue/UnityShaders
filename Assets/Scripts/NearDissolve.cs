using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearDissolve : MonoBehaviour
{
    private Material mat;

    public Transform targetObj;

    private void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        mat.SetVector("_TargetPos", targetObj.position);
    }
}
