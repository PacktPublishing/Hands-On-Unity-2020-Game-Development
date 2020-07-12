using UnityEngine;

public class ScoreOnDeath : MonoBehaviour
{
    public int amount;

    void Awake()
    {
        var life = GetComponent<Life>();
        life.onDeath.AddListener(GivePoints);
    }

    void GivePoints()
    {
        ScoreManager.instance.amount += amount;
    }
}