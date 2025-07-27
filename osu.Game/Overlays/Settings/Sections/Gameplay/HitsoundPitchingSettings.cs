// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using osu.Framework.Allocation;
using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Localisation;
using osu.Game.Configuration;
using osu.Game.Localisation;
using osuTK;

namespace osu.Game.Overlays.Settings.Sections.Gameplay
{
    public partial class HitsoundPitchingSettings : SettingsSubsection
    {
        protected override LocalisableString Header => HitsoundPitchingSettingsStrings.HitsoundPitchingHeader;

        public override IEnumerable<LocalisableString> FilterTerms => base.FilterTerms.Concat(["hitsound", "pitch"]);

        private readonly Bindable<bool> enabled = new BindableBool(true);
        private FillFlowContainer mainSettings;

        [BackgroundDependencyLoader]
        private void load(OsuConfigManager config)
        {
            enabled.BindTo(config.GetBindable<bool>(OsuSetting.HitsoundPitchingEnabled));

            Children =
            [
                new SettingsCheckbox
                {
                    LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingEnabled,
                    Current = enabled,
                    TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingEnabledTooltip,
                },
                mainSettings = new FillFlowContainer
                {
                    Alpha = 0,
                    RelativeSizeAxes = Axes.X,
                    AutoSizeAxes = Axes.Y,
                    Spacing = new Vector2(0, 8),
                    Direction = FillDirection.Vertical,
                    Children =
                    [
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
                            Keywords = ["sens", "curve"],
                            TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingCurveTooltip,
                        },
                        new SettingsCheckbox
                        {
                            LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingStepped,
                            Current = config.GetBindable<bool>(OsuSetting.HitsoundPitchingStepped),
                            Keywords = ["stepped", "step"],
                            TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingSteppedTooltip,
                        },
                        new SettingsCheckbox
                        {
                            LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingKeepTempo,
                            Current = config.GetBindable<bool>(OsuSetting.HitsoundPitchingKeepTempo),
                            Keywords = ["tempo", "keep"],
                            TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingKeepTempoTooltip,
                        },
                        new SettingsEnumDropdown<HitsoundPitchingThresholdSetting>
                        {
                            LabelText = HitsoundPitchingSettingsStrings.HitsoundPitchingThreshold,
                            Current = config.GetBindable<HitsoundPitchingThresholdSetting>(OsuSetting.HitsoundPitchingThreshold),
                            Keywords = ["threshold", "range"],
                            TooltipText = HitsoundPitchingSettingsStrings.HitsoundPitchingThresholdTooltip,
                        },
                    ],
                },
            ];
        }

        protected override void LoadComplete()
        {
            base.LoadComplete();

            enabled.BindValueChanged(enabled =>
            {
                if (enabled.NewValue)
                    mainSettings.Show();
                else
                    mainSettings.Hide();
            }, true);
        }
    }
}
