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
        public void SetVariable(string name, object value, int index) => Mono.SetVariable(name, value, index);
        public object GetVariable(int index) => Mono.GetVariable(index);

        public string IGetVariable(int index) => GetVariable(index).ToString();

        public void ISetVariable(string name, Object value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, int value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, float value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, string value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, bool value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, Vector2 value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, Vector3 value, int index) => SetVariable(name, value, index);
        public void ISetVariable(string name, Quaternion value, int index) => SetVariable(name, value, index);
        #endregion

        public void PrintString(string log) {
            print(log.ToString());
        }
    }
}
