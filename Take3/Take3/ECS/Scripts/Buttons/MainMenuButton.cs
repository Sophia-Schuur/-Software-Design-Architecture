﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Take3.GameManagement;

namespace Take3.ECS.Scripts 
{
    class MainMenuButton : Button
    {
        public override void OnClick()
        {
            GameManager.SwitchState(State.Menu);
        }
    }
}
