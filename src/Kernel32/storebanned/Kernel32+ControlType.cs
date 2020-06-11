﻿// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    using System;

    /// <content>
    /// Contains the <see cref="ControlType"/> nested type.
    /// </content>
    public partial class Kernel32
    {
        /// <summary>
        /// Values that are passed to the <see cref="HandlerRoutine"/> callback.
        /// </summary>
        public enum ControlType
        {
            /// <summary>
            /// A CTRL+C signal was received, either from keyboard input or from a signal generated by the <see cref="GenerateConsoleCtrlEvent"/> function.
            /// </summary>
            CTRL_C_EVENT = 0,

            /// <summary>
            /// A CTRL+BREAK signal was received, either from keyboard input or from a signal generated by <see cref="GenerateConsoleCtrlEvent"/>.
            /// </summary>
            CTRL_BREAK_EVENT = 1,

            /// <summary>
            /// A signal that the system sends to all processes attached to a console when the user closes the console
            /// (either by clicking Close on the console window's window menu, or by clicking the End Task button command from Task Manager).
            /// </summary>
            CTRL_CLOSE_EVENT = 2,

            /// <summary>
            /// A signal that the system sends to all console processes when a user is logging off. This signal does not indicate which user is logging off, so no assumptions can be made.
            /// </summary>
            /// <remarks>
            /// Note that this signal is received only by services. Interactive applications are terminated at logoff, so they are not present when the system sends this signal.
            /// </remarks>
            CTRL_LOGOFF_EVENT = 5,

            /// <summary>
            /// A signal that the system sends when the system is shutting down.
            /// Interactive applications are not present by the time the system sends this signal, therefore it can be received only be services in this situation.
            /// Services also have their own notification mechanism for shutdown events. For more information, see <see cref="HandlerRoutine"/>.
            /// </summary>
            /// <remarks>
            /// This signal can also be generated by an application using GenerateConsoleCtrlEvent.
            /// </remarks>
            CTRL_SHUTDOWN_EVENT = 6
        }
    }
}
