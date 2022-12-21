using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Controllers
{
    public class PcInputController
    {
        public bool LeftMouseClick => Input.GetMouseButtonDown(0);
        public bool RightMouseClick => Input.GetMouseButtonDown(1);
        public bool SpaceButtonPressed => Input.GetKeyDown(KeyCode.Space);
        public bool FButtonPressed => Input.GetKeyDown(KeyCode.F);

    }
}

