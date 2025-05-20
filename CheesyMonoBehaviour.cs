using UnityEngine;
using System.Collections.Generic;

namespace CheesyScripting
{
    [DisallowMultipleComponent]
    public class CheesyMonoBehaviour : MonoBehaviour
    {
        [Header("To use methods other then Awake, Start, and Update\nAdd the component with the matching name!\n-CheesyFixedUpdate\n-CheesyCollisions\n-CheesyTriggers")]
        public CheesyMonoScript Mono;

        public static List<CheesyMonoBehaviour> MonoBehaviours = new();

        void Awake() => Mono.Awake();
        void Start() {
            MonoBehaviours.Add(this);
            Mono.Start(); 
        }
        void Update() {
            Mono.Update();
        }

        // Use CheesyFixedUpdate
        //private void LateUpdate() => Mono.LateUpdate();
        //private void FixedUpdate() => Mono.FixedUpdate();

        // Use CheesyCollisions
        //private void OnCollisionEnter(Collision collision) => Mono.OnCollisionEnter(collision);
        //private void OnCollisionStay(Collision collision) => Mono.OnCollisionStay(collision);
        //private void OnCollisionExit(Collision collision) => Mono.OnCollisionExit(collision);

        // Use CheesyTriggers
        //private void OnTriggerEnter(Collider other) => Mono.OnTriggerEnter(other);
        //private void OnTriggerStay(Collider other) => Mono.OnTriggerStay(other);
        //private void OnTriggerExit(Collider other) => Mono.OnTriggerExit(other);

        public void CallMethodFromList(string name) => Mono.CallMethodFromList(name);
        public Vector3 MultiplyVector3(Vector3 a, float b) {
            return Mono.MultiplyVector3(a, b);
        }
        public void PrintString(string log) {
            print(log.ToString());
        }
        public void PrintLog(object log) {
            print(log.ToString());
        }
    }
}
