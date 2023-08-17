# Process journal

## Initial notebook sketches -- Tuesday, 15 August 2023

(This is a retroactive commit of the (iPad) notebook sketching I did in starting to think about the game.)

[Early sketching and thinking on 15 August 2023](./pdfs/2023-08-15.pdf)

## Started a Unity project -- Thursday, 17 August 2023

Well, one of the big things is just opening Unity and I can at least claim to have done that over today. I created a Unity project in the most recent LTS version (2022.3.7f1 LTS for the record), made a cube, and built it for WebGL so that there's something to see. Then built it again with a decompression fallback because it didn't want to load. Now it loads, but I observe that there is the typical irony when you don't really plan things out: there are no shadows in that first build. Because there's only a cube and nothing for it to case a shadow on. And I guess because of the angle of the camera none of the visible faces of the cube are shadowed either. So, haha.

At any rate, the project is underway. Next step is to fire up ProBuilder and hope like hell it behaves better in this build of Unity than it did when I was trying to use it in v r $4.99.
