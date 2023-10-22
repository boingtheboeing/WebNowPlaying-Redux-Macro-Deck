using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using WNPReduxAdapterLibrary;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck;
using boingtheboeing.WebNowPlayingPlugin;

namespace boingtheboeing.WebNowPlayingPlugin.Actions
{
    public class NextAction : PluginAction
    {
        public override string Name => "Next";

        public override string Description => "Next track";

        public override bool CanConfigure => false;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (WNPRedux.MediaInfo.Controls.SupportsSkipNext)
            {
                WNPRedux.MediaInfo.Controls.TrySkipNext();
            }
        }
    }
}
