# Process journal

## Initial notebook sketches -- Tuesday, 15 August 2023

(This is a retroactive commit of the (iPad) notebook sketching I did in starting to think about the game.)

[Early sketching and thinking on 15 August 2023](./pdfs/2023-08-15.pdf)

## Started a Unity project -- Thursday, 17 August 2023

Well, one of the big things is just opening Unity and I can at least claim to have done that over today. I created a Unity project in the most recent LTS version (2022.3.7f1 LTS for the record), made a cube, and built it for WebGL so that there's something to see. Then built it again with a decompression fallback because it didn't want to load. Now it loads, but I observe that there is the typical irony when you don't really plan things out: there are no shadows in that first build. Because there's only a cube and nothing for it to case a shadow on. And I guess because of the angle of the camera none of the visible faces of the cube are shadowed either. So, haha.

At any rate, the project is underway. Next step is to fire up ProBuilder and hope like hell it behaves better in this build of Unity than it did when I was trying to use it in v r $4.99.

## The shitties and gritties of terrain -- Monday, 21 August 2023

I actually did some of this work on Friday too but I've been avoiding committing because the project was in such a messed up state. But right now I'll at least commit this journal and some thoughts on the current process.

Specifically, I've been interested in setting up v r 5's buildings and shadows on an island. So I grabbed a (the only easy to find) free island from the Unity asset store: [Free Island Collection](https://assetstore.unity.com/packages/3d/environments/landscapes/free-island-collection-104753) by Bicameral Studios. These are some nice islands my friend, notably enjoyed island 4, so I brough that into the game and was immediately confronted by the fact that its textures added up to around 200MB. When I built the game for WebGL it was landing at 104MB with just the island and a character controller which is... just too big.

But I like the idea of at least some sense of an organic landscape to go along with the more formal shadow stuff and the buildings, so I started playing around directly with some of the textures inside the pack, sizing them down, sizing them up, over and over again. Until I could barely understand what I was seeing. For instance here are three different resolutions of texture and normal map (as well as sometimes sizing down to lose information then back up to meet a resolution standard like 2048x2048):

![](images/terrain-textures-1.png)

![](images/terrain-textures-2.png)

![](images/terrain-textures-3.png)

I spent a while trying to figure out which was which until I realized something important: they all looked shitty.

So this morning I've gone back a step and made my own horrible island

![](images/my-own-horrible-island.png)

in order to check out texturing and stuff from first principles... ish. Which meant I again grabbed a cliff texture from the island pack then downsampled it to 512x512 then back up to 2048x2048. So now the diffuse adn normal maps are both under 100KB for that one texture which is seeming more reasonable for a web download. They look gritty as hell, but I think in a way that's hopefully acceptable down the line?

![](images/gritty-texture.png)

So a kind of mid-res thing going on. My next step I think is to regrab the island and either retexture it with my downsampled textures (I hope this is doable as it would be the easier option) or export the height map and retexture is manually (I hope I don't have to do this).

Then I would have, in theory, an island with textures and I suppose I could add grass (downsampled?) and so on to a point where it looks inhabitable by this latest museum.

So that's what I'll tackle either now or tomorrow morning.

For the record the WebGL build of the current project (a character controller on my shitty and gritty island) is still landing at 8+ MB, but hopefully a big chuck of that is just basic Unity-stuff that's avoidable? Will keep an eye on it.

## Early questions -- Wednesday, 23 August 2023

Spent a little time this morning tweaking things per commit [8070ad9](https://github.com/pippinbarr/v-r-5/commit/8070ad9c3b371077d9fa38364af1c50f1af55aa4).

I'm roughly at a point here where I can think about moving forward with building some structures to see what it looks like. All kinds of questions to think about and experiment with

- Should the structures be labelled in some way? Especially if I use some kind of default shape for creating a "dark room" it might be good to distinguish them. But on the other hand what would it be referring to?
- Can I get some kind of a gold material going that does "stuff" like "gleaming" in different light intensities? That being one of the most memorable elements of the book - the idea that shadows serve to emphasize other things, although of course I'm interested in looking directly at the shadows themselves just as much
- You know I hate it but: baked or realtime? Leaning realtime because it's simpler and provides a constraint (and allows movement) and I think has a lower filesize? Not caring that much about realism. The only problem I imagine coming up is light bounces? To create different gradations of shadow you might need light bounces
- What am I lighting with? One extreme option would be *just the sun/Directional light* but of course I could and probably should consider rooms with point lights, spotlights, etc. since that gives us a kind of taxonomy of shadows.
- Ideas like invisible objects casting shadows could be a fun (taxonomic) idea to play with
- How involved in architecture do I want to get? Some of this process is reminding me of the Quist chapter in *The Reflective Practitioner* in terms of all the complexities and expertise of architects - the site and all that. I want this thing to look... well nice and intentional, but I don't want to labour TOO hard on that effect, so simplicity will be key.
- Moving lights? Do I want the sun to be on the move all the time, or do I want to provide buttons/opportunities to make the sun move through a cycle so you can watch the effect in specific locations?
- At some point I need some water right? (I mean I should really start the [to do](./to-do.md) list soon)
- And yeah I need to learn probuilder more fluidly - last time I used it I could only make stairs sideways and had to manually rotate them which felt... pretty stupid. Also: no grids? Whyyyy? Oh I found them. Okay I'm alright again.

So there's a ton to think about, but it's pleasing to be getting closer to building this out to try to understand what I'm thinking about here.

Probably a good step would be to literally taxonomize what possible rooms/installations I should have. So let's do that tomorrow.
