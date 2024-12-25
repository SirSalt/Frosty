using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frosty
{
    public static partial class GameSettings
    {
        public const int WINDOWWIDTH = 1200;
        public const int WINDOWHEIGHT = 800;

        public static Screen ActiveScreen {  get; set; }

        public static Screen PlayScreen { get; set; }

    }
}
