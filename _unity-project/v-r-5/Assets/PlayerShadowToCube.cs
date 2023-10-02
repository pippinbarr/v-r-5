using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShadowToCube : MonoBehaviour
{
    public MeshFilter mesh;

    public Mesh[] meshes;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        mesh.mesh = meshes[1];
    }
}
