﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OctoAwesome.Components
{
    public interface IInputSet
    {
        bool Left { get; }

        bool Right { get; }

        bool Up { get; }

        bool Down { get; }

        bool Interact { get; }
    }
}
