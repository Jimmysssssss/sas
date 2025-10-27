using UnityEngine;

namespace ReadyToPlay
{
    /// <summary>
    /// Simple player controller that moves a cube on the X/Z plane using WASD or arrow keys
    /// and collects coins for score.
    /// </summary>
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private float moveSpeed = 5f;

        [SerializeField]
        private int scorePerPickup = 1;

        private int score;
        private Vector3 input;
        private Rigidbody rb;

        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.z = Input.GetAxisRaw("Vertical");
            input.y = 0f;
        }

        private void FixedUpdate()
        {
            var velocity = input.normalized * moveSpeed;
            var targetPosition = rb.position + velocity * Time.fixedDeltaTime;
            rb.MovePosition(targetPosition);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (!other.CompareTag("Pickup"))
            {
                return;
            }

            score += scorePerPickup;
            Destroy(other.gameObject);
            Debug.Log($"Score: {score}");
        }
    }
}
