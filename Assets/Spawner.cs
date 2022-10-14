using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider spawn)
    {
        if (spawn.gameObject.CompareTag("Player"))
        {   
            target.gameObject.SetActive(true);
            //Instantiate(target, Vector3.zero, Quaternion.identity);
        }
    }
}
