using UnityEngine;

[CreateAssetMenu(fileName = "AgentAI_Circular_SO", menuName = "AgentAI/Circular")]
public class AgentAI_Circular_SO : AgentAI_SO
{
    private float degrees = 0;
    public override void Move(AgentController controller)
    {
        float rad = Mathf.Deg2Rad * degrees;
        Vector3 direction = new Vector3(Mathf.Cos(rad), Mathf.Sin(rad), 0f).normalized;
        controller.transform.position += direction * 10f * Time.deltaTime;
        degrees = (degrees + 1) % 360;
    }
}
