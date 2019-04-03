using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject StarPrefab;

    public Vector3 center;
    public Vector3 size;
    public bool SpawnIsTrigger = false;
    private float nextActionTime = 0.0f;
    public float period = 10.0f; //Time period to spawn the star


    // Update is called once per frame
    void Update()
    {
        if (SpawnIsTrigger == true)
        {
            if (Time.time > nextActionTime)
            {
                nextActionTime += period;
                SpawnStar();
            }
        }
    }

    public void SpawnTrigger(){
        SpawnIsTrigger = true;
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
