using UnityEngine;

namespace CheesyScripting
{
    [DisallowMultipleComponent, RequireComponent(typeof(CheesyMonoBehaviour))]
    public class CheesyFixedUpdate : MonoBehaviour {
        [Header("Allows Fixed Update + Late Update Calls")]
        public CheesyMonoBehaviour monoBehaviour;
        private void Awake() {
            TryGetComponent(out monoBehaviour);
        }
        private void LateUpdate() => monoBehaviour.Mono.LateUpdate();
        private void FixedUpdate() => monoBehaviour.Mono.FixedUpdate();
    }
}
