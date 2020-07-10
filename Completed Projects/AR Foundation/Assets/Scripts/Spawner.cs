    

    using UnityEngine;

    public class Spawner : MonoBehaviour
    {
        public GameObject prefab;
        public float frequency;
        void Awake()
        {
            InvokeRepeating("Spawn", frequency ,frequency);
        }

        void Spawn()
        {
            var obj = Instantiate(prefab, transform.position, transform.rotation);
            Physics.IgnoreCollision(GetComponentInChildren<Collider>(), obj.GetComponentInChildren<Collider>());
        }
    }