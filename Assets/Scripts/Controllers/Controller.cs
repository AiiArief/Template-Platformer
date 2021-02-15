using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Rigidbody m_rigidbody { get; private set; }

    public Collider m_collider { get; private set; }

    protected Ability[] m_abilities;

    protected virtual void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_collider = GetComponent<Collider>();

        m_abilities = GetComponents<Ability>();
        foreach(Ability ability in m_abilities)
        {
            ability.SetupAbility(this);
        }
    }
}
