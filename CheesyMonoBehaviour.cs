using UnityEngine;

namespace CheesyScripting
{
    public class CheesyMonoBehaviour : MonoBehaviour
    {
        public CheesyMonoScript Mono;

        void Awake() => Mono.Awake();
        void Start() => Mono.Start();
        void Update() => Mono.Update();
        private void LateUpdate() => Mono.LateUpdate();
        private void FixedUpdate() => Mono.FixedUpdate();
        private void OnCollisionEnter(Collision collision) => Mono.OnCollisionEnter(collision);
        private void OnCollisionExit(Collision collision) => Mono.OnCollisionExit(collision);
        private void OnTriggerEnter(Collider other) => Mono.OnTriggerEnter(other);
        private void OnTriggerExit(Collider other) => Mono.OnTriggerExit(other);
        public void CallMethodFromList(string name) => Mono.CallMethodFromList(name);

        public void PrintString(string log) {
            print(log.ToString());
        }
        public void PrintLog(object log) {
            print(log.ToString());
        }
    }
}
