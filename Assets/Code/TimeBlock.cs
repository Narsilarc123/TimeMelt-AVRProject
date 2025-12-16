using UnityEngine;

public class TimeBlock : MonoBehaviour
{
    public float timeBonus = 5f; // Amount of time added when collected

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (GameTimer.instance == null)
            {
                Debug.LogError("GameTimer.instance is NULL!");
                return;
            }

            GameTimer.instance.AddTime(timeBonus);
            Destroy(gameObject);
        }
    }

}
