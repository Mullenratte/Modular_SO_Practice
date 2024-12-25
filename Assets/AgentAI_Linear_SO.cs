using UnityEngine;

[CreateAssetMenu(fileName = "AgentAI_Linear_SO", menuName = "AgentAI/Linear")]
public class AgentAI_Linear_SO : AgentAI_SO
{
    private float distMoved = 0;
    private Vector3 direction;
    [SerializeField] float maxDist;

    private void OnEnable()
    {
        direction = Vector3.right;
    }

    public override void Move(AgentController controller)
    {
        
        if (Mathf.Abs(distMoved) > maxDist)
        {
            distMoved = direction.x * maxDist;
            direction = -direction;
        }
        controller.transform.position += direction * 10f * Time.deltaTime;
        distMoved += (direction.x * 10f * Time.deltaTime);
    }
}
