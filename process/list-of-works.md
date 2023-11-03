# List of Works

I want to sort of half-taxonomize and half-just-do-whatever-I-want to come up with ideas for what will appear on the island. Clear divisions between:

- Interiors (may include holes in walls though)
- Exterior installations
- Interactive elements

## Meta-notes

- In listing things I'm finding it's a lot of rooms and not so many exterior places? At a certain point that might start to feel a bit weird. It would be nice to see ways to balance it, but it's also true that "controlled environment" usually means a room, esp. because we can block out the directional light (mostly?).

## List started 26 September 2023

### Gaps / Passing through

i.e. the idea of light passing through a defined gap/window to illuminate what is on the other side but also to create defined shadows in the negative space.

1. Mind the Gaps **Exterior**
    - A series of vertical structures with decreasing space between them to the point where light no longer passes through and the shadow takes over.
2. A Windowed Room **Interior**
    - A room with one or more windows
3. A perforated wall **Exterior**
    - A wall with different sized holes in it...

### Basic Shadowplay by light type

i.e. Just a causing an object to cast a shadow. What counts as basic though?

1. Cube and Point Light **Interior**
    - A room with a single cube and a single point light casting a shadow (soft)
2. Shape and Spotlight **Interior**
    - A room with a single shape and a single spotlight casting a shadow
3. Shape and directional light **Interior**
    - I like the idea of completing this set with a window that casts the directional light into the room that then casts a shadow from an object in the room (need to line that up properly)

Are these all individual rooms or one room with the three things being demonstrated (will clearly have "interference" in terms of the multiple lights, but perhaps that's okay). Also probably should all be cubes.

### Hard and Soft and None

i.e. Demonstrating the difference between hard shadows, soft shadows, and no shadows. How to do this? A single room? What about interference between the lights? Maybe that's nice? Note the difference between casting and receiving too... separate concern?

1. Hard and Soft and None **Interior**
    - First approximation is just three lights (spots? points?) with each of the qualities maybe aimed at different objects but inevitably causing shadows on the others? Or I suppose spots would be able to completely separate which might be nice.

### Casting and Receiving

i.e. The difference between whether an object casts shadows or not and whether an object receives shadows or not.

1. Reception **Interior**
    - Two objects with one light, one of the objects does not receive shadows and the other does. Or three objects to include the cast of receives but doesn't cast. It's kind of oddly complex. Might need separate kind of combinatorial examples?
1. Reception **Exterior**
    - Maybe this can be an exterior thing with multiple objects grouped together that do/don't cast/receive shadows.

### Multiple Sources

i.e. The idea of multiple lights and therefore multiple shadows

1. From All Sides **Interior**
    - Maybe the idea of a single object with N point/spot lights around it causing it to cast shadows in multiple directions. This may look quite nice.

### Bias / Acne

i.e. The idea of playing with the bias settings in a controlled environment (maybe an elongated room for a bunch of examples) including shadow acne being induced through low bias.

1. Acne **Interior**
    - Maybe an acne room all on its own?
2. Bias **Interior**
    - Maybe a longer room where a series of lights cast shadows at different bias values on individual objects. This could involve acne too of course. Might have to be spots for it to work? Do spots cause acne?? ahahahahahaha

### Invisible shadow-casting

One or more objects that are invisible but also cast shadows (this can be **Exterior** I think)

### The Shape of You

i.e. The shadow cast by the player, some opportunity to switch it somewhere? Another interactive dias? Or a room where your shadow changes when you go in?

1. The Shape of You **Interior**
    - If a room, then one where in different areas your controller's mesh/geometry switches around to cast different shadows or no shadows at all. Ideally capsule, the other basic primitives, and maybe one or more fun meshes?
2. The Shape of You **Exterior**
    - If an exterior thing, then maybe a dias where if you stand on it you switch shadows to a random new shadow. Less controlled and maybe less legible? But would allow you to experience new shadows longer term in a variety of environments. Maybe different diases where you can "collect" different shadows? Maybe they have a little model exemplar of the shadow they provide?

More generally I like the idea that we're only casting the shadow... so the visibility of the mesh/primitive itself isn't there, just the shape. That would allow for more diverse shapes that wouldn't occlude the camera or other things.

### The light within

(**Exterior**)

A dias where you can cast a light? Or I suppose just the general idea of having a torch or something along those lines? I.e. casting shadows by pointing a light at them. F for flashlight?

### Accumulations

(**Exterior**)

i.e. the idea of just having one or more installations outside that involve multiple shadows combinining in fun ways? Archways? Lattices? More organic shapes? A chance to mess around a bit and not care too much about formality, just to try out shapes.

### Motion / Animation

i.e. the idea of a moving light source (again probably interior) or a moving object (could be exterior). Lots of potential motions here including orbits or linear motion or weirder motion. But also the question of scale of object, rotation, and also area of effect of the light.

1. Moving light (**Interior**)
    - A point/spot light that moves - could orbit, could linear, could rotate (spot)
2. Moving object (Could be **exterior** or it could be oddly distracting outside...)
    - An object (cube?) that moves and casts a shadow that will inevitably change? Could even animate a pole that goes up and down out of a peak to show a lengthening shadow effect?

### Color

**Interior** and **exterior**

i.e. Changing colors of light presumably changes the color of the shadows? Would want to test that. This could apply to a room (Olafur time, Turrell time) or to the sun itself.

### On and off

**Interior** and **Exterior**

i.e. the idea of a light source (or object?) turning on and off, so there are shadows and then no shadows or different shadows. No need to go quickly and give anyone a seizure though. Maybe a small sound effect (a click) to indicate it happening? If lights go on and off should connect this to the physical instantiation of the light (switch materials I suppose? Or switch of emission? Or something.) Could do this with the sun too, a dias that simply switches it off while you're on it. (Also: that guy... Martin Creed)

### Quality

(**Interior**)

i.e. the ... wait can you do this per light? Yes. So lights with the different levels of shadow quality in a single room.

### Cookies

Sounds **interior**

i.e. Lights can take cookies and it might be interesting to create a specific shadow cookie (how to represent that on the physical light if at all?)

### Strength

Sound **interior**

i.e. Lights can cast shadows at different strengths.  So create a room with lights that accomplish that. Spots are going to be the main kind of light for a bunch of these demos I kind of feel because they won't create as much interference -- though again I should test this out with point too because that interference/combination could be quite lovely?

### Realtime shadow color

Could be **exterior** on a dias.

This is an environment setting on the Lighting panel and I'm not sure if it can be changes. Maybe via code? In which case it could be a dias, but it somehow sounds a bit annoying? But if I don't include it I'm in a situation where I'm not demonstrating one of the core proprties of Unity's shadows

### Dynamics

Oh god, what about dynamically changing properties (like bias) rather than demonstrating separate things? Or both conceivably? Starting to feel like a shitload of rooms. On the other hand it's a way to have a single light-source that changes dynamically...

This is a relatively major one. Is it better to see change over time or change over space.

### Outdoor Lights

(**Exterior**)

Some variety of maybe toggling lights outside - a huge spot that illuminates the world, a point light in the context of the outside, etc. More diases.

### The sun

(**Exterior**)

Some ways of seeing the impact of the sun on the world. Most obviously its rotation through a day/night cycle, but also other thoughts like colour, brightness, etc. that should be changeable (again have to think about permanent changes versus "while you're on the dias" changes) On/off.

I'm leaning now to thinking that all changes are just "on the dias" and that when you step off it animates or simply snaps back to the default setting. I think I like that more and it allows me to be totally intentional with the default position of the sun. Even though it necessarily means that you couldn't do an "interior at night"? But maybe...

### Interior at night

A room where on walking in a trigger makes it nighttime outside and you have a window that it's therefor moonlit or similar, plus the exerience of looking through the door and window and seeing the night. If there's a moon it should be visible from the window of this room. That sounds quite lovely. Clearly **interior**

### Gold

I keep forgetting I need a gold material to demonstrate the idea of that in combination with a dark and shadowy room, the alcove (maybe make an alcove). Will have to be **interior**

### Materials

Do shadows look different case onto different materials? Like how do they respond to normal maps? Something to look at and perhaps experiment with. Could be **exterior**

### Objects

Demonstrate the shadow of the primitives and of a mesh or two. But also what happens when a shadow is cast *onto* these different shapes. (This could be **exterior**)

### O, Cloudy Day

What if there were clouds moving slowly up in the sky?
