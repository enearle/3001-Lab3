using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerpLerp : MonoBehaviour
{
    private List<Vector3> path = new List<Vector3>();
    private int pathIndex = 0;
    private float time = 0.0f;

    public void Initialize(List<Vector3> inPath)
    {
        path = new List<Vector3>(inPath);
    }
    protected virtual void Update()
    {
        if (pathIndex >= path.Count)
        {
            Destroy(gameObject);
            return;
        }
        
        time += Time.deltaTime * 5;
        transform.position = Vector3.Lerp(transform.position, path[pathIndex], time);
        if (time >= 1)
        {
            transform.position = path[pathIndex];
            time = 0;
            pathIndex++;
        }   
    }
}
