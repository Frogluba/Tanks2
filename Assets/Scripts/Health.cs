using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int hp;
    public int particleCount;
    public GameObject particle;

    public bool autoDestroy;

    public void Damage()
    {
        hp--;
        if (hp == 0) Die() ;
    }
   public void Die()
    {
        for (int i = 0; i < particleCount; i++)
        {
            var offset = Random.insideUnitSphere;
            Instantiate(particle, transform.position + offset, transform.rotation);
        }
        if (autoDestroy) Destroy(gameObject);
    }
   
}
