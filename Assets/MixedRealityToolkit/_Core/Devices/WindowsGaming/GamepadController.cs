﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Internal.Definitions.Devices;
using Microsoft.MixedReality.Toolkit.Internal.Definitions.Utilities;
using Microsoft.MixedReality.Toolkit.Internal.Interfaces.Devices;
using Microsoft.MixedReality.Toolkit.Internal.Interfaces.InputSystem;

namespace Microsoft.MixedReality.Toolkit.Internal.Devices.WindowsGaming
{
    // TODO
    public class GamepadController : BaseController
    {
        public GamepadController(ControllerState controllerState, Handedness controllerHandedness, IMixedRealityInputSource inputSource = null, IMixedRealityInteractionMapping[] interactions = null)
                : base(controllerState, controllerHandedness, inputSource, interactions) { }
    }
}
