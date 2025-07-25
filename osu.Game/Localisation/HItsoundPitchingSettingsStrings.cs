// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Localisation;

namespace osu.Game.Localisation
{
    public static class HitsoundPitchingSettingsStrings
    {
        private const string prefix = @"osu.Game.Resources.Localisation.HitsoundPitchingSettings";

        /// <summary>
        /// "Hitsound pitching"
        /// </summary>
        public static LocalisableString HitsoundPitchingHeader => new TranslatableString(getKey(@"hitsound_pitching_header"), @"Hitsound pitching");

        /// <summary>
        /// "Pitching amount"
        /// </summary>
        public static LocalisableString HitsoundPitchingAmount => new TranslatableString(getKey(@"hitsound_pitching_amount"), @"Pitching amount");

        /// <summary>
        /// "The amount of pitch shift applied to hitsounds, in semitones. Positive values will make the hitsounds higher-pitched when hit too early, and lower-pitched when hit too late. Negative values will do the opposite."
        /// </summary>
        public static LocalisableString HitsoundPitchingAmountTooltip => new TranslatableString(getKey(@"hitsound_pitching_amount_tooltip"), @"The amount of pitch shift applied to hitsounds, in semitones. Positive values will make the hitsounds higher-pitched when hit too early, and lower-pitched when hit too late. Negative values will do the opposite.");

        /// <summary>
        /// "Pitching sensitivity"
        /// </summary>
        public static LocalisableString HitsoundPitchingCurve => new TranslatableString(getKey(@"hitsound_pitching_curve"), @"Pitching sensitivity");

        /// <summary>
        /// "The amount of quadratic curve applied to hitsounds. Higher values reduce the "sensitivity" of the pitch shift, and lower values increase it. Negative values will do the opposite."
        /// </summary>
        public static LocalisableString HitsoundPitchingCurveTooltip => new TranslatableString(getKey(@"hitsound_pitching_curve_tooltip"), @"The amount of quadratic curve applied to hitsounds. Higher values reduce the ""sensitivity"" of the pitch shift, and lower values increase it. Negative values will do the opposite.");

        /// <summary>
        /// "Stepped pitching"
        /// </summary>
        public static LocalisableString HitsoundPitchingStepped => new TranslatableString(getKey(@"hitsound_pitching_stepped"), @"Stepped pitching");

        /// <summary>
        /// "Whether to linearly interpolate pitch shifts between judgements, or to quantize them to the nearest judgement."
        /// </summary>
        public static LocalisableString HitsoundPitchingSteppedTooltip => new TranslatableString(getKey(@"hitsound_pitching_stepped_tooltip"), @"Whether to linearly interpolate pitch shifts between judgements, or to quantize them to the nearest judgement.");

        /// <summary>
        /// "Keep pitching tempo"
        /// </summary>
        public static LocalisableString HitsoundPitchingKeepTempo => new TranslatableString(getKey(@"hitsound_pitching_keep_tempo"), @"Keep pitching tempo");

        /// <summary>
        /// "Whether to force pitched hitsounds to be played back at the same rate regardless of the amount of pitch shift applied."
        /// </summary>
        public static LocalisableString HitsoundPitchingKeepTempoTooltip => new TranslatableString(getKey(@"hitsound_pitching_keep_tempo_tooltip"), @"Whether to force pitched hitsounds to be played back at the same rate regardless of the amount of pitch shift applied.");

        /// <summary>
        /// "Pitching threshold"
        /// </summary>
        public static LocalisableString HitsoundPitchingThreshold => new TranslatableString(getKey(@"hitsound_pitching_threshold"), @"Pitching threshold");

        /// <summary>
        /// "The best possible judgement before pitch shifting is applied. A value of 'Perfect' will always apply pitch shift, a value of 'Great' will apply pitch shift only if the judgement is worse than 'Great', etc., and a value of 'Miss' will never apply pitch shift."
        /// </summary>
        public static LocalisableString HitsoundPitchingThresholdTooltip => new TranslatableString(getKey(@"hitsound_pitching_threshold_tooltip"), @"The best possible judgement before pitch shifting is applied. A value of 'Perfect' will always apply pitch shift, a value of 'Great' will apply pitch shift only if the judgement is worse than 'Great', etc., and a value of 'Miss' will never apply pitch shift.");

        private static string getKey(string key) => $@"{prefix}:{key}";
    }
}
