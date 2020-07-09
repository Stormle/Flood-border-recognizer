## Install
```bash
run Flood border recognizer.exe
```
Windows only.

![Border recognizer demo](demo/demo.gif)

#### What does this program do?

This program searches for single color borders from a picture by using a weighed flood method. It diagonally rakes through pixels of the photo saving roughly 16x the time compared to brute force with the current offset settings. When the program encounters a wanted color pixel, it starts flooding to a direction and self corrects while avoiding u-turns at all cost. There also are dynamic positive result qualification adjustments in place in case the border has experienced compression or blending. Since it's dynamic, it also helps the program to stay on the correct route when encountering close but not quite kind of colors. (Demonstrated by the blue shirt in the demo gif)

#### Why this program?

The engine is a part of a really old project that I never intended to open source. Hence the weird dual color search feature and no particular real life application of this program. It's more of a Proof of Concept. The point of this repository is for you to maybe use the code or take some inspiration for your own image processing endeavours. The code was never intended to see the light of day so have fun reading through that mess.

#### Using the border recognizer function:
```bash
findobject(r1, g1, b1, r2, g2, b2, bitmap)
```
The result will be displayed in Picturebox1 and at the end of the function you will be returned two arrays of found pixels.