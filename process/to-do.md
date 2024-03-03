# To-do

## As of 2024-02-21

### Final pushes

- ~~Make a map of the island to distribute with the game~~

- Click to play for WebGL cursor grab?

### After playing on a big screen

- ~~The on/off light clicks "off" even when you leave while it's already off~~
- **Thanks for saying that** ~~Mostly I like it~~
- **First draft is in place** ~~Intro wall text?~~
- **Appears to work on incredibly cursory examination** ~~Need to build an app version and see what that's like~~
- **No I think reflection is cleaner and simpler** ~~Refraction back for the water? Yes? No? (And there shadows on it? **No there are not**)~~
- **At this moment it looks pretty liveable** ~~The horizon area is still a bit awkward~~
- **Fuck off** ~~Is there any issue with not knowing when you're "done"? Will people feel uncomfortable about that? And do I give any fucks? (Should you be able to "leave"?)~~
- **I think I don't want to go down this wormhole** ~~Bias is pretty fucking bad (but that may not actually matter however I go... some acne or I high bias are  both just part of it)~~
- **I think I don't have the mental space for it** ~~The ambient is too high~~ **This is tricky because that was on the TV whereas on my laptop it's quite nice. The classic thing of getting people to set their brightness. Boring beyond belief.**
- ~~At least one experience of the hallway mixer breaking (hearing full volume at the end of the hall)~~
- ~~Editing the title wall~~
- **Probably overkill, sort of aggravating.** ~~Explainers per room?~~
- **Nah** ~~Occurs to me one could do little "info placards" with this stuff there optionally, but I think that's just too much work~~

### J+M feedback (that I could conceivably do something about)

- ~~Slow down the mouse~~
- **For now I'll say wall text, but further texts per room is a possibility.** ~~Did not understand the titles (wall text may help?)~~
- ~~Going under water (avoid this, block going too far out, make it shallow near the shore)~~
- **Maybe a PDF map** ~~The sense of not have time/organization enough to look at stuff~~
  - ~~A map?~~
  - **God knows** ~~Warping to places you've been before? God.~~

### General

- **For now I'll just give up on that room, it's not actually *that* interesting in terms of shadow anyway** ~~Water floor has issues around the stupid reflection stuff~~
- **Nah, confusing.** ~~Looking down and falling into the scene?~~
- ~~Smoothing duty (look out for jaggedy shitty terriains)~~
- ~~Mowing (look out for grass and/or terrain inside every space and on every sculpture )~~
- ~~"Tripping hazards" (making sure you can get into each room and onto each dias etc.)~~
  - ~~Consider upping the step height a bit on the player controller?~~

### Technical

- **World's most basic torch is operating now and it's nice.** ~~Flashlight~~
- **I'm starting not to worry about this** ~~The Area Light building with its baked lightmap looks pretty fucked (only sometimes???)~~
- **Looks like the old Standard Assets water may be my friend for this** ~~Where is the fucking water in the WebGL build?!~~
  - ~~Threw in a placeholder~~
- **We might be there with the water now** ~~Play with the water a bit more (just reflective? Do I need refraction? Possibly yes for the floor lights)~~
- ~~There is an unpleasant loop moment *sometimes* where you hear a hitch in the brownian noise~~

### Sound?

- **Gosh they sound good!** ~~Clicks for lights?~~
- **Brown noise that just dampens when you go indoors is nice** ~~General white/brown noise ambience? Based on something?~~
  - ~~Different sound for indoors, during a sun snap? Sun position determinant? Proximity to the water (that I can't see right now in webgl)?~~
- **Sounds odd and good** ~~Snap To sound effect (literally the click?)~~
- ~~Add the click to diases~~

### Interiors

- ~~In Praise of Shadows(!!??) -- Could be the first room you stand in front of? Which has the title of the game as its name?~~
- ~~Rearranging some rooms to even it out over the island, but maybe don't get too too fussy~~
- **Could consider a lerp, but suspect it's too much effort for not enough reward. Could also think about relocating the trigger on this one, but likely not needed.** ~~Need to move the sun when in the Directional light room x 175 y 395~~
- ~~Mowing the grass~~
- ~~Flickering light?~~
- ~~Torch head~~
- ~~Water floor~~
- ~~Grass floor~~

### Sculptures

- **This has begun fairly well** ~~Intuitively making them~~
- **Yeah, it seems like it'll work** ~~Keep just... making them?~~
- ~~And go on~~

### Diases

- **Actually no I don't think so.** ~~Could potentially combo this with trigger areas for sculptures? So more like the effect happens in proximity to a set of sculptures? Would I mark the area? I kind of like this combination~~
- ~~Ambient color **I don't know about this one, it feels like it's not about the shadows... at the very least it should be somewhere you can look at shadows (maybe rotate the sun as well?) as it's in a bit of a deadzone now~~
- ~~Night~~
- ~~Sun on/off~~
- ~~Intensity~~
- ~~Fast Day night cycle (slightly frustrating with the current setup of the sun?) - what is the difference between this and the day/night cycle? Movement.~~
- ~~General note: instant setting of sun position versus animating (maybe better)~~
- ~~Convert all the sculptures across to snapping~~
- **But in practice it was less than amazing.** ~~Gigantic sun-cast shadow against a mega-plane that captures the island in profile? Kind of amazing in principle~~
- **This is a similar idea to the mega shadow... it's just not that compelling** ~~Outdoor spotlight to the distance (is this at all interesting?)~~
- **In the end I think this is just a bit underwhelming** ~~Change user shadow ? (Kind of feels too gimmicky somehow??? But is it really???)~~
  - ~~Could do it so you only have that shadow ON the dias? That might be kind of nice? Or... not???~~

## As of 2024-01-12

### Technical issues

- ~~Remove colliders for light fixtures (when prefabbing?)~~
- ~~Got to be on the lookout for ugly surfaces and acne (like the roof of the current showroom, which has three distinct areas on it. Sadness ensues.)~~
- ~~I'm still not totally satisfied with the quality of interior light~~ **Is this still true?**
- **Fixed with fog color** ~~The edge of the "ocean" is highly visible against the color of the horizon area, looks terrible~~
- ~~TMP seems to flicker in WebGL but not in editor~~

- The Area Light building with its baked lightmap looks pretty fucked (only sometimes???)

### Feel tests

- **Seems pretty good actually.** ~~Try out 22 rooms on the island just to get a sense of distribution and relative visibility, the feeling of places to go~~

### Code to write

- ~~Translation behaviour~~
  - ~~Basic setup~~
  - ~~Question of easing?~~
- ~~Screenshotter~~

### Other technical stuff

- ~~Get the animation system working instead of hand-writing animation code??~~
- ~~Shift all the existing exhibits to animation system~~

### Prefabbing

- **Nope** ~~Does prefabbing remove a level I want to work at?~~
- ~~Showroom~~
  - ~~Includes Switch Trigger~~
  - ~~Includes vase-on-plinth (removed sometimes I guess)~~
  - ~~Includes emission path lighting?~~
- ~~Point Light Fixture~~
  - ~~Include points A and B~~
- ~~Spotlight Fixture~~
- ~~Windowed Showroom~~
  - ~~As above~~

### Interior exhibits to build

- Flickering light? Other more dynamic stuff?
- In Praise of Shadows(!!??) -- Could be the first room you stand in front of?
  - v r 5
  - In Praise of Shadows

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

- Day night cycle
- Outdoor spotlight to the distance
- Sun on/off
- Change user shadow ? (Kind of feels too gimmicky somehow??? But is it really???)
  - Could do it so you only have that shadow ON the dias? That might be kind of nice?

### Architecture to build

- **Leaning no.** ~~Should I got for an L-shaped room? (Should I stop over-thinking this?)~~

### UI to build

- ~~Lighting strips or similar for the room~~
- ~~Room descriptions/indicators~~
  - ~~View activated didacts?~~
  - ~~Real didacts?~~
  - **This already looks really strong so it might be fine as it.** ~~Writing on the wall?~~
  - ~~Talos 2 style display as you go in~~

- Flashlight (?)
- Could consider flashing or colour-change or other indication of seen/not seen... maybe proximity based if flash/pulse

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
