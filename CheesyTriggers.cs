using UnityEngine;

namespace CheesyScripting
{
    [DisallowMultipleComponent]
    public class CheesyTriggers : MonoBehaviour
    {
        [Header("Allows OnCollision Calls")]
        public CheesyMonoBehaviour monoBehaviour;
        private void Awake() {
            monoBehaviour = GetComponentInParent<CheesyMonoBehaviour>();
        }
        private void OnTriggerEnter(Collider other) => monoBehaviour.Mono.OnTriggerEnter(other);
        private void OnTriggerStay(Collider other) => monoBehaviour.Mono.OnTriggerStay(other);
        private void OnTriggerExit(Collider other) => monoBehaviour.Mono.OnTriggerExit(other);
    }
}
