using UnityEngine;

public class ContactDamager_Chapter16 : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        Life_Chapter16 life = other.GetComponent<Life_Chapter16>();
        if (life != null)
        {
            life.amount -= damage;
        }
    }
}