﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail2017
{
    public class ButtonPressedEvent
    {
        #region Singleton

        private static ButtonPressedEvent _evenement;
        private ButtonPressedEvent()
        {

        }

        public static ButtonPressedEvent GetInstance()
        {
            if (_evenement == null)
            {
                _evenement = new ButtonPressedEvent();
            }
            return _evenement;
        }

        #endregion

        public event EventHandler Handler;

        public void OnButtonPressedHandler(EventArgs e)
        {
            if (Handler != null)
            {
                Handler(this, e);
            }
        }

    }
}
