using UnityEngine;

namespace PlayerScripts
{
    public class PlayerGun : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, transform.position + transform.forward);
        }
    }
}
