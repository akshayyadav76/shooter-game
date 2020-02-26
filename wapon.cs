using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wapon : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public GameObject projectTile;
    public Transform shotPoint;
    public float timeBetweenShoot;

    private float shotTime;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        float angle=Mathf.Atan2(direction.y,direction.x)*Mathf.Rad2Deg;
        Quaternion rotaion= Quaternion.AngleAxis(angle -90,Vector3.forward);
        transform.rotation = rotaion;
         

         if(Input.GetMouseButton(0)){
             if(Time.time >= shotTime){
                 Instantiate(projectTile,shotPoint.position,transform.rotation);
                 shotTime = Time.time + timeBetweenShoot;
             }
         }

    }
}