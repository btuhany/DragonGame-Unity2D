using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mover
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] float moveSpeed=5f;
        [SerializeField] bool moveToRight;
        Rigidbody2D _rigidbody2D;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        private void Start()
        {
            if(moveToRight)
                _rigidbody2D.velocity = Vector2.right * moveSpeed;
            else
                _rigidbody2D.velocity = Vector2.left * moveSpeed;

        }
    }
}

