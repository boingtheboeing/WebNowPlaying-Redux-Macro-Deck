using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using SuchByte.MacroDeck.Logging;
using SuchByte.MacroDeck;
using boingtheboeing.WebNowPlayingPlugin;
using WNPReduxAdapterLibrary;

namespace boingtheboeing.WebNowPlayingPlugin.Actions
{
    public class PreviousAction : PluginAction
    {
        public override string Name => "Previous";

        public override string Description => "Previous track";

        public override bool CanConfigure => false;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (WNPRedux.MediaInfo.Controls.SupportsSkipPrevious)
            {
                WNPRedux.MediaInfo.Controls.TrySkipPrevious();
            }
        }
    }
}
