﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace PiJuiceDevice.Models
{
    /// <summary>
    /// TODO: Fill In
    /// </summary>
    public class PowerInput
    {
        /// <summary>
        /// TODO: Fill In
        /// </summary>
        public PowerInputType Precedence { get; set; }

        /// <summary>
        /// TODO: Fill In
        /// </summary>
        public bool GPIOIn { get; set; }

        /// <summary>
        /// TODO: Fill In
        /// </summary>
        public bool NoBatteryTurnOn { get; set; }

        /// <summary>
        /// TODO: Fill In
        /// </summary>
        public string USBMicroCurrentLimit { get; set; }

        /// <summary>
        /// TODO: Fill In
        /// </summary>
        public bool NonVolatile { get; set; }
    }
}
