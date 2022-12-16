using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {

        [SerializeField] float jumpForce = 400f;
        
        Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }
        void Update()
        {
            if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
            {
                _rigidbody2D.velocity = (Vector2.zero);
                _rigidbody2D.AddForce(Vector2.up * jumpForce);
            }
            
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            GameManager.Instance.RestartGame();
        }
    }


}
