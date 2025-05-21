using System.Collections.Generic;
using UltEvents;
using UnityEngine;

namespace CheesyScripting
{
    [System.Serializable]
    public struct CustomMethod {
        public string name;
        public UltEvent method;

        public CustomMethod(string name, UltEvent method) {
            this.name = name.Trim();
            this.method = method;
        }
    }

    [System.Serializable]
    public struct DefaultMethods {
        public UltEvent OnAwake;
        public UltEvent OnStart;
        public UltEvent OnUpdate;
        public UltEvent OnLateUpdate;
        public UltEvent OnFixedUpdate;
    }

    [System.Serializable]
    public struct SpecialMethods {
        public UltEvent<Collision> OnCollisionEnter;
        public UltEvent<Collision> OnCollisionStay;
        public UltEvent<Collision> OnCollisionExit;
        public UltEvent<Collider> OnTriggerEnter;
        public UltEvent<Collider> OnTriggerStay;
        public UltEvent<Collider> OnTriggerExit;
    }

    [System.Serializable]
    public struct FlagGate {
        public string name;
        public bool invert;
        public UltEvent OnTrue;
        public UltEvent OnFalse;
    }

    [System.Serializable]
    public class CheesyMonoScript {
        
        public bool DebugMode = false;

        public DefaultMethods DefaultMethods;

        public SpecialMethods SpecialMethods;

        public List<CustomMethod> CustomMethods;

        public List<FlagGate> FlagGates;

        #region MethodRefs
        public void Awake() {
            if (!Application.isEditor)
                DebugMode = false;
            DefaultMethods.OnAwake.Invoke();
        }
        public void Start() =>
            DefaultMethods.OnStart.Invoke();
        public void Update() =>
            DefaultMethods.OnUpdate.Invoke();
        public void LateUpdate() => DefaultMethods.OnLateUpdate.Invoke();
        public void FixedUpdate() => DefaultMethods.OnFixedUpdate.Invoke();
        public void OnCollisionEnter(Collision collision) => SpecialMethods.OnCollisionEnter.Invoke(collision);
        public void OnCollisionStay(Collision collision) => SpecialMethods.OnCollisionStay.Invoke(collision);
        public void OnCollisionExit(Collision collision) => SpecialMethods.OnCollisionExit.Invoke(collision);
        public void OnTriggerEnter(Collider other) => SpecialMethods.OnTriggerEnter.Invoke(other);
        public void OnTriggerStay(Collider other) => SpecialMethods.OnTriggerStay.Invoke(other);
        public void OnTriggerExit(Collider other) => SpecialMethods.OnTriggerExit.Invoke(other);
        #endregion

        public void CallMethodFromList(string name) {
            foreach (var method in CustomMethods) {
                if (method.name == name) {
                    method.method.Invoke();
                    if (DebugMode)
                        Debug.Log(method);
                    return;
                }
            }
            Debug.Log("Could not find method with name: "+name);
        }
        public void CallFlagGateFromList(string name, object a, object b) {
            foreach (var method in FlagGates) {
                if (method.name == name) {
                    FlagExecute(a, b, method);
                    return;
                }
            }
            Debug.Log("Could not find method with name: " + name);
        }

        private void FlagExecute(object a, object b, FlagGate method) {
            bool equal = a.Equals(b);
            if (method.invert) {
                if (equal)
                    method.OnFalse.Invoke();
                else
                    method.OnTrue.Invoke();
            }
            else {
                if (equal)
                    method.OnTrue.Invoke();
                else
                    method.OnFalse.Invoke();
            }
            if (DebugMode)
                Debug.Log($"Is Equal: {equal} + Method: {method}");
        }
    }
    public struct Math {
        public struct Addition {
            public static int Int(int a, int b) {
                return a + b;
            }
            public static float Float(float a, float b) {
                return a + b;
            }
            public static Vector3 Vector3(Vector3 a, Vector3 b) {
                Vector3 c = a + b;
                return c;
            }
        }
        public struct Subtract {
            public static int Int(int a, int b) {
                return a - b;
            }
            public static float Float(float a, float b) {
                return a - b;
            }
            public static Vector3 Vector3(Vector3 a, Vector3 b) {
                Vector3 c = a - b;
                return c;
            }
        }
        public struct Divide {
            public static int Int(int a, int b) {
                return a / b;
            }
            public static float Float(float a, float b) {
                return a / b;
            }
            public static Vector3 Vector3(Vector3 a, float b) {
                Vector3 c = a / b;
                return c;
            }
        }

        public struct Multiply {
            public static int Int(int a, int b) {
                return a * b;
            }
            public static float Float(float a, float b) {
                return a * b;
            }
            public static Vector3 Vector3(Vector3 a, float b) {
                Vector3 c = a * b;
                return c;
            }
        }
    }
}
