// MonoGame - Copyright (C) The MonoGame Team
// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using System;
using Microsoft.Xna.Framework.Input;

namespace Microsoft.Xna.Framework
{
    public struct MouseButtonEventArgs
    {
        /// <summary>
        /// Whether the mouse button was pressed or released.
        /// </summary>
        public readonly ButtonState State;

        /// <summary>
        /// Whether this event is about the LeftButton.
        /// </summary>
        public readonly bool LeftButton;
        /// <summary>
        /// Whether this event is about the MiddleButton.
        /// </summary>
        public readonly bool MiddleButton;
        /// <summary>
        /// Whether this event is about the RightButton.
        /// </summary>
        public readonly bool RightButton;
        /// <summary>
        /// Whether this event is about the XButton1.
        /// </summary>
        public readonly bool XButton1;
        /// <summary>
        /// Whether this event is about the XButton2.
        /// </summary>
        public readonly bool XButton2;

        /// <summary>
        /// The X position of the mouse at the time of the event.
        /// </summary>
        public readonly int X;

        /// <summary>
        /// The Y position of the mouse at the time of the event.
        /// </summary>
        public readonly int Y;

        /// <summary>
        /// Create a new mouse button input event
        /// </summary>
        /// <param name="state">Whether the mouse button was pressed or released</param>
        /// <param name="leftButton">Whether this event is about the LeftButton</param>
        /// <param name="middleButton">Whether this event is about the MiddleButton</param>
        /// <param name="rightButton">Whether this event is about the RightButton</param>
        /// <param name="xButton1">Whether this event is about the XButton1</param>
        /// <param name="xButton2">Whether this event is about the XButton2</param>
        /// <param name="x">The X position of the mouse at the time of the event</param>
        /// <param name="y">The Y position of the mouse at the time of the event</param>
        public MouseButtonEventArgs(ButtonState state, bool leftButton, bool middleButton, bool rightButton, bool xButton1, bool xButton2, int x, int y)
        {
            State = state;
            LeftButton = leftButton;
            MiddleButton = middleButton;
            RightButton = rightButton;
            XButton1 = xButton1;
            XButton2 = xButton2;
            X = x;
            Y = y;
        }
    }
}
