using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Abstracts;

namespace Mechanics
{
    public class LifeCycle : LifeCycleController
    {
        protected override void LifeTimeEnded()
        {
            Destroy(this.gameObject);
        }
    }
}

