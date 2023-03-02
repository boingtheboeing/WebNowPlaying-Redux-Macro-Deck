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
using jbcarreon123.WebNowPlayingPlugin;

namespace jbcarreon123.WebNowPlayingPlugin.Actions
{
    public class NextAction : PluginAction
    {
        public override string Name => "Next";

        public override string Description => "Nexts the track";

        public override bool CanConfigure => false;

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (PluginConfiguration.GetValue(PluginInstance.Main, "mode") == "Normal")
                Main.socket.Send("next");
            else
                WNPRedux.mediaEvents.Next();
        }
    }
}