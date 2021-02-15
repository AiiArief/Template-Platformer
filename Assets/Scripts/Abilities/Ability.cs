using System.Collections;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    protected Controller m_controller { get; set; }

    public abstract void SetupAbility(Controller controller);
}