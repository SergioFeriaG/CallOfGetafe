using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeasantManAnimationEvent : MonoBehaviour
{
    public void ActivateFollowEvent()
    {
        SmartFinalEnemy.smartFinalEnemy.FinalEnemyActivator();
    }
}
