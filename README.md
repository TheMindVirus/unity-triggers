# unity-triggers
Unity 2019 Animation Triggers for Tabletop Simulator Modding v3.0

![playable](https://github.com/TheMindVirus/unity-triggers/blob/blender/playable.gif)

## Noteworthy
A lot of bugfixing has gone into making this project work properly in Tabletop Simulator.
To summarise the most fatal issues:
 - The Animation and Animator Views (yes they are different things) are both missing by default
 - Animation States cannot be played simultaneously, instead they must be played through a "Blend Tree"
 - The Blend Tree is set to 1D mode and random blend values which are incorrect defaults (should be 2D Freeform)

There are too many other issues with importing from Blender to Unity to note, but here are just some of them:
 - Animator layers view doesn't show animations for subobjects only the parent
 - Animations imported incorrectly or not at all
 - Only the first animation is selected as a default instead of all the animations present in the scene
 - New layers are not automatically created on import bar the first one
 - New layers have animation1 duplicated instead of each object's animation respectively
 - Objects have the wrong animations applied to them from other objects
 - Weight for new layers is set to 0 by default bar the first one which is set to 1
 - Imported animations are read-only by default
 - Preview/Select buttons in animation view broken when the parent object is not selected in play mode first
 - Loop button is missing or greyed out in valid contexts
 - Weight for first layer is locked at 1 regardless of if it's the built-in base layer or not
 - Labels missing from animation blocks randomly
 - Duplicate animation blocks with objects inheriting incorrect animations from other objects
 - Animation view forgets preference of dopesheet or curves on deletion of object
 - Extra unwanted key-frame sub-curves added which just take up space and make it harder to smooth
 - Various other sub-object rotation scaling and positioning issues
