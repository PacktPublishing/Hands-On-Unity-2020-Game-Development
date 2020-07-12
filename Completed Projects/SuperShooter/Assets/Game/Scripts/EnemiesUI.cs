using UnityEngine;
using UnityEngine.UI;

public class EnemiesUI : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
        EnemyManager.instance.onChanged.AddListener(RefreshText);
    }

    void RefreshText()
    {
        text.text = "Remaining Enemies: " + EnemyManager.instance.enemies.Count;
    }
}