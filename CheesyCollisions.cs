using UnityEngine;

namespace CheesyScripting 
{
    [DisallowMultipleComponent]
    public class CheesyCollisions : MonoBehaviour {
        [Header("Allows OnCollision Calls")]
        public CheesyMonoBehaviour monoBehaviour;
        private void Awake() {
            monoBehaviour = GetComponentInParent<CheesyMonoBehaviour>();
        }
        private void OnCollisionEnter(Collision collision) => monoBehaviour.Mono.OnCollisionEnter(collision);
        private void OnCollisionStay(Collision collision) => monoBehaviour.Mono.OnCollisionStay(collision);
        private void OnCollisionExit(Collision collision) => monoBehaviour.Mono.OnCollisionExit(collision);
    }
}
