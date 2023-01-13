using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTraps : MonoBehaviour
{
    [SerializeField] GameObject[] traps;
    float x , y;
    int t;
    bool coroutine;
    void Start()
    {
        coroutine = false;
    }

    
    void Update()
    {
        if(!coroutine)
            {
                StartCoroutine(Spawn());
            }
    }

    IEnumerator Spawn()
    {
        coroutine = true;

        x = Random.Range(0f , 3.5f);
        y = Random.Range(-3.15f , (x - 0.5f));
        var pos1 = new Vector2(this.transform.position.x , x);
        var pos2 = new Vector2(this.transform.position.x , y);

        t = Random.Range(0 , traps.Length);
        Instantiate(traps[t] , pos1 , this.transform.rotation);
        
        t = Random.Range(0 , traps.Length);
        Instantiate(traps[t] , pos2 , this.transform.rotation);
        
        yield return new WaitForSeconds(3);

        coroutine = false;
    }
}
