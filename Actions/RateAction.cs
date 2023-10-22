using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using WNPReduxAdapterLibrary;

namespace boingtheboeing.WebNowPlayingPlugin.Actions
{
    public class RateAction : PluginAction
    {
        public override string Name => "Rate";

        public override string Description => "Toggle Rating (like/Dislike)";

        public override bool CanConfigure => false;

        public override string BindableVariable => "wnp_rating";

        public override void Trigger(string clientId, ActionButton actionButton)
        {
            if (
                WNPRedux.MediaInfo.Controls.SupportsSetRating == true
                && WNPRedux.MediaInfo.Controls.RatingSystem == MediaControls.RatingSystemEnum.LIKE
            )
            {
                if (WNPRedux.MediaInfo.Rating == 0)
                {
                    //Disliked
                    WNPRedux.MediaInfo.Controls.TrySetRating(5);
                }
                else
                {
                    //Liked
                    WNPRedux.MediaInfo.Controls.TrySetRating(0);
                }
            }
        }
    }
}
