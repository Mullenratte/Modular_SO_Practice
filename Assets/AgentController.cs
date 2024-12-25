using UnityEngine;

public class AgentController : MonoBehaviour
{
    [SerializeField] AgentAI_SO currentBehaviour;
    [SerializeField] AgentAI_SO idleBehaviour;
    [SerializeField] AgentAI_SO patrolBehaviour;

    private void Start()
    {
        currentBehaviour = idleBehaviour;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentBehaviour = idleBehaviour;
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            currentBehaviour = patrolBehaviour;
        }

        currentBehaviour.Move(this);
    }
}
