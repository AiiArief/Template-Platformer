using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityMove : Ability
{
    Rigidbody m_rigidbody;

    public override void SetupAbility(Controller controller)
    {
        m_rigidbody = controller.m_rigidbody;
    }

    public void MoveHorizontal(float hMove)
    {
        m_rigidbody.velocity += new Vector3(hMove, 0.0f);
    }
}
