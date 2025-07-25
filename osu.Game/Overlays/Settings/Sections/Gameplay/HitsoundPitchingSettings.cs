// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using System.Linq;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Localisation;
using osu.Game.Configuration;
using osu.Game.Localisation;

namespace osu.Game.Overlays.Settings.Sections.Gameplay
{
    public partial class HitsoundPitchingSettings : SettingsSubsection
    {
        protected override LocalisableString Header => HitsoundPitchingSettingsStrings.HitsoundPitchingHeader;

        public override IEnumerable<LocalisableString> FilterTerms => base.FilterTerms.Concat(new LocalisableString[] { "hitsound", "pitch" });

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            Children = new Drawable[]
            {
                new SettingsSlider<double, SemitonesSlider<double>>
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingAmount,
                    Current = config.GetBindable<double>(OsuSetting.HitsoundPitchingAmount),
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingAmountTooltip,
                },
                new SettingsSlider<double>
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingCurve,
                    Current = config.GetBindable<double>(OsuSetting.HitsoundPitchingCurve),
                    Keywords = new[] { "sensitivity", "curve" },
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingCurveTooltip,
                },
                new SettingsCheckbox
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingStepped,
                    Current = config.GetBindable<bool>(OsuSetting.HitsoundPitchingStepped),
                    Keywords = new[] { "stepped", "step" },
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingSteppedTooltip,
                },
                new SettingsCheckbox
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingKeepTempo,
                    Current = config.GetBindable<bool>(OsuSetting.HitsoundPitchingKeepTempo),
                    Keywords = new[] { "tempo", "keep" },
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingKeepTempoTooltip,
                },
                new SettingsEnumDropdown<HitsoundPitchingThreshold>
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingThreshold,
                    Current = config.GetBindable<HitsoundPitchingThreshold>(OsuSetting.HitsoundPitchingThreshold),
                    Keywords = new[] { "threshold", "range" },
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingThresholdTooltip,
                },
            };
        }
    }
}
