using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventsHandler : MonoBehaviour
{
    public PlayerAttackController playerAttacks;
    public PlayerPower power;
    public CharacterMover characterMover;

    private void Awake()
    {
        playerAttacks = GetComponentInParent<PlayerAttackController>();
        characterMover = GetComponentInParent<CharacterMover>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (power == null)
            power = FindObjectOfType<PlayerPower>();
    }

    public void BasicHitOn()
    {
        playerAttacks.BasicHitOn();
    }
    public void BasicHitOff()
    {
        playerAttacks.BasicHitOff();
    }
    public void DoPowerEffects()
    {
        power.DoPowerEffects();
    }
    public void DeactivateBasicWeapon()
    {
        playerAttacks.DeactivateBasicWeapon();
    }
    public void PerformFryingPan()
    {
        playerAttacks.PerformFryingPan();
    }

    public void UndoRoll()
    {
        characterMover.UndoRoll();
    }
}