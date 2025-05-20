using System;
using System.Collections.Generic;
using System.Linq;
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
        public UltEvent<Collision> OnCollisionExit;
        public UltEvent<Collider> OnTriggerEnter;
        public UltEvent<Collider> OnTriggerExit;
    }

    [System.Serializable]
    public struct CustomVariable {
        public string name;
        private object value;
        public void SetValue(object value) {
            this.value = value;
        }
        public object GetValue() {
            return value;
        }
    }

    [System.Serializable]
    public class CheesyMonoScript {

        public DefaultMethods DefaultMethods;

        public SpecialMethods SpecialMethods;

        public List<CustomMethod> CustomMethods;
        public List<CustomVariable> CustomVariables;

        #region MethodRefs
        public void Awake() => DefaultMethods.OnAwake.Invoke();
        public void Start() => DefaultMethods.OnStart.Invoke();
        public void Update() => DefaultMethods.OnUpdate.Invoke();
        public void LateUpdate() => DefaultMethods.OnLateUpdate.Invoke();
        public void FixedUpdate() => DefaultMethods.OnFixedUpdate.Invoke();
        public void OnCollisionEnter(Collision collision) => SpecialMethods.OnCollisionEnter.Invoke(collision);
        public void OnCollisionExit(Collision collision) => SpecialMethods.OnCollisionExit.Invoke(collision);
        public void OnTriggerEnter(Collider other) => SpecialMethods.OnTriggerEnter.Invoke(other);
        public void OnTriggerExit(Collider other) => SpecialMethods.OnTriggerExit.Invoke(other);
        #endregion

        public void CallMethodFromList(string name) {
            foreach (var method in CustomMethods) {
                if (method.name == name) {
                    method.method.Invoke();
                    return;
                }
            }
            Debug.Log("Could not find method with name: "+name);
        }

        public void SetVariable(string name, object value, int index) {
            var var = new CustomVariable();
            var.name = name;
            var.SetValue(value);
            CustomVariables.Insert(index, var);
        }

        public object GetVariable(int index) => CustomVariables.ToArray().GetValue(index);
    }
}
