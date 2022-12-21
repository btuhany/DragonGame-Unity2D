using Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mechanics;

namespace Controllers
{
    public class PlayerController : MonoBehaviour
    {

   
        bool _isMouseClickedOrSpacePressed;
        bool _isRightMouseClickedOrFPressed;
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        PcInputController _pcInput;
        LaunchProjectile _launchProjectile;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _pcInput = new PcInputController();
        }
        void Update()
        {
            if(_pcInput.LeftMouseClick || _pcInput.SpaceButtonPressed)
                _isMouseClickedOrSpacePressed = true;
            if (_pcInput.RightMouseClick || _pcInput.FButtonPressed)
                _launchProjectile.LaunchTheProjectile();


        }

        private void FixedUpdate()
        {
            if (_isMouseClickedOrSpacePressed)
            {
                _jump.JumpAction(_rigidbody2D);
                _isMouseClickedOrSpacePressed=false;
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if(!(collision.gameObject.tag=="UpperBoundary"))
                GameManager.Instance.RestartGame();
        }
    }


}
