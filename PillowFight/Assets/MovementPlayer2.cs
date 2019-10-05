using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer2 : MonoBehaviour
{
    private float movementSpeed = 0.05f;// Start is called before the first frame update
  void Start()
    {
        
    }

    GameObject FindClosestEnemy() {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("1");
        GameObject closest = gos[0];
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos) {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance) {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }

    // Update is called once per frame
    void Update()

    {
        GameObject enemy = FindClosestEnemy();
        if(Vector2.Distance(enemy.transform.position,transform.position) >1){
        transform.position = Vector3.MoveTowards(transform.position, enemy.transform.position, movementSpeed);
        print(enemy.transform.position);
        }
    }
}