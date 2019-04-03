using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject StarPrefab;

    public Vector3 center;
    public Vector3 size;




    // Start is called before the first frame update
    void Start()
    {
        //SpawnStar();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            SpawnStar();
    }

    public void SpawnStar(){
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2,size.x/2),Random.Range(-size.y / 2, size.y / 2),Random.Range(-size.z / 2, size.z / 2));
        Instantiate(StarPrefab, pos, Quaternion.identity);
    
    }
    void OnDrawGizmosSeclected(){
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center,size);
    }
}
