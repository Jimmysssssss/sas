using UnityEngine;

namespace ReadyToPlay
{
    /// <summary>
    /// Spawns pickups around the play area when the scene starts.
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        [SerializeField]
        private int pickupCount = 8;

        [SerializeField]
        private Vector2 areaSize = new Vector2(8f, 8f);

        [SerializeField]
        private Color pickupColor = new Color(1f, 0.85f, 0.2f);

        private void Start()
        {
            for (var i = 0; i < pickupCount; i++)
            {
                SpawnPickup();
            }
        }

        private void SpawnPickup()
        {
            var position = new Vector3(
                Random.Range(-areaSize.x * 0.5f, areaSize.x * 0.5f),
                0.5f,
                Random.Range(-areaSize.y * 0.5f, areaSize.y * 0.5f));

            var pickup = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            pickup.name = "Pickup";
            pickup.tag = "Pickup";
            pickup.transform.SetParent(transform);
            pickup.transform.position = position;
            pickup.transform.localScale = Vector3.one * 0.5f;

            var renderer = pickup.GetComponent<Renderer>();
            renderer.material = new Material(renderer.sharedMaterial)
            {
                color = pickupColor
            };

            var collider = pickup.GetComponent<SphereCollider>();
            collider.isTrigger = true;

            pickup.AddComponent<PickupRotator>();
        }
    }
}
