using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;

namespace RespectMyBodySlide
{
    public class Settings
    {
        [SynthesisSettingName("Mods to ignore")]
        [SynthesisDescription("Names of any plugins (not including the extension) from which to keep custom bodies.")]
        public List<string> IgnoredModNames { get; set; } = new();

        [SynthesisSettingName("Keep wigs")]
        [SynthesisDescription(
            "Skip patching NPCs whose only customization is to add a wig, such as one from KS Wigs. If 'Separate " +
            "wigs' is not also enabled, this may result in leaving behind certain body overrides that replace both " +
            "the body and hair.")]
        public bool KeepWigs { get; set; } = true;

        [SynthesisSettingName("Separate wigs")]
        [SynthesisDescription(
            "Attempt to break down body customizations that include main body parts AND a wig, and replace them with " +
            "one that is only a wig. May cause glitches. This setting is ignored if 'Keep Wigs' is turned off.")]
        public bool SeparateWigs { get; set; } = false;
    }
}