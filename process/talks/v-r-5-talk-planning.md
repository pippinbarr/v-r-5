# In Praise of Shadows: Chasing Reflections, Prototypes, and Other Traces of Design

## Wednesday, 27 March 2024 – Thursday, 28 March 2024

I am going to begin thinking about what this talk is meant to be.

I'm going to give it both in Utah and in Texas, so a double-whammy.

General point (per the title) is to trace the process of *v r 5* both for itself and to demo and reflect on the role and process of MDM.

### Brain dump where I just note anything I think should be in there

- Real-time play / videos / images of different prototypes (in diminishing order of insane difficulty)
- Demonstrating that those prototypes/stages ARE ALWAYS AVAILABLE
- That they are also TIED TO A COMMIT and thus reflection and code-level changes
- The issue of projects using not CC/Open Source components is real
- Mostly direct quotation of the documentation as the slide deck itself (in a fantasy version some kind of weird thing where the whole talk is just links to the literal documentation)
- An explanation of what the point of the project is in the first place, what I wanted to explore (the strange stability of that as well, which is odd)
- Emotion? The all to real fuckedness of trying to work on something?
- TRACES OF DESIGN and demonstrating how we're capturing really subtle really basic stuff by doing what we do
- An explanation of MDM, the research project, the vibe, my specific role as an old-timer who follows the process in general for every project I do
- Some indication of how we perceive the following analysis or does that start to get to be too too much?
- At some point the gag of showing that the talk itself has been developing in the same repo as the project itself? Ahahaha, the crowd laughs nervously.
- What do I want someone at this talk to come away with though?
  - A basic working knowledge of what MDM is and what it looks like from a designer/data standpoint
  - An understanding of what I wanted v r 5 to be (and the degree to which I realized it)
  - What it looks like to make a game from the beginning and the granularity and strangeness of design in conversation with materials
- I suppose I should mention my book as context as well, a personal obsession, something I'm always trying to explain/surface/promote is that idea of seeing the matrix almost, contemplating the constructedness of games both to understand them, to question them, to see the beauty in that and not just in the fiction/feeling -- that contemplating the technical aesthetics is a kind of beautiful contemplation itself
- Can this be funny? Yes it can because lots of stuff happened that sucked and it's funny when shitty things happen to someone else
- The aesthetic power of that question... what if you could go back in time and relive that moment, dwell in it, think about it...
- The escape from post hoc rationalizations, hallucinated process, ...

## That part where I start pasting in stuff from the documentation

### Journal

> Now it loads, but I observe that there is the typical irony when you don’t really plan things out: there are no shadows in that first build. Because there’s only a cube and nothing for it to case a shadow on. And I guess because of the angle of the camera none of the visible faces of the cube are shadowed either. So, haha.

- Starting ironies, love-hate tech, never getting what you expected, living laughing loving learning

> These are some nice islands my friend, notably enjoyed island 4, so I brough that into the game and was immediately confronted by the fact that its textures added up to around 200MB. When I built the game for WebGL it was landing at 104MB with just the island and a character controller which is… just too big.

- Tech anxiety, size size size

> I spent a while trying to figure out which was which until I realized something important: they all looked shitty.

- There's just a general thing early on of trying to make something that looks like something but also isn't enormous because I've been so preoccupied with WebGL and accessibility even though nobody actually access this

> All kinds of questions to think about and experiment with

- Constant framing and reframing of what I need to think about - early versions

> - How involved in architecture do I want to get? Some of this process is reminding me of the Quist chapter in *The Reflective Practitioner* in terms of all the complexities and expertise of architects - the site and all that. I want this thing to look… well nice and intentional, but I don’t want to labour TOO hard on that effect, so simplicity will be key.

- Picking your battles, knowing your limits, but also dreaming and pining and failing

> And yeah I need to learn probuilder more fluidly - last time I used it I could only make stairs sideways and had to manually rotate them which felt… pretty stupid. Also: no grids? Whyyyy? Oh I found them. Okay I’m alright again.

- Tool anxiety

> Probably a good step would be to literally taxonomize what possible rooms/installations I should have. So let’s do that tomorrow.

- Taxonomization and formalisms

> Just a quick MDM aside: thinking about the differences between journals/todos and actual design documentation. As of right now the method doesn’t really include a formal spot to characterize the design of a project because… well it’s just the way I work. But I note that with *v r $4.99* I had those “curation” documents to separate out a specific kind of work. For more complex games (maybe especially more game-y games) does it make sense to have the way the game works specified out in a text, in a … design document? Never really thought about it, but it’s worth parsing through.

- Meta-reflection on method (this recurs)

> Nature of shadows in Unity

- The first of many reflections on trying to get a handle on "what *are* shadows?" "we just don't know"
- But also just this leap involved where... the idea is SO CLEAR that much of the thinking is really detailed and about examining something close up...

> A shadow “feels different” based on what you’re doing, the kind of place you’re in, the scale of the space, how you entered the space, and on and on

- Flirting with woo, never embracing it, the perpetual self doubt around things that escape formality
- But also Geraint on: formality is funny because it's just so fucking hopeless

> So, these are a large number of possible effects. And of course they can easily be combinatorial - soft shadows from a direct light on a large cube that moves in a circle versus hard shadows from a direct light on a large cube that moves in a circle versus…. And I don’t think the island setting is the right place for rigorous combinatorics as in *v r 3*, rather I want it to be an *experience* of shadows, and I suppose it needs to be *curated*, but I’d like it, too, to be an experience of the different kinds of shadows so that there’s a chance to think about it.

- The oscillation between experiential and formal, the lack of confidence in the former and the run to the embrace of the latter

> So the island is “in praise of shadows” which means it needs to “show off” Unity’s shadows. I want it to both provide an opportunity to enjoy shadows as they are (and as the book kind of talks about them - though in the book it’s more about dimness a lot of the time?) as well as to reflect on the technical marvel of implementing shadows in an engine, as well as probably some of the comedy involved.

- Trying to figure out the core premise (I don't know that I ever truly did figure it out?)

> One thought (and here I’m thinking a little bit of *The Beginner’s Guide*) is to have a single room type (corresponding to that game’s single door type). And there are instances of that room all over the island that all equally cut out entirely or mostly the exterior directional light so that you can focus on what is inside. Designing that space would be a very important aspect of getting started.

- Identifying architecture as central. Control.

> So then I’ve been literally importing my textures as 128x128 files which does lead to appropriate smallness in the build, but they’re a bit blurry as I guess the default behaviour in unity for (what, the shaders?) is to blur/stretch rather than render hard edges. Can I perhaps write a shader that doesn’t do that, would that work? Can look into that.

- A problem solved with help. Help I don't seek enough.

> All of this isn’t that interesting but having the island settled just *feels* really important to me, which is stupid and annoying but true. Really I could (and should) also work on some of these enclosed rooms since they don’t strictly need the island for testing.

- Contrasts between the formal and the emotional

> So my current worst case (which I still need to test step by step) is to build my own terrain with low resolution assets and texture it myself with the terrain tools and… well, just hope that it ends up being small. I suppose I’m “learning” something? None of this has a lot to do with shadows beyond the idea that context matters and there’s a strong feeling in my soul that it’s better to be casting shadows on more organic feeling territory than on something immediately pegged as “low poly”.

- This makes me laugh. The "learning" in quote marks. The agrieved feeling of not just being able to do what you want. The push and pull with the tool which is also ultimately just a kind of push and pull with yourself?

> Today, per my previous commit, Jonathan Lessard managed to save me serious trouble/sadness by pointing out you can set textures to use a “point” filter which means they scale based on nearest-neighbour or whatever, preserving hard edges and that minecrafty look we know and love. So now it’s become possible to use my 128x128 textures, scale them up so they’re less repeated-looking, but to keep them crispy instead of blurry. The result being that I think the island looks pretty nice and it’s exporting at 9.2MB textured (though not textured well enough yet).

- The help moment.

> I don’t *seem* to be able to convince Unity to “just” use the original Island in a low-size way. Wait I’ll try something quickly…

> I am trying to use the new point-filter thing to convince the “cool island” version of things to be smaller - let’s see if that works to drop down the texture siiii… nope.

- The existence of time in writing? There's something strange about this that I really like...

> Texturing the island ON MY DAMN OWN to try to make it look convincing enough (this is hard)

- Just acknowledging that things are hard. Emotion.

> I even made these two images (one is the original island one is mine) to try to figure out areas where my texturing deviates (always assuming the people who made the original Island are texturing geniuses etc.)

- Awareness of being situated in a larger community, questions of expertise, the solo developer

> Also a quick MDM note: I’ve been noticing that a frequent flow at this stage of the project is to try out some tech solution (e.g. all my to-ing and fro-ing about how to get smaller builders, interestingly crunchy textures, etc.) find that it doesn’t work at all, and then Discarding Changes in VS Code to get rid of the evidence. *Should* I be including every step in the repo? It doesn’t strike me as an interesting part of the process, just trying to settle very fundamental tech issues, and I *am* reflecting on the process in fairly fine-grained detail here in the journal, so I think the “thinking” part is still there. The bit that’s not there is mostly just dissatisfying results in the unity build that don’t necessarily communicate much and might just “take up space” in the repo.

- MDM reflection

> Then ran into the draw distance for the details meaning that the grass is constantly “teleporting in” as you walk which looks distractingly stupid, so found the setting to essentially make it always visible.

- The infinite layers of odd disatisfaction and chains of understanding what the aesthetic is through the technical implementation?

> Compare this before and after, which I’m somewhat proud of (and which also includes the draw distance setting being ramped up now that I look at it):

- Good images here. Honestly pretty nice.

> Dear diary, I finally made a dark room. The island itself seems to be in sufficiently good condition that it felt time to move over to shadows.

- A good beat

> Actually, in the weekend I was showing it to Felix as well and we made a really tall square pole kind of object and I was then stunned by how long its shadow was going downhill - hills and shadows eh, who knew.

- Moments of learning in situ, conversations with materials

> And that word “floorplan” makes me think of the fact I did a bunch of drawings last Friday on that subject, so let me get them in here too…

- A reminder of that PDF, a rare sketching mode. And it's pretty fucking compelling imagery I think, relative to the game and the design.

> Going on from those sketches of floorplans, as I said, I finally used ProBuilder to make a sample room, which ended up like this:

- Good image

> Which is to say I did manage to get a room that’s a reasonable first draft of a setting to observe a shadow in a more or less controlled environment. A few things on that process:

- And then a bunch of observations - that idea of how much you learn by DOING a thing. This is prototyping.

> Which also brings up questions of labelling and wayfinding - do I want a map? Do I want to number or letter or something the buildings to distinguish them?

- First instance of wayfinding

> But yeah if all the buildings are the same does that kill the mood a bit? Or am I just making myself trouble? I suppose to the extent that I become “extremely good” at probuilding this kind of simple, brutalist, concrete form building I can make custom ones as it pleases me - maybe even “in conversation” with specifics of the landscape.

- This architectural thread stuck around for quite a while but died due to effort, a mismatch between me and the tools largely... that idea that things "look like" what you can do

> Shadow acne, 5 o’clock shadows, shadows everywhere

- A post about shadow acne stuff and the ramifications of changing bias

> And **NONE** of that looks naturalistic. And I think one of the problems I have with that is I’d like the exterior environment to look kind of “normal” and to keep the freakshow experiments inside the rooms in more controlled environments?

- A line in the sand

> Which **ALSO** is a thing because the behaviour of all this in WebGL is *another* issue that appears separate. For instance when I “solve” the acne with hard shadows and a high resolution shadow map for the real time shadows, the WebGL version still exhibits what looks like a tiny line of texture fighting at the seams of the building. Maybe I can beat that with vertex welding? So many shitty little things to think about.

- Hell

> And again I stress that this is also funny and maybe an *opportunity* because it’s **NOT MY FAULT** that all these things happen: **THIS IS THE TECHNOLOGY AT WORK** and to some extent **THIS IS WHAT I AM EXHIBITING**. I thought it would all be beautiful and “aesthetic” but maybe I will also be demonstrating how shit things kind of can be?

- Important. (Can this whole talk just be quotes and expounding on them?)

> The most troubling trouble for right now is that when I put a (separate cubes) roof and floor onto the walls of the room the seams are visible in WebGL - though not in the editor (and maybe not in the app). I cannot for the life of me understand why. Is it a texture thing? Is it an “edge-fighting” thing between the meshes? Do I microposition them separate? Do I then run into some other bullshit? Is “edge-fighting” a thing…?

- The limits of knowledge... often feels liminal between a total beginner and someone who knows, and that that is an incredibly frustrating position?

> And on top of all that shadow acne is back in WebGL probably because of some other setting I added perhaps to do with the hard shadows or other stuff I was doing to try to solve … shadow acne. Fuck me.
>
> Here’s an image:tThe left building is blender, the right is probuilder, shadow acne on both at a certain distance. Whee!

- Emotion (image here as well, and I do find this funny)

> In amongst all this and as I think I’ve remarked but haven’t yet dived all the way into reflection-wise, is the ways in which all of this (well maybe not the UV unwrap and the seaming) *is* a part of how Unity renders shadows - what shadows “are” in the context of this engine. Shadow acne *is* shadows. That is, it’s a reflection of how the engine tries to render shadows - yes it’s “wrong” in the sense of not being naturalistic, but it’s also “right” in the sense that it’s the engine’s idea of shadows in these circumstances. So…

- Recurring questions of aesthetics around naturalness and beauty version the technical versus the technically broken

> And it also means that I need to let go (somewhat) of the idea that the island and its shadow will be by default *beautiful* as in the essay that inspired the work (In praise of shadows) and maybe I need to remove that from the title for that reason. It’s more about “in reflection on shadows” or something along those lines right because we’re trying to see the shadows as the engine understands them, not in some “artificial” (ahahaha, this is so weird) way where it’s only about naturalistic effects. It’s all about engines and realism and shit.

- Something in here worth thinking through

> In principle I think this could allow me to return to a modular structure, but for now I just have the room as a single unit. Interestingly (?) this does make for an experience where I have to install/experience the curation of the interior light works from inside the room - no lifting off the ceiling and floating on high. On the one hand this is going to be cramped and inconvenient, on the other hand I kind of like the reference it gives to really doing this in person and the kinds of perspective you’re forces to have – a classic tension in making games versus playing them in terms of how you’re situated relative to the world, god or person.

- Physicality, materials

> And of course it’s a continuing reminder that the shadow acne looks kind of cool and Moire-ish. And that I’ll want to do that on purpose. But I ultimately want the exteriors to have as little non-naturalistic lighting and shadows as possible as a default. I like the unnatural stuff to be at least somewhat under my control. Control control control.

- Control

> Anyway just wanting to remind myself of and give a sense of the sheer amount of research and failing one does in these situations. Things I have looked into at some level as a potential help when trying to understand how to make webgl look alright (haven’t tried all of these, it’s ongoing)…

- A list ensues, good to have this kind of level of specifics

> So there’s a lot and of course these things all potentially *interact* so it can be *very* hard to know if one thing is making a significant difference.
>
> And there are plenty of other things I fiddle with I’m sure but I’m just trying to give an honest profile of how much scrambling is often involved in this kind of work - compromises, failures, realizations, re-realizations, crushing realizations.

- I think this is a good beat, really sums up a whole element of a project like this? But I wonder what it says about projects not about this?

> And second of all a room with a cube in the centre (well, by eye and this is of course making me think about how I’m *not* easily hable to measure to the centre and perhaps I should figure that out? A little marker?). And a pointlight on one side that casts a shadow into the corner of the space which create a sort of shadowcube based on the way it falls on the corner’s structure. It’s not something I was actually looking for but just came up when I placed the light and moved it around, so I’m happy about that. It felt like a mini-Turrell moment?

- Image for this, that turrell moment was nice

> This week I’ve managed to actually start a pretty comprehensive [list of works](https://pippinbarr.com/v-r-5/process/list-of-works.html) and work on some of the simpler ideas around interactivity in the world (diases you stand on to affect the sun). Overall this has made the project seem pretty doable.

- Splitting into curation-mode

> Also just aware of a tendency to maybe try to find imperfections and problems to avoid construction. But also aware that if you jump into construction you can find out quite late in the game that it would have been way better to do things another way instead of the shitty way you did them.

- Awareness of shittiness

- That time when the water was all jagged... there are a few potential before and afters?

> If I have the energy I can look into making a reactive skybox that has my beloved pixels. But realistically I dunno because as soon as you have a cloud or something (that shows off the pixels) you’re going to expect the clouds to move if the sun moves and then you screwed. I suppose I could have meshes for clouds, but that’s… well actually the shadows of clouds moving across the terrain would be kind of rad? Uh oh. Well I’ll think about that.

- Being scared of scope. Scope scope scope.

> The other thing I did was play around with the spotlight idea, having a dias that turns on a strong spot. Spent quite a while feeling it didn’t work (didn’t seem to cast a shadow of my building) before realizing the shadow was getting washed away by the sun light source. So there’s that aspect of shadows too… a shadow for one light can be cancelled out by another light. Which is kind of interesting really and probably worth demonstrating? The vulnerability/dynamics of shadows?

- But I never did this

> Spent most of my allotted time today desperately trying to be clever about creating reusable pieces for constructing rooms, even to the level of giving them edgeloops and stuff that was meant to make it easier to align vertices. But noooooo, it was not easy and it did not work. I was quietly confident but there were weird texturing issues, texture fighting, seamy stuff, and so on. So… fail.

- Sigh.

> - I’ll be damned if I can figure out how to make a nice L-shaped structure, but also: fuck that structure. I was only going to do it for variability of shapes and I think I can do that in different ways…

- Haha. Probably just searching for swearing would be generative.

> Anyway, I’m claiming in this moment that I will simply stop trying to be fancy and will instead focus in on just using the building I have.

- But did I?

> Which… well it’s progress in terms of the ways in which behind the scenes the room was made in Blender and appears to sustain 0 bias nicely, or how it’s prefabbed with entry and exit triggers tied to the lights, or how I tested probuilderizing it and extruding some of the surfaces successfully.
>
> But it’s also just hilarious that these are pretty much the same two screenshots I posted in late September. So a month of battle with 3D modelling, UV unwrapping, the lighting system in Unity, prefabbing, and more. But… I kind of feel like I have, finally, come out on top?

- Funny image comparisons. The same image over and over. The question of what is design and process and what is paranoia and obsession and waste

> Okay well I *did* start the install process as you will see from the commit subsequent to that previous journal entry. And as you might imagine when the rubber meets the road and when the hands get amidst the materials of creation and the shadows mingle… it got complicated almost instantly.

- More learning by doing, the value of jumping in. Almost all the learning and work has come from acting on the materials not from the planning. The idea that making a game (that is different in some way) effectively can't be done without prototyping and feeling it

> In essence there are a lot of things about the engine itself and how it works that are interesting from one way of looking it (like a maximum number of pixel lights per surface/mesh) but are probably just *not that interesting* to a person visiting this island.

- THe question of the audience. How well did I do with this in the end?

> So what do they want? Well nothing much specifically but mostly to look at things that are… interesting, surprising, beautiful, poignant? And that in combination with my almost educational-orientation yields the game. Do I want to “teach” them that you can only have two pixel lights per mesh? I think probably not right? That doesn’t sound very interesting even if it probably *can* be in some way…

- More audience

> A quick entry to document some invisible work. I spent some time this morning building a tunnel through the “mountain” in the centre of the island since you can delete individual terrain tiles and therefore make a structure that passes from one side to the other.

- Invisible work is a key idea (note how ALL work is invisible unless it's documented)

> I mean I think that’s a major generative tension both in the making and hopefully the viewing for this project. **Realism versus Engine**. Because it’s very much wrapped up in what Unity essentially *projects* as the objective (“this is realistic”) versus what is achievable without ridiculous trickery and hyper-specific modelling, lighting, baking, positioning, and more. So I’m happy with continuing along those lines.

- Important theme

> It’s useful relative to *v r 5* in the sense that I’ve wanted to explore that core idea of temporal sequencing of shadows (suddenly recognizing I need moving lights) anyway. So this gives me a chance to look at it.

- Zium

> I have to say that, having a working thing kind of put together I felt (as I noted in the associated commit) kind of sadly underwhelmed. I think some of that may simply be to do with general work vibes right now - I’m tired. Some of it may also be to do with the sort of ramshackle layout I’ve done of the lights and cubes, so that it doesn’t look very “professional” or whatever, something I can fix. But yeah is any of it ultimately like… well that’s not that great.
>
> I don’t have an answer to this - I guess I have to magically be less tired, and fix the layout. I wonder, too, whether the lack of apreciable texture on the walls (something I’ve been struggling with frankly) is part of the problem. God forbid I have to take a look at that though. Texturing. I shudder. Maybe even just a bit more geometry on the walls? Some indents, some larger sense of concrete place?
>
> Maybe the space simply feels a bit dead, not real. It’s not meant to be all that real, but it’s meant to be somewhere. These are things to think about.
>
> I think that the fact of the Zium, the idea of an audience, the need to do a sort of vertical prototype in essense, is all helpful in addressing some of the questions that are maybe otherwise easy to not deal with during this sort of extended exploratory phase? The *So what?* becomes more apparent.

- Emotion

> Guess what? The Common Front and FAE unions in Québec have been on strike since 21 November which has meant Felix has not had school since then. What day did that land, you ask? Essentially right on my last journal entry and last work day on this project, because it’s been pretty well impossible to get anything done since then. With Felix at home there’s just not quite the same level of quiet that I feel like I need for this work.

- Real life

> In the interim I’ve been playing a lot of *The Talos Principle 2* with Rilla and Felix and that has a really powerful sense of place. In a way it’s maybe making me feel *worse* about *v r 5*, but in another way it’s probably a useful inspiration while also being a… well I can’t do *that* so maybe I shouldn’t worry so much about things? Again the point is to *see the shadows at all* and then to *see the engine’s relationship to shadows* within that. My existing plan is fine for that.

- Competition

> Also we’re getting to a point where it’s also like… fucking hell let’s just finish it up and move on with our lives, this is not my life’s work. A bit early to have that feeling, but it’s possible this is one of those projects that kind of gets over conceptualized until it feels very dry and inactive. Probably that when I get back into really making it there will be more opportunities for surprise.

- Realism

> Time to reflect kids. Because reflection work makes the dream work. Writing down what has been happening and how I’ve responded to it is a big part of understanding how the design part works. Maybe most of all because you have your overarching perfect design idea (exhibiting shadows in a game engine) but the reality of that is a totally different kettle of fish, and when you actually engage with the materials (the lights, the shadow settings, the textures, the terrain, the architecture, and on and on) you learn things and bump into things and dislike things and worry about things and feel things and all that is what actually forms the *meaning* of the design, the expression of it rather than the abstraction of it. And all of those things are what the player eventually runs into and thus potentially has similar or related feelings and thoughts about.

- Word vomit about design

> I’m designing by reflecting on what there is and what I can do about it. And because it’s taking place through writing (or drawing or whatever other form of explicit response I take on) it’s intentional design, accountable design, design that’s tethered to the beats on technical practice. And those are the things I want out of design - I want to know and notice what I’m doing, see the trail behind me and the weeds ahead.

- There's a whole lot of stuff here, largely about MDM and design reflection

> Most of all because I finally bit the biting thing and started just speed-prototyping all the installations. An embarrassing realization there was that I could prototype them all in the same instance of a room and just enable/disable thing, rather than thinking kind of literally and wanting to make every separate room from the beginning. Giving in to the idea that all the rooms will be the same base structure and so it doesn’t matter. Also giving in to the idea of *prototyping* the exhibits rather than needing to nail them down one by one. Which is to say, really fucking *obvious* stuff that should know by now.
>
> BUT I suppose there’s a bit emotional component to being ready to realize something like that? Just how much should I beat myself up about it? How much of that readiness comes from all the previous work and just general mental stuff, and how much of it could have been churned out incredibly early? I honestly don’t know… my tendency not to beat myself up too hard about stuff thinks that it just needed to happen this way, but I could just as easily be wrong.

- Realizations. embarassment.

> If the point is to exhibit shadows and I want the audience to *think* about them and experience them as something worth witnessing, then just telling them “it’s about shadows” is probably only part of the work - people don’t necessarily have the capacity to sit there and look hard at the shadows and think about them. Worse, that’s not *my* experience of them in making the game - my experience of them is highly dynamic - I move them around, I see them changing and I have feelings about them because of that. Which is to say that I’ve more and more wanted just a bit more visual interest and maybe dynamics throughout.

- A realization about the differences and similarities and desires between player and maker

> I implemented the orbiting light, where a point light moves in a circle around the cube (sans vase right now, but it will be vased) and it was just so much more interesting to look at. Unsurprisingly of course, but it made me look at the shadows in a totally different way once they’re changing. You can still see their nature if they’re moving (have to get the speed right) but the movement somehow *foregrounds* the shadows, I suppose because the shadow moves and the object doesn’t (though I should have a moving object one).

- Realizations galore

> The continuing saga of me making buildings and remaking buildings and fretting about buildings.

- Nice images. Going through the images will be a big help.

> This has been an interesting moment - there’s all the excitement of “discovering” the vase and the dynamic movement as a kind of default or much more common factor in the rooms; *but* to go with that is a sort of destablizing of the meaning of the rooms.

- Consequences

> Just taking a moment to reflect on the project as it stands… actually just a grab bag of stuff I maybe should spend more time either thinking about or doing (because I don’t have time right now, gotta run baby!):

- Explicit reflection on documentation method during the documentation method

> Well not that actually but I’ve found myself thinking, perhaps especially because a couple of exhibition opportunities (A MAZE, unidentified online exhibition, Now Play This) are looming, about how you present the documentation - maybe especially when it’s even *still in progress*. I feel like there’s an opportunity and a danger associated with deploying commits and builds *with an eye toward them being seen as a kind process art*. Like, there’s extra work involved and it could be a distraction… but should I think about my documentation and process as *part of the artwork* and not “just” a separate (and valuable) documentation repository? My instinct is always that documenting should be easy and should feel like there’s no audience outside myself but… that might not be true. How performative and *usable* should my documentation be not just for a committed scholar (hi scholar, I’m sure you totally exist) but for more casually interested folks?

- This other kind of audience...

> In this project and in **so fucking many projects** I have this realization way too late that I’m bored because something about the project is boring and I need to fix it. In this case the “undisclosed exhibition online” (which I’m now realizing is totally disclosed in this repo and that’s… well probably it’s fine, I’m not shouting it from the rooftops) really rammed home to me how bored I was by my own exhibits. But the formalist in me kept going “fuck you, it’s a formal exhibition it’s meant to be boring”. I have this endless tension between formal rigour of my idea and the idea of someone actually experiencing it, how much of a “concession” to make. I’m kind of bored of realizing I’m bored. This feels like a major design thinking idea and moment, I should look into it. There’s probably like 10 books about it.

- Major beat

> I’m much happy with how individual rooms actually *look* now, but that too has had major changes. Most notably the idea of an active/dynamic light every time, even if movement isn’t the “idea” - so the basic pointlight drifts a little just to make the room feel like it’s alive. Also I’ve started positioning the lights in front of the plinth so that they (by and large) cast a shadow to the back wall, which has introduced other considerations (how lights should move, how far the plinth should be from the back wall, how the vase should be oriented) which has… broken my prefabs quite a lot - the whole thing is a bit of a mess in some ways at this point. BUT that’s maybe okay because there’s ANOTHER mess anyway which is

- Lots of learning here

> For some reason and as some point, the shadows/illumination levels on the building itself (built in Blender) has become utterly fucked! Like big square patchs on the roof as an example (but it’s interior too):

- More fucked

> Well then, 9 days later, I’ve replaced everything with the new construction and made every single room I’ve been planning to make?
>
> Which is good timing because Now Play This got in touch yesterday (or the day before?) to say “okay, ready for the build!” and we had to negotiate a (not-too-big) extension. So I’ve got roughly two weeks to pull the whole thing into shape.

- Timing

> Could also contemplate literal paths as a texture on the terrain? Sounds kind of gross and like I might overreach to such an extent I create something ugly. But generally the question: how much guidance do the visitors need? How much do I care? How much can I care? How much can I bend what skills I have to this task?

- Caring/passion versus skill/ability

> I had a first wee go at making a “sculpture”, ripped off that bandaid, at least a bit. As is typical with a prototype (I am listening to the Behaviour event at 4th space right now about prototyping) it helped to frame things up. Though I guess a bit contra prototyping best practice I do feel like… it made sense to just make “something” to try to find out what I’m looking or. I made (as per the commit) a kind of upside down multileg table, I positioned it as if dropped from the sky, I added a point light to cast shadows outward. It looked kind of cool. But also it looked like I didn’t know what it was for and I promised to reflect and here I ammmmmm.

- Ammm. Prototyping.

> And do I feel like it does what I wanted? When I think back to the original sketches and ideas? The weird thing is the absolute earliest expression of the project is a PDF from mid-August, pretty much when I started that is… a pretty good expression of how the game itself turned out. Like the core vision (look at shadows) has been stable, and even the architectural design has been stable, and a lot of the time has been technical fights to bring that vision about (how much time have I spent making the island and fighting in Blender (and elsewhere) to make those rooms a reality?).

- Reflection and looking back

> Which… again, I’m taken aback by how much the project has been just this. Did I learn *nothing*?? And if I didn’t, isn’t that weird? Or… what does that mean? It was sufficiently well-defined that it was “just” an implementation challenge? Is that why the journal has been harder to write for this project? Maybe because there were so many conceptual challenges? Whereas the commit history has been really fruitful and where the action is.

- Funny how much I think throughout that the journal isn't significant and yet it is 20,000 words long

>BUT, guess what, I still pretty much make these things because I enjoy making them and I enjoy the brain-feel involved in it. The release and the feedback is vastly less important. Don’t ask me whether any of this matters though. Please.
>
>So mostly my brain is doing the classic two-parter of “let’s move on to the next project!” along with “let’s never do anything ever!”

- An ending?

> Well because in doing so you have to think very specifically about the materials of game design directly, not just taking them forgranted as the stuff you put together. If you’re designing to make them heard/seen then you need to know much better what they can sound like and look like. And indeed in the v r stuff it’s often about trying to get some handle on *all* the ways they appear even. (Just paused to make a note on making the game *The Library of Bitsy*.)

- How is this research creation

> For the player… well I continue to like the idea that the game itself (and this series and many of my things) are a kind of vehicle for research by the player at a more controlled level. You play this game and you are, yourself, investigating the nature of shadows in Unity, encouraged to think about and focus on them. Ha, it used to be about being “in on the joke” for my game and now it’s like “co-investigator” which is… I mean it’s good but it’s also quite depressing.

- In on the research

> Should I, at some point, try to make a successful game. Nah.

- That's a pretty funny ending.

### Commits

I worry there's a chance that there's just... too much shit??? Like how am I going to make sense of all of this and cram it into a presentation format? I think I should probably "just read" the commits right now and then return to the question of how to manage the presentation structure.

Hoo boy there's a lot there. It's much more direct and clear than the journal. Hilariously I think way LESS material here that I would consider using? But I do like the clarity and there are beats in there worth remembering?

## Wednesday, 3 April 2024

Okay well now that we've at least read through the basic thing, what would a talk about this project and MDM and design and prototyping and reflective practice and materiality be like?

> In Praise of Shadows: Chasing Reflections, Prototypes, and Other Traces of Design

That's the title. Breaking it down...

- **Reflections** means
  - The practice: The Reflective Practitioner most fundamentally, which especially (for me) means reflective conversations with the materials, stop and think, contradictions
  - The documentation: Journaling, Commits, whys, granularity
- **Prototypes** means
  - The practice: Making prototypes - trying things out, the idea of a (research-creation/reflective practice) game as a constantly unfolding prototype (unlike architecture where I guess a ton of the reflective practice is in the planning, with digital tools and prototypes we're able to build and think and undo and so on "for real")
  - The documentation: Git, the prototypes themselves, grand reveal - not "just words" and not "just pictures". How many words is the running prototype worth? What about when there's a time-sliced history of work? The connections between words and action.
- **And Other Traces of Design** means
  - The practice: What else is there?
    - I guess the idea of the Code Itself is important here;
    - the older versions of blender files;
    - changes in texts and settings that aren't always visible in the prototype?
    - Specialist documents (curation lists, todos, ...)
    - Per-commit screenshots?
    - The broader idea that DESIGN ITSELF is visible not just in a design document, the *keep everything* concept
  - The documentation:
    - Well as above I suppose mostly? But looking at other locations in Git/GitHub, its affordances and emphases
    - GitHub visualization tools
    - Enrique visualization tools -> QDA software

I mean, that's basically a fucking talk. It currently does not sound fun or funny.

What is funny?

- Swearing
- Shadow acne
- Glitched-out water
- Unwanted reflections on the sea
- Bad things happening to me

What is sexy and mysterious?

- The flickering area light

What is magical?

- Making discoveries in engine

How can I control it such that there are examples that are lighter, funnier, heavier, more beautiful, more awkward, more serious, and so on, throughout rather than silo-ed?

Do I want the above to be the literal structure of the talk? Like

- Intro
  - Who is me
  - What is v r 5
  - Little MDM (the team, the core idea, version control)
- Reflections
  - The reflective practitioner
  - Journals and commits
- Prototypes
  - Prototyping
  - History in action
- and Other Traces of Design
  - Other practices surface by version control and software engineering, the Overall
  - diffs, GitHub viz, Enrique viz
- Endtro
  - Research-creation and accountability
  - Making visible and preserving design and (digital) creative process

## Thursday, 3 April 2024

Let us continue. Note that you have...

SEVEN working days before flying to SLC. So I'd suggest we need to be building the slide deck of this thing by Wednesday. And by we I'm looking at me.

In characterizing it to Rilla I found myself thinking in terms of slides that would purely present documentation materials. So it would be a collection of

- Texts (quoting journal, commits, why, todo, )
- Images (of the interface, of builds, of blender, of GitHub, of VS Code, etc.)
- Animated GIFs/movies (of actual play)

Probably with headings (either visible or in my head), with the idea being that these concrete examples help me to explain the larger concepts.

### Title

- The basic characterizing of the talk content
- Materialization, Design, Prototypes, Reflection

### Introduction

- It's me, Pippin Barr. Affiliation. Basic research practice. Classic hits. Documentation Natural.
- MDM. The project, the funding, the team, the vibe, the version control (images? explanations?).
- v r 5. The latest project. An illustration point. The basic mission statement. Initial PDF image.

### Structure

- How I'm going to give the talk, back to the title
- In Praise of Shadows [the materiality and materializing of technology]
- Reflections [as in design reflection and its documentation]
- Prototypes [as in a design process and a document]
- and Other Traces [...]
- of Design [the central focus here is on understanding and preserving the design activity itself]

(These can show up sequentially as I break down what the fuck is up)

### In Praise of Shadows

- In Praise of Shadows, the book
- The inspiration point (can quote documentation materials)
- Materializing and thinking about tech (part of my history)

### Reflections

- The reflective practitioner, the book
  - Key concepts: conversation with materials, stop and think
- Being aware of this enough to document it, documenting it to be aware of it
- The process journal, the why (quotes)
- Version Control and commits as stop and thinks, provoking reflection
- Granularities of reflection

(Will this be too text heavy? No, because a journal includes images)

- Materials
  - Pull-quotes from the docs (or screenshots of the journal online?)
  - Image of commit history
  - Image of individual commit(s)

### Prototypes

- Defining a prototype, design as iterative prototyping, "the first example of something"
- Research-creation in this context as a constantly unfolding prototyping process - the ability to build, think, undo "for real"
- Version control -> the history of prototypes, a timesliced version of the real thing
- Associated with the reflective practice
- How many words is a running prototype worth? (Lots... right?)

- Materials
  - Video?
  - Live builds?
  - Screenshots between prototypes? A time lapse of the player camera over all builds? (Kind of labour intensive)

### and Other Traces

- Files really? Code, blender, specialist documents (todo, curation)
- The visibility of design everywhere, keep everything
- Other parts/affordances of GitHub/Git
  - Branches
  - Visualizations
  - Enrique visualization (-> QDA, a whole over kettle of fish)

- Materials
  - Screens of GitHub UI
  - Screens of code, comments
  - Diffs
  - Screens of Enrique's thing (I should build for v r 5 n'est-ce pas?)

### of Design

- At the end, that this is really about understanding and preserving design
- A record *of design*
- A story *of design*
- A ... etc.?

### Thanks

- Thanks

---

Okay well I guess if I just start building this tomorrow I have a chance of not going mad?

## lundi, 8 avril 2024

Just did some of a pass of getting the above structure into the keynote and I can see that it can for sure work.

*But* at the same time I've found myself wondering if I can and should run this presentation live by engaging with the project itself...

Like starting with the finish project, talking a bit about how monolithic these things feel, the absence of seams to pull them apart and consider how they were made -- and even if you have trained eye and can see some of that, you'll never really know *why*, nor will you know the *what* of all the things left by the wayside...

So few questions can be answered from the finality of things. So much less can be said.

And then I break out of it and into all the contingencies and strangenesses of the process... somehow, *somehow* staying on track enough to show things in a sequence that is moderately helpful?

Like I have my "classic" document-with-links instead of a beautiful pre-made presentation?

It would be truer to the spirit... but also more susceptible to career-ending fuckups... which... well that would be a bummer if, for instance, the internet didn't work that day and I'm just mega-fucked?

But I still want to contemplate it because I think it would make not just for a more dynamic presentation, but a more honest one... enough control to steer the ship, but enugh behind the curtains to show... well, what's there, and the FACT of being able to get there... the REALNESS of it...

So, requires thought and maybe a small consultation with Rilla.

## mercredi, 10 avril 2024

Meanwhile, in Pippin's brain, yeah, we're thinking about doing this in a more ramshackle, direct way. And the most direct way of all would be to write the talk in a markdown document, which I am trying out... now.

13:56 @ Noble

Well I've made a decent start on this now, but I'm being a little slowed by a couple of things

- Where to put an initial explanation of the totality of MDM or at the very least of the role of *version control* so that it's understandable... maybe in Reflections I suppose, which can go all the way to the commit...
- How to handle the builds element - maybe in my dreams I open Unity and I load different commits either from the command line or from something like SourceThingie... what's it called? SourceTree. Or actually there's a pretty solid representation here in VS Code so that might be enough... and it's kind of cool how embedded it is...
- Let me test how rapid or not the Unity switch is
- Okay well it's pretty reasonable. I learned that it's likely better to switch based on creating a new branch. Whatever you do if you have it open in Unity you end up "changing" files which means discarding changes before switching anything around again... it's a teeny bit cumbersome but not THAT bad...
- It's perhaps better to do it with the webgl builds... but an issue with that is I didn't *ALWAYS* remember to make those, so you could get conflicts.
- Should I be pre-creating a set of branches? The problem with that is I think they'll end up associated with the project itself... and then on the other hand there's almost something interesting there... like a way of creating a canonical set of commits for people to check out, with the commit id and perhaps a small text explaining it?
- How many separate builds/prototypes am I wanting to show?
- Downloading Enric's tool right now as a key Other Traces example... that idea of the "totality" being important... patterns...
- Will I want to have Unity open at some point? I suppose the answer is yes, but perhaps not all the time? But for sure some of the time in the Prototypes section...

So I think overall this is working pretty well. The key things I want to make sure they SEE are:

- (Reflection) Why?
- (Reflection) Quotes/images from the process journal + its scope + its connectedness to prototypes
- (Reflection) Commits as stand-alone technical reflections and their connectedness to prototypes
- (Prototypes) WebGL Prototypes as a very special history, reified design, + connections to existing documentation of that moment
- (Prototypes) In engine view (let's only do one or two here) as another way to view a prototype
- (Other Traces) To-do, Curation document
- (Other Traces) Code
- (Other Traces) GitHub visualization stuff (minor, really to lead into Ponte)
- (Other Traces) Ponte run over the repo to visualize commits in other ways, connect out to the idea of analysis (not my job?)
- (Other Traces) The constructedness of this talk in relation to v r 5 (kind of doubling back to the beginning? Or maybe only reveal this element at the end as a funny thing... the endlessness of design practice...)

Note that this is all structured right now with a mind to explaining *MDM* and not so much explaining *v r 5* -- how much do I care about that? Can they be blended, or does one need to have supremacy for it to work?

How confident am I talking about what the fuck v r 5 meant anyway?

Would it be funny to run the talk from the markdown preview inside VS Code? Getting too fucking ridiculous? Or I could at least show that I *could* do that.

But yes back to that question a bout v r 5... maybe it should be more that I convey the general idea of the project, and then I more generally point out just how much you and I can learn about that process by the documentation... so not about necessarily conveying the actual "this is what it is" but rather the "this is how it was"...

On Ponte (from Discord):

> Update on this: downloaded and built @Enric Granzotto Llagostera's Ponte because I want to include it in the talk and -- excuse my language but  -- FUCK ME it is an amazing experience to view the v r 5 repo through Ponte's latest iteration.

> As in, I was scrolling horizontally through v r 5's history at 50% zoom and it just spoke to me so much about my life over the last months, made things visible that I haven't thought about, and frankly would have brought tears to my eyes if I weren't in a café right now.

> Truly it's an incredible resource even without all the QDA exporting magic. I already knew it was great in principle, but it has been very special to encounter it in this very particular use case of needing what it does, wanting to talk about it, and finding just how much it delivers.

> Bravo, Enric.

> (One funny thing: I sure don't work on the weekend. So visible in the timeline.)

## jeudi, 11 avril 2024

Today didn't work out too well in terms of being able to look at the talk, but I've spent at least 15-20 minutes just now going over it.

Overall I think it's pretty clear that the core story is of MDM, with v r 5 being more in support, and I think that's fine - MDM is the more important story to tell to the world really? And v r 5 is a nice background/backing to that because it's well documented and looks kind of intelligible to a broad audience.

The big tasks ahead seem to be:

- Just filling out the actual sections, and particularly identifying the key beats of things like the journal, whys, commits, that can be quoted and then can also lead to key builds
- Figuring out how to curate the build stuff so that I can operate it smoothly without getting into issues of making things load etc.? The branch-loading of commits thing seems to work the best because it's fairly easy to get back to the main branch (needed for seeing the full commit history), and because I guess I can name the branches helpfully? OR is it best that I do that live because otherwise it just looks like I've pre-baked everything
- And the continuing relationship of doing live version control stuff while Unity is open being kind of annoying... but I should test whether anything bad happens if I just ignore Unity in favour of the webgl builds? (And do I want to stick to the webgl builds or use Unity after all? How bad are the delays, really? I should time them?)
- Polish
- Gaining some sense of scale and time - how long does it take to give a talk like this? It's become something more significant than I've really done in the past with document-based presenting because of all the linking and other stuff

I think with a good mindset I could get a lot done in an hour or two? Just got to find the hour or two.

I like the idea that there are multiple versions of the talk that can be given from this material - the 30 minute one, the 60 minute one, etc.

So tasks:

- Time how long it takes to create a new commit-branch, switch to Unity, let it do its updating, and run the game in that state
- Time how long the same thing takes to WebGL it (while taking note of how janky or not it looks to see Unity struggling away in the background?)
- OR only open Unity at the end of that sequence - so it's just builds, and then it's "designer-space" for a couple of the examples...
- Choose the key examples for whys, journal, commits, other traces - we can have too many and just show fewer if need be
- Build out the rest of the basic texts

## vendredi, 12 avril 2024

Making pretty decent headway into this. I'm all the way "through" the prototypes in terms of the webgl builds. I've painstakingly (it wasn't that hard) duplicated the webgl folder for a series of builds so I can just magically click-to-show them as no big deal.

Major tasks remaining (quite a fucking few):

- Put in some images to break things up, it's hard on the eyes right now I think
- ~~Choose perhaps two (perhaps only look at one) commits that I will venture to check out *during the talk* in order to demonstrate the body snatcher concept~~
- Build out the "other traces" section - mostly about a holistic view of the pieces of a project that aren't mostly texts explicitly there for reflection, aren't narrated in the same way... really just want individual examples of these
- Followed by GitHub viz
- Followed by Ponte viz
- Followed by some kind of incredible ending

## lundi, 15 avril 2024

I'm going to do a "run through" on the talk now and I'll take notes here as needed as I notice things. I'll have a timer going but I'm not imagining this will work as a timed version. But that said I'll be shooting for 45 minutes or so because that'll meet both sessions (Utah is 1h30 so I can be more relaxed and go over, Texas in 1h straight up and I want to leave time for conversation).

Notes:

- It took me 35 minutes to actually get to COMMITS and that is almost certainly way too long, I think we'd hope to cut that by at least 10-15 minutes... which is huuuuge..
- OR I just need to rethink how I talk about the commits, not as the be-all-end-all but kind of the key "innovation" but which needed all this context to make sense
- Partly I'm just "taking it easy" in terms of how I'm presenting this (which is good), but it's also... there's just a lot of stuff going on... and I think too that I can remember with the journal especially that there's this chance to revisit the journal via the builds/commits later on rather than think I have to say it all there...
- I think I can and probably should skate the surface a little bit more than I am, in essence.
- 55 minutes to get to the end of Prototypes
- Will I realistically have time to show the other stuff?
- I think I seem to need some slightly different pacing to think through here
- 1:02:35 by the end, which is actually really not bad and would see me through either of the two, so I don't necessarily need to be **radical** in hewing it down, but I think if I can lose 10-15 minutes it would be more welcome of questions and discussion
- I think in giving it this first run-through I noticed:
  - How little it ends up being about shadows and understanding shadows in Unity
  - How it doesn't have a very coherent story of the making of v r 5, how there's spotlighting of specific beats, but that you don't really get a sense of the arc, but rather you get a sense that there is documentation of an arc you don't see
  - How text-heavy things are as it stands (well, it is a text heavy process, but do I maybe need to think that through?)
- The biggest question for me in this exactly moment is... do I need to think about this a little more and even rewrite/remake something at a structural level, or do I declare it as "fine" and move on?
- I do think it does a good job of giving me a platform to explain and demonstrate the elements of MDM and to make a case for their important, so that's kind of the base level taken care of
- But I think it would be neat, too, if there was more of a structured sense of a shape to all this?
- Unclear I'll end up having time to do the Ponte bit at the end?
- I really like the beat of "well, I made it, but that's just the short story" ... that's a good thing
- And I like making that repeated point of: the final thing is not the story, it obscures what really happens and obscures the nature of design essentially
- I think, again, the key is: this would work and I think it is a valuable story of MDM with v r 5 playing a kind of background role... but it's tempting to want it to be more of a dramatic arc that it is currently...
- But I can see how that could eat up a LOT of time
- Hm, fuck, this is difficult to think through. Tomorrow me might have to take a look.

### A scary note I may not deal with

- Just to note it down, not necessarily to say I should do it: what if I marked out three specific commits (one a journal entry) and showed the whole thing based around that specific commit(s) (how many would I really need?)
- That would be potentially really neat because it would allow for more of an anchoring in the timescale of the project rather than treating commits as illustrative of general ideas (and I could keep those other illustrative commits/journal entries anyway to kind of show of as needed?)
- The risk is that this is secretly a lot of work and maybe too major a change.. but the benefit might be that I'm able to show all the pieces kind of working together? (Do I want to leave the "why" to the end instead of having pride of place? It's not quite as juicy as I would like it to be)
- What would the beats be in that story?
  - The very beginning (maybe a journal entry?) where the whole thing is just notes from a notebook, a build of a cube, and so on...
  - Grass(?) doesn't tell much of a story of shadows though
  - First Dark Room
  - Disappointment
  - Prototyping multiple chambers...
- I mean the problem you can already see is that there *aren't* a small number of representative beats in this story so ... I mean the point to some extent is that a design process like this ISN'T a neat story so you're not going to be able to characterize it in just a couple of moves
- So to some extent there's no way to do it?
- Unless I say I'm more trying to recover KEY MOMENTS where something really significant happened?
  - Grass and realism
  - First dark room
  - Disappointment with the Zium room
  - ... and, etc.
- That could conceivably serve to intertwine the story of the documentation more strongly with the story of the actual game?

### Uh, dude, you should mention your book

- Yup, I should. I will.

### Things to do

- Think about the dramatic arc, is there a version where the bulk of the talk dives into N specific commits, their journal entry, their commit-cluster, their build, their editor view, ...?
- Think about dialling back the intro - this may be more of a note-to-self to just move it along there a bit more, rather than an edit
- Include your book because you wrote a book and it's very relevant when you get to just after Schön? Or it could be at the end as a sort of proof of concept... like, yeah, I wrote a book because of this/could write a book because of this...

## mardi, 16 avril 2024

Alright well after talking it through with Rilla, it pretty obvious that my heart-brain or brain-heart or breart or heain or... you know, that part of the anatomy, want and needs me to refactor this talk so that it has more of a narrative structuring of how MDM works. Illustrating things through the Art of Storytelling instead of the formalisms or technique.

So I need to pick, let's say... 3-5 moments that are illustrative of "something" and then

- Identify the key journal entry(ies)
- Identify the cluster of relevant commits
- Identify a build (or builds) to demonstrate the reality
- Maybe be ready to branch to each build in the Malkovich mode? Or maybe save that to the end for just one of them. (Yeah the latter, gets too confusing to make that point more than once. It could even be an "Other Traces" really.)

So we go:

1. Introductions (including my book)
2. In praise of shadows (the inspiration, the game)
3. Beat 1
4. Beat 2
5. Beat 3
6. Beat 4?
7. Beat 5?
8. Other traces of design
9. Take homes
10. Thankses

So what are the beats?

### Very early

- Pleasingly *simple* here because it's just setup, not too much detail, but remarkable to be able to see the project before it was anything
- <https://github.com/pippinbarr/v-r-5/commit/24d9d5cb414cfa003800e3f5627e28ba30afc181>
- Journal: Started a Unity project
- Technical set-up, mega-early observations
- Build: [playable build](./builds/9253994/)

### The island

- Multiple commits around things like
  - First build with the island
  - Journal: The shitties and gritties of terrain
  - Downsampling
  - Resizing
  - Texturing
  - Restarting the island
  - Point filter
  - Grass
  - Better grass
  - Bump textures and bad self shadowing
- "Am I... almost at the shadows?" - <https://github.com/pippinbarr/v-r-5/commit/8d555c196dc769e75ca8e9637d6ceba086768f08#:~:text=%2D%20Am%20I...%20almost%20at%20the%20shadows%3F>
- There are multiple journal entries here too, I think the way to really go here is to link to journals and commits with text highlights, and then also to have builds of... most? Some? Depends on the webgl status...
- Definitely a really generative topic, captured by realism and "good graphics" and so on...

### Buildings and shadow acne

- It's almost comical how many of these there are!

### Disappointing/abortive starts ?

- Spotlight room
- Zium room

### Traction

- First pass of making a ton of rooms (in situ)
- Second pass of making a ton of rooms (on the plane)
- Then eventually positioning them

### Sculptures

### Horticulture?

### The talk?

---

So that would be

- In the beginning (simple introduction to the idea of seeing all these things)
- Landscaping (lots of learning, fighting, obsession with the "wrong thing"?)
- Architecture (so many restarts, more obsession with the "wrong" things? shadows as an enemy, ...)
- Stages of grief and joy (the early triumph->disappointment->traction sequence that takes up most of development?)
- Decor (horticultural pursuits, sculptures, maps)

That's five and I think they're a good five. I guess I need to "make it so" now?

## mardi, 16 mai 2024

Runthrough notes.

- 6:21 to "The v r series"
- 12:12 to "The MDM and design reflection"
- (I think this is a nice pace so far.)
- 23:00 to "In the beginning"
- (It still feels like a nice place, clear, the things I'm saying are helpful...)
- (So if I can keep the "story time" down to like 20 minutes we're pretty golden. Can I? Probably not. Or maybe I can.)
- (Let's find out)
- 28:52 to "Landscaping"
- ...42:16 to "Architecture"
- (Which is to say: there's no way I can plausibly do more than three and so I simply won't. And also it is to say that I can and should probably go a bit faster through this stuff, I don't need necessarily to dwell as much as I have been)
- (But the good thing is that I think I only need to really address the architectural elements and I'm done for this heavy lifting)
- (And then I'll "just" include a bunch of other stuff as more of a "grab bag" that I can talk about or point to for further discussion as needed.)
- (Plus this Utah version of the talk can run a bit longer, like to 60:00 say, without it being any kind of problem, so I've got a little bit of room to work some kinks out I suppose.)

## mercredi, 17 avril 2024

This is just to say, I checked the ice-box, and the fucking plums were gone? Seriously???

I went for a long walk. 12,000 steps today in total.

I thought about the talk, having given it a read on the plane to SLC. I felt worried by it then, in part because I was just feeling tired and overwhelmed by travel, chair responsibilities, leaving family in Montreal, and so on.

But it's true that I think it can still be improved. And one of my notes to myself, a refrain, was about Geraint's point about how funny formalism is, how funny formalists are.

And I like that puncturing (of myself) that exists in the documentation (compare to Judd). There's this desire to be professional and to make something very perfect and austere and conceptual, but then the really is all about mowing grass inside buildings and being unable to figure out why the shadows cast the wrong way, and so on. And it turns out that the installations themselves are kind of trivial and that what mattered or what was so hard was the *place*.

And it's funny that was hard, but it's also a really true note about how a project like this works. What you think or thought was the most important thing isn't really... so there's a sense in which I was overcaptured by beauty and perfection, but also that those things were deemed necessary in my heart for things to work.

Can we imagine the island with seamy buildings on a monotextured terrain? We cannot. Or we can, but we could not be taken seriously.

And so there's something really funny about this decent through layers of godliness, architecture, all the way down to being a humble lighting technician, ... so that we can look at shadows on a wall (paging Dr. Plato etc.)

And that's kind of the story that the island and the buildings can tell... the huge distance from professional perfection that exists most of the time, the comedy of that, but also the necessity of it, ... and then in the end the comedy of that kind of enterprise anyway.

But also the value of *learning* (texturing the island), ...

The talk cannot, in the end, lay down the law about some specific thing about design - it's meant to be about how MDM lets you into the inside, and that from that you can extract stories and knowledge and evidence about real, messy, reflective design practice. And the luxury and necessity of doing that.

Who am I trying to convince here? Who are they? Do they want to analyse games and game design? Do they have their own digital creative practice?

A through-line is really... I thought the game was going to be all about taxonomizing shadows; but in the end that was the easiest thing. The hard part was pouring the concrete, landscaping the island, mowing the grass, the service roles.

The Why?s as a north star for this, to keep you going.

The architecture story is more difficult because it feels deflating? Like I kept having all these big plans and efficiency dreams... but in the end I made exactly the thing I planned to make very early on... and I don't know how much I truly learned doing it?

Is it a story of the landscape again, but gone wrong?

There were some beats that really made me believe... should I be looking at those?

- The vase gleaming in the dark windowed room
- The moving lights
- The grass room

Am I better off telling an abbreviated "horror stories" about shadow acne and seams and so on? And then also the You Gotta Believe moments?

## jeudi, 18 avril 2024

It's the final run-through (to the tune of Final Countdown by Europe)

- 22:43 to In the beginning
  - It's kind of a "relaxed" pace, but I think I don't hate that? I think it will work for today anyway, and I may need to think of tightening up for Texas (or just skipping a theme?)
- 29:36 to Landscaping (~7m)
  - I think that one works nicely
- 42:09 to My Architect(ure) (~12.5m)
  - This went as well as always but it sure takes time
- 52:17 to Gleaming (~10m)
  - This felt good which is *great news*, though clearly we're still in a tough spot relative to time (neat to eat into the relaxed beginning is one answer)
- 1:02:00 to Other Traces (~10m)
  - I think that was pretty okay
- 1:05 to end (~3m)

As I gave that ending, I'm going to drop the "here are the themes" thing. It feels too much like belabouring the point.
