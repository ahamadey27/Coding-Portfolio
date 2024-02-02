using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps; 

public class CameraController : MonoBehaviour
{

    public Transform target; 
    public Tilemap theMap; 
    private Vector3 bottomLeftLimit; 
    private Vector3 topRightLimit; 
    private float halfHeight; 
    private float halfWidth; 
    
    void Start()
    {
        target = PlayerController.instance.transform; 

        halfHeight = Camera.main.orthographicSize; 
        halfWidth = halfHeight * Camera.main.aspect; 

        bottomLeftLimit = theMap.localBounds.min + new Vector3(halfWidth, halfHeight, 0f); 
        topRightLimit = theMap.localBounds.max + new Vector3(-halfWidth, -halfHeight, 0f ); 
    }

    void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z); 

        //Keep the camera inside the bounds 
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z); 

    }
}
