# To-do

## Meta

- **This is what [list of works](./list-of-works.md) does.** ~~Build a list of hypothesized rooms and sculptures/installations (maybe in a separate file to track which ones I make/don't make, etc.)~~

## Bugs and dislikes

- **It was because I somehow duplicated the terrain** ~~Why did the lighting on the grass suddenly start looking absolutely terrible after the doubling back from URP?~~
- **This was because it had two materials assigned** ~~The water is totally fucked in the webgl build~~

## Lighting tech

- **This worked out surprisingly well.** ~~Try out a baked area light (as the only baked light in the game), make sure to check build size even if it works~~
- Try out the entire world being static with mixed lighting and baked global (check build size and appealingness)

## Island

- ~~Scale down the island until around 20 rooms feel like they fit with a nice density versus spacing~~

## Structures

- ~~Make a new shadow room that doesn't have insanely bad-looking seams (somehow)~~
- ~~Try out making a building kit that might allow me (without shitty seams) to build out somewhat different room shapes? Like larger blocks all on a single scale that can be clipped into place. But do check out the texturing impact.~~
- ~~Build a few outdoor structures without thinking too hard about it just to populate the landscape a bit in a concentrated area (this can now be more directed by the [list of works](./list-of-works.md)).~~
- ~~Make a tunnel~~
- **Essentially achieved this with the tunnel - I have a much stronger understanding of holes and so on. Not clear that I desperatly need to inset any buildings, but I certainly could if I wanted too. Would it be interesting to have a doorway off the tunnel??** ~~Practice embedding a building into the landscape a little more so it's easy to enter (beware of this a bit though because it will involve terraforming and then I'll have to rebumpify the landscape?)~~

- Build a window-ed room
- Work on how to give rooms less of a flat affect (may need to happen in blender?)
  - Consider thicker walls (0.5?) with indenting of some kind, maybe at 0.1?
- Experiment with getting my texture back on the room

## Terrain

- ~~Experiment with holes (inset buildings?)~~

## Interactions

- **First draft of this is done, but it will need iteration.** ~~Create triggers to turn any lights inside a space on or off (based on an array? Or the script could search the parenting of the room maybe.)~~
- ~~Platform that moves the sun while you stand on it (test whether we have the sun "snap back" to the eternal time of the island, or have it stay where you set it)~~
- ~~Platform that actives a powerful spotlight outside~~
- ~~Platform that changes the player's capsule to something else for a new shadow~~
- ~~Platform that switches off the sun (back on when you get off)~~

- Platform that switches the sun's colour while on it (snap back)
- Platform that changes real-time shadow color
