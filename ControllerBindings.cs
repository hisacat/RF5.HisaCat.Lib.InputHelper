using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RF5.HisaCat.Lib.InputHelper
{
    public static class ControllerBindings
    {
        [Flags]
        public enum XBoxControllerBindings : uint
        {
            LT = RF5Input.Key.ZL,
            RT = RF5Input.Key.ZR,
            LB = RF5Input.Key.L,
            RB = RF5Input.Key.R,

            LS = RF5Input.Key.AL,
            LSUp = RF5Input.Key.ALU,
            LSRight = RF5Input.Key.ALR,
            LSDown = RF5Input.Key.ALD,
            LSLeft = RF5Input.Key.ALL,

            RS = RF5Input.Key.AR,
            RSUp = RF5Input.Key.ARU,
            RSRight = RF5Input.Key.ARR,
            RSDown = RF5Input.Key.ARD,
            RSLeft = RF5Input.Key.ARL,

            Y = RF5Input.Key.X,
            B = RF5Input.Key.B | RF5Input.Key.CK2,
            A = RF5Input.Key.A | RF5Input.Key.CK3,
            X = RF5Input.Key.Y,

            DPadUp = RF5Input.Key.JU,
            DPadRight = RF5Input.Key.JR,
            DPadDown = RF5Input.Key.JD,
            DPadLeft = RF5Input.Key.JL,

            Select = RF5Input.Key.MS,
            Start = RF5Input.Key.PS,
        }

        /// <summary>
        /// This is 'Default' windows key bindings.
        /// Windows key bindings can be changed from RF5 Settings window.
        /// </summary>
        [Flags]
        public enum WindowsDefaultBindings : uint
        {
            Space = RF5Input.Key.ZL,
            Z = RF5Input.Key.ZR,
            Q = RF5Input.Key.L,
            MouseRightClick = RF5Input.Key.R,

            LeftShift = RF5Input.Key.AL,
            W = RF5Input.Key.ALU,
            D = RF5Input.Key.ALR,
            S = RF5Input.Key.ALD,
            A = RF5Input.Key.ALL,

            MouseWheelClick = RF5Input.Key.AR,
            I = RF5Input.Key.ARU,
            L = RF5Input.Key.ARR,
            K = RF5Input.Key.ARD,
            J = RF5Input.Key.ARL,

            G = RF5Input.Key.X,
            F = RF5Input.Key.B | RF5Input.Key.CK2,
            E = RF5Input.Key.A | RF5Input.Key.CK3,
            R = RF5Input.Key.Y,

            Escape = RF5Input.Key.CK2,
            Enter = RF5Input.Key.CK3,

            UpArrow = RF5Input.Key.JU,
            RightArrow = RF5Input.Key.JR,
            DownArrow = RF5Input.Key.JD,
            LeftArrow = RF5Input.Key.JL,

            M = RF5Input.Key.MS,
            Tab = RF5Input.Key.PS,

            MouseLeftClick = RF5Input.Key.CK1,

            T = RF5Input.Key.CK8,
            F1 = RF5Input.Key.CK4,
            F2 = RF5Input.Key.CK5,
        }
    }
}
