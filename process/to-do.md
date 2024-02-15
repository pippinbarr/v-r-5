# To-do

## As of 2024-01-12

### Technical issues

- ~~Remove colliders for light fixtures (when prefabbing?)~~

- I'm still not totally satisfied with the quality of interior light
- Got to be on the lookout for ugly surfaces and acne (like the roof of the current showroom, which has three distinct areas on it. Sadness ensues.)

### Feel tests

- **Seems pretty good actually.** ~~Try out 22 rooms on the island just to get a sense of distribution and relative visibility, the feeling of places to go~~

### Code to write

- ~~Translation behaviour~~
  - ~~Basic setup~~
  - ~~Question of easing?~~

### Other technical stuff

- ~~Get the animation system working instead of hand-writing animation code??~~
- Shift all the existing exhibits to animation system

### Prefabbing

- **Nope** ~~Does prefabbing remove a level I want to work at?~~
- ~~Showroom~~
  - ~~Includes Switch Trigger~~
  - ~~Includes vase-on-plinth (removed sometimes I guess)~~
  - ~~Includes emission path lighting?~~
- ~~Point Light Fixture~~
  - ~~Include points A and B~~
- ~~Spotlight Fixture~~

- Windowed Showroom
  - As above

### Interior exhibits to build

#### Lights

- √ *Point light* Light: Point Light (drifting)
- √ *Spotlight* Light: Spot Light (drifting)
- √ Light: Directional Light (window, totally static)
  - **Still need to script the sun to the right place.**
- √ Light: Area Light (baked, totally static)
- √ Two Lights (combined shadows, drifting)

#### Settings

- √ Setting: Relative Shadow Casting (drifting and toggle)
- √ Setting: Relative Shadow Receiving (drifting and toggle)
- √ Setting: Cookie (Totally static)
- √ *Shadow acne* Setting: Acne
- √ (Bias, if visible, tweening)
- x (Normal Bias, if visible, tweening)
- √ *Shadows only* Setting: Shadow Only
- In Praise of Shadows / Glimmer of Gold (low light, very static)
- √ *Near plane* Setting: Near Plane (tweening)
- √ **JUST LOW RESOLUTION** (Cannot animate with system) Setting: Low Quality
- √ (Cannot animate with system) Setting: Hard (on and off?)
- √ ~~(Cannot animate with system) Setting: No Shadows (**AND TOGGLE?**)~~
- √ **Confirming that it is that easy to animate properties like this and save myself some coding heartache. Also noticeable that movement AND another property moving felt like overkill so me in that moment** *Shadow strength* Setting: Shadow Strength (tweening)

#### √ Movements

- √ *X translation* Dynamics: Translation side to side, lateral (dolly)
- √ *Y translation* Dynamics: Translation up and down, vertical
- √ *Z translation* Dynamics: Translation in and out, dolly?
- √ *Y orbit* Dynamics: Rotation/orbit (separate out? a rotating spot light like a lighthouse?)
- √ *X orbit*
- √ *Z orbit*
- √ *On and off* Dynamics: On and Off
- **Trying it out for now** ~~Do I now want the three axes of rotation?? One of them won't do anything?~~

### Exterior exhibits to build

- At some point I should explicitly play with this
- Should they have their own display somewhere that notifies you of what's going on, or at least give a title?

### Diases to build

### Architecture to build

- **Leaning no.** ~~Should I got for an L-shaped room? (Should I stop over-thinking this?)~~

### UI to build

- Lighting strips or similar for the room
- Flashlight
- Room descriptions/indicators
  - View activated didacts?
  - Real didacts?
  - **This already looks really strong so it might be fine as it.** Writing on the wall?
    - Could consider flashing or colour-change or other indication of seen/not seen... maybe proximity based if flash/pulse
  - Talos 2 style display as you go in

---

## Pre-2024-01-12

## Meta

- **This is what [list of works](./list-of-works.md) does.** ~~Build a list of hypothesized rooms and sculptures/installations (maybe in a separate file to track which ones I make/don't make, etc.)~~

## Bugs and dislikes

- **It was because I somehow duplicated the terrain** ~~Why did the lighting on the grass suddenly start looking absolutely terrible after the doubling back from URP?~~
- **This was because it had two materials assigned** ~~The water is totally fucked in the webgl build~~

## Lighting tech

- **This worked out surprisingly well.** ~~Try out a baked area light (as the only baked light in the game), make sure to check build size even if it works~~
- **I don't think this is actually useful because the sun moves, so baking stuff will just... well there's nothing to bake, right?** ~~Try out the entire world being static with mixed lighting and baked global (check build size and appealingness)~~
- ~~Fix up my lightswitch to switch materials as well~~
- **I have made progress on this (notably the associated color of the albedo for the concrete texture, but it's still not perfect. Wondering about some guiding lighting lighting in the hallway to help people in and out if I choose to make it ultra drak** ~~Why is the floor well lit when there are no lights on and the walls are dark?~~

## Other scripty tech

- **I have a LightBehaviour parent that can be extended to start behaviours when a light is turned on and... it works. So fuck all of you doubters who are me.** ~~Think through the basic concept of crossing a threshold and starting the "machine" that is the exhibit -- e.g. playing a sound, turning on a light, starting another movement script, etc...~~

## Island

- ~~Scale down the island until around 20 rooms feel like they fit with a nice density versus spacing~~

## Interior install prototyping

- ~~Go through and try all the setups to actually see this fucking thing:~~
  - ~~Point light~~
  - ~~Acne~~
  - ~~Spot light~~
  - ~~Two point lights~~
  - ~~Casting/non-casting~~
  - ...
  - **This took some work but I think I have a good structure in place** ~~All but on/off done because I need to work on the correct lightswitch (as I did for the Zium)~~

## Structures

- ~~Make a new shadow room that doesn't have insanely bad-looking seams (somehow)~~
- ~~Try out making a building kit that might allow me (without shitty seams) to build out somewhat different room shapes? Like larger blocks all on a single scale that can be clipped into place. But do check out the texturing impact.~~
- ~~Build a few outdoor structures without thinking too hard about it just to populate the landscape a bit in a concentrated area (this can now be more directed by the [list of works](./list-of-works.md)).~~
- ~~Make a tunnel~~
- **Essentially achieved this with the tunnel - I have a much stronger understanding of holes and so on. Not clear that I desperatly need to inset any buildings, but I certainly could if I wanted too. Would it be interesting to have a doorway off the tunnel??** ~~Practice embedding a building into the landscape a little more so it's easy to enter (beware of this a bit though because it will involve terraforming and then I'll have to rebumpify the landscape?)~~
- ~~Build a window-ed room~~
- ~~Experiment with getting my texture back on the room~~

- **I think the vase and the scale of the room may and the idea of more dynamic displays may have fixed this for us** ~~Work on how to give rooms less of a flat affect (may need to happen in blender?)~~
  - **Don't think this is necessary** ~~Consider thicker walls (0.5?) with indenting of some kind, maybe at 0.1?~~
  - ~~Some of this is perhaps being resolved by the vase oddly~~

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
