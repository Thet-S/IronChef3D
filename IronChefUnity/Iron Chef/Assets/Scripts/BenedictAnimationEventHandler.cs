using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BenedictAnimationEventHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HitOn()
    {
        GetComponentInParent<EnemyBasicAttackbox>().HitOn();
    }
    public void HitOff()
    {
        GetComponentInParent<EnemyBasicAttackbox>().HitOff();
    }

    public void EggRollSound()
    {
        FindObjectOfType<SoundEffectSpawner>().MakeSoundEffect(transform.position, SoundEffectSpawner.SoundEffect.EggRoll);
    }
}