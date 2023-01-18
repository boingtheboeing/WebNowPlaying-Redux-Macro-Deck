# WebNowPlaying Plugin for Macro Deck 2
Interfaces WebNowPlaying to Macro Deck 2

## Notes
- You need to install the **WebNowPlaying Companion** extension on [Chrome Web Store](https://chrome.google.com/webstore/detail/webnowplaying-companion/jfakgfcdgpghbbefmdfjkbdlibjgnbli) or on [Firefox Addons Store](https://addons.mozilla.org/en-US/firefox/addon/webnowplaying-companion/).
- You need to either close Rainmeter, disable WebNowPlaying Rainmeter Plugin or uninstall WebNowPlaying Rainmeter Plugin.

## Future Additions
- Passthrough mode *(so both MD2 and Rainmeter can get and process the data)*
- Status indicator

## Features
| Action | Description |
| --- | --- |
| Play/Pause | Play/Pauses the current track |
| Next | Next track |
| Previous | Previous track |
| Shuffle | Toggle shuffle |
| Repeat | Toggle repeat |

## Variables
| Variable | Description | Type |
| --- | --- | --- |
| wnp_player | Shows the current player (e.g. YouTube) | String |
| wnp_is_playing | Shows when a supported site is playing | Boolean |
| wnp_state | Shows the playing state (0 = stopped, 1 = playing, 2 = paused) | Integer |
| wnp_title | Shows the title of the current track | String |
| wnp_artist | Shows the artist(s) of the current track | String |
| wnp_album | Shows the album of the current track | String |
| wnp_duration | Shows the duration of the current track | String |
| wnp_position | Shows the current position of the current track | String |
| wnp_volume | Shows the volume percentage | Float |
| wnp_repeat | Shows when the repeat is turned on or off | Boolean |
| wnp_repeatall | Shows when the repeat is on all tracks | Boolean |
| wnp_repeatone | Shows when the repeat is on single track mode | Boolean |
| wnp_shuffle | Shows when the shuffle is turned on or off | Boolean |

### This is a plugin for [Macro Deck 2](https://github.com/SuchByte/Macro-Deck), it does NOT function as a standalone app
<img height="64px" src="https://macrodeck.org/images/macro_deck_2_official_plugin.png" />

## Third party licenses
This plugin uses some awesome 3rd party libraries:
- [Fleck](https://github.com/statianzo/Fleck)
- [WebNowPlaying](https://github.com/tjhrulz/WebNowPlaying)
- [WebNowPlaying Companion](https://github.com/tjhrulz/WebNowPlaying-BrowserExtension)
- [Websocket Client (unused for current version)](https://github.com/Marfusios/websocket-client)
