using UnityEngine;

namespace CheesyScripting {
    public class IgnoreCollision : MonoBehaviour {
        public Collider collider1;
        public Collider collider2;

        public bool ignore = true;

        void Update() =>
        Physics.IgnoreCollision(collider1, collider2, ignore);
    }
}