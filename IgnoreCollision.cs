using UnityEngine;

namespace CheesyScripting {
    public class IgnoreCollision : MonoBehaviour {
        public Collider collider1;
        public Collider collider2;

        public bool ignore = true;

        void Update() {
            if (Physics.GetIgnoreCollision(collider1, collider2) != ignore)
                Physics.IgnoreCollision(collider1, collider2, ignore);
        }
    }
}