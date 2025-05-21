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

        public void CallFlagFromList(string name, object a = null, object b = null) => Mono.CallFlagGateFromList(name, a, b);

        #region Math
        public int Add(int a, int b) {
            return Math.Addition.Int(a, b);
        }
        public float Add(float a, float b) {
            return Math.Addition.Float(a, b);
        }
        public Vector3 Add(Vector3 a, Vector3 b) {
            return Math.Addition.Vector3(a, b);
        }
        public int Subtract(int a, int b) {
            return Math.Subtract.Int(a, b);
        }
        public float Subtract(float a, float b) {
            return Math.Subtract.Float(a, b);
        }
        public Vector3 Subtract(Vector3 a, Vector3 b) {
            return Math.Subtract.Vector3(a, b);
        }
        public int Multiply(int a, int b) {
            return Math.Multiply.Int(a, b);
        }
        public float Multiply(float a, float b) {
            return Math.Multiply.Float(a, b);
        }
        public Vector3 Multiply(Vector3 a, float b) {
            return Math.Multiply.Vector3(a, b);
        }
        public int Divide(int a, int b) {
            return Math.Divide.Int(a, b);
        }
        public float Divide(float a, float b) {
            return Math.Divide.Float(a, b);
        }
        public Vector3 Divide(Vector3 a, float b) {
            return Math.Divide.Vector3(a, b);
        }
        #endregion

        public void PrintString(string log) {
            print(log.ToString());
        }
        public void PrintLog(object log) {
            print(log.ToString());
        }


        public const object nullobject = null;
        public const bool truebool = true;
        public const bool falsebool = false;
    }
}
