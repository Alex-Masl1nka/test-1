using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public GameObject sphere;
    public GameObject example;
    public Transform SpawnPoint;
    void Start()
    {
        
    }
    
    //void Inst()
    //{
    //    cube = Instantiate(example, SpawnPoint.position, SpawnPoint.rotation, transform);
    //    cube.GetComponent<MeshRenderer>().material.color = Color.green;
    //}
    void Update()
    {
        sphere = Instantiate(example, SpawnPoint.position, SpawnPoint.rotation, transform);
        sphere.GetComponent<MeshRenderer>().material.color = Color.green;
        Rigidbody rig = sphere.GetComponent<Rigidbody>();
        rig.useGravity = true;

    }
    //void Destr()
    //{
    //    Destroy(cube, 2);
    //}
    //void EnDisable()
    //{
    //    cube.SetActive(!(cube.activeSelf));
    //}
    //void ObjAndComp()
    //{
    //    cube.GetComponent<MeshRenderer>().material.color = Color.green;
    //}
}
