using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class ControlRigidBody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private RigidBodySettings _rigidbodysettings;
        private void Update()
        {
            bool spaceKeyDown = Input.GetKeyDown(KeyCode.Space);
            if(spaceKeyDown)
            {
                _rigidbody.AddForce(_rigidbodysettings.JumpForce, ForceMode.Impulse);
                //Debug.Log("space down"); 
            }
        }
    }
}
