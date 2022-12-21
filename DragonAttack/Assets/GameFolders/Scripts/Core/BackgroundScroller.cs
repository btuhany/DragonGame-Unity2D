using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class BackgroundScroller : MonoBehaviour
    {
        [Range(0f, 1f)][SerializeField] float scrollSpeed = 0.5f;
        private float _offset;
        private Material _material;
        
        private void Awake()
        { 
            _material = GetComponent<Renderer>().material;

        }
        private void Update()
        {
            _offset += (Time.deltaTime * scrollSpeed) / 10f;
            _material.SetTextureOffset("_MainTex", new Vector2(_offset, 0));

        }


    }
}

