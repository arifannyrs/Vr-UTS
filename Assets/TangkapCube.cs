using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangkapCube : MonoBehaviour
{
    public GameObject cube;
    public GameObject tangan;

    bool tertangkap = false;
    Vector3 posisiCube;
    // Start is called before the first frame update
    void Start()
    {
        posisiCube = cube.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if(!tertangkap){
            cube.transform.SetParent(tangan.transform);
            cube.transform.localPosition = new Vector3(0f, -.672f,0f);
            tertangkap = true;
            } else if (tertangkap){
                cube.transform.SetParent(null);
                cube.transform.localPosition = posisiCube;
                tertangkap = false;
            }
        }
    }
}
