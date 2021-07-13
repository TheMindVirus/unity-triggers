# unity-triggers
Unity 2019 Animation Triggers for Tabletop Simulator Modding v3.0

![playable](https://github.com/TheMindVirus/unity-triggers/blob/blender/playable.gif)

## Noteworthy
A lot of bugfixing has gone into making this project work properly in Tabletop Simulator.
To summarise the most fatal issues:
 - The Animation and Animator Views (yes they are different things) are both missing by default
 - Animation States cannot be played simultaneously, instead they must be played through a "Blend Tree"
 - The Blend Tree is set to 1D mode and random blend values which are incorrect defaults (should be 2D Freeform)
 - 
There are too many other issues with importing from Blender to Unity to note, but here are just some of them:
 - missing animation view
 - missing animator layers view
 - animator layers view doesn't show animations for subobjects only the parent
 - animations imported incorrectly or not at all
 - only the first animation is selected as a default instead of all the animations present in the scene
 - new layers are not automatically created on import bar the first one
 - new layers have animation1 duplicated instead of each object's animation respectively
 - objects have the wrong animations applied to them from other objects
 - weight for new layers is set to 0 by default bar the first one which is set to 1
 - imported animations are read-only by default
 - preview/select buttons in animation view broken when the parent object is not selected in play mode first
 - loop button is missing or greyed out in valid contexts
 - weight for first layer is locked at 1 regardless of if it's the built-in base layer or not
 - labels missing from animation blocks randomly
 - duplicate animation blocks with objects inheriting incorrect animations from other objects
 - animation view forgets preference of dopesheet or curves on deletion of object
 - extra unwanted key-frame sub-curves added which just take up space and make it harder to smooth
