using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Ball")
        {
            Debug.Log("GOL!");
        }
    }
}
