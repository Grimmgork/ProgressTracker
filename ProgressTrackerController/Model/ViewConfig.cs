using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ProgressTracker.Model
{
    [System.Serializable]
    public class ViewConfig
    {
        public WindowState startupWindowState;

        public ViewConfig()
        {
            startupWindowState = WindowState.Maximized;
        }
    }
}
