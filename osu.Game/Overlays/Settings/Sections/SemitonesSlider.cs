// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Numerics;
using System.Globalization;
using osu.Framework.Localisation;
using osu.Game.Graphics.UserInterface;

namespace osu.Game.Overlays.Settings.Sections
{
    /// <summary>
    /// A slider intended to show a number of "semitones".
    /// </summary>
    public partial class SemitonesSlider<T> : RoundedSliderBar<T>
        where T : struct, INumber<T>, IMinMaxValue<T>, IFormattable
    {
        public override LocalisableString TooltipText => Current.Value.ToString(@"0.# semitones ", NumberFormatInfo.CurrentInfo);
    }
}
