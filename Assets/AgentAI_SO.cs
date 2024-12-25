using UnityEngine;
using UnityEngine.InputSystem.XR;

public abstract class AgentAI_SO : ScriptableObject
{
    public abstract void Move(AgentController controller);
}
