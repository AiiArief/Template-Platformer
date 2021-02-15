using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    AbilityMove m_move;

    protected override void Awake()
    {
        base.Awake();

        m_move = GetComponent<AbilityMove>();
    }

    private void FixedUpdate()
    {
        m_move.MoveHorizontal(Input.GetAxis("Horizontal"));
    }
}
