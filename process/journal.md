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

For the record the WebGL build of the currnet project (a character controller on my shitty and gritty island) is still landing at 8+ MB, but hopefully a big chuck of that is just basic Unity-stuff that's avoidable? Will keep an eye on it.
