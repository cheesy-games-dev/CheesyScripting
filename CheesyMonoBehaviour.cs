using UnityEngine;

namespace CheesyScripting
{
    public class CheesyMonoBehaviour : MonoBehaviour
    {
        public CheesyMonoScript Mono;

#region Methods
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
#endregion

        #region Variable
        public void SetVariable(object value, int index) => Mono.SetVariable(value, index);
        public object GetVariable(int index) => Mono.GetVariable(index);

        public string IGetVariable(int index) => GetVariable(index).ToString();

        public void ISetVariable(Object value, int index) => SetVariable(value, index);
        public void ISetVariable(int value, int index) => SetVariable(value, index);
        public void ISetVariable(float value, int index) => SetVariable(value, index);
        public void ISetVariable(string value, int index) => SetVariable(value, index);
        public void ISetVariable(bool value, int index) => SetVariable(value, index);
        public void ISetVariable(Vector2 value, int index) => SetVariable(value, index);
        public void ISetVariable(Vector3 value, int index) => SetVariable(value, index);
        public void ISetVariable(Quaternion value, int index) => SetVariable(value, index);
        #endregion

        public void PrintString(string log) {
            print(log.ToString());
        }
        public void PrintLog(object log) {
            print(log.ToString());
        }
    }
}
