using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClick => Input.GetMouseButtonDown(0);
        public bool SpaceButtonPressed => Input.GetKeyDown(KeyCode.Space);
    }
}

