using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public static class UserInput
    {

        public static KeyboardState _currentKBS, _previousKBS;
        public static MouseState _currentMS, _previousMS;

        public static void Update()
        {
            _previousKBS = _currentKBS;
            _currentKBS = Keyboard.GetState();

            _previousMS = _currentMS;
            _currentMS = Mouse.GetState();
        }

        public static bool IsKeyRelease(Keys key)
        {
            return _currentKBS.IsKeyUp(key) && _previousKBS.IsKeyDown(key);
        }

       



    }
}
