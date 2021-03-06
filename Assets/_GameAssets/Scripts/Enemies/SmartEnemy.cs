using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartEnemy : MobileEnemy {

    [Range(1,50)]
    public float followDistance;

    public override void Update()
    {
        base.Update();//Ejecuta la implementaci n de Update de la clase base
        if (distanceToPlayer <= followDistance)
        {
            Vector3 target = new Vector3(player.transform.position.x, transform.position.y ,player.transform.position.z);
            transform.LookAt(target);
        } 
        Move();
    }
    public override void Rotate()
    {
        if (distanceToPlayer <= followDistance) return;
        base.Rotate();
    }
}
