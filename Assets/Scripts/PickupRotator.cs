using UnityEngine;

namespace ReadyToPlay
{
    /// <summary>
    /// Rotates the attached object for a simple visual effect.
    /// </summary>
    public class PickupRotator : MonoBehaviour
    {
        [SerializeField]
        private Vector3 rotationSpeed = new Vector3(0f, 90f, 0f);

        private void Update()
        {
            transform.Rotate(rotationSpeed * Time.deltaTime, Space.World);
        }
    }
}
