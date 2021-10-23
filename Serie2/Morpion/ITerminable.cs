using System;
using System.Collections.Generic;
using System.Text;

namespace Morpion
{
    interface ITerminable
    {
        bool VerifyIfP1Won();
        bool VerifyIfP2Won();
        bool VerifyIfDraw();
    }
}
