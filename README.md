# UnityUtil
A place to stick all my generic Unity code. 

### Reasoning
I've made a lot of small games and experiments. I've found myself often opening up old projects and copying utility-esque files, classes and functions.  This is an attempt to streamline that and hopefully share some code with others. 

## Files and Functions
[Lerper](https://github.com/jesterswilde/UnityUtil/blob/master/Code/Util/Lerper.cs) - A component to handle moving and rotating over time. Has static methods to dynamically add the component and remove it when it's done. 

[Detector](https://github.com/jesterswilde/UnityUtil/blob/master/Code/Physics/Detector.cs) - A component to handle triggers with box colliders.  Has IsBlocked property, OnBlock/OnUnblocked events and Unity Events depending on your preference. 

[Callback](https://github.com/jesterswilde/UnityUtil/blob/master/Code/Util/Callback.cs) - A (mostly static) component that handles invoking functions at a later time. Does Update and FixedUpdate stuff.

[Unity Extensions](https://github.com/jesterswilde/UnityUtil/blob/master/Code/Util/UnityExtensions.cs) - An eclectic collection of extension methods I find useful. 
  * **LayerMask**.Contains - Lets you know if a layer is contained inside the mask
  * **float**.Map - converts a number in a range to the same relative place in a different range (Didn't write this one)
  * **List**.AddRangeInto - Adds this list into another one. It's mostly for LINQ chaining convienence
  * **Component**.DestroyChildren - destroys all child gameobjects
  * **Transform**.HasChildren - Well, does it? 
  * **Component**.GetDirectChildrenTransforms - Gets the transforms, as a list, of the direct children only (no grandchilren or beyond)
  * **List.PickRandom** - Returns a random element from the list
  * **List.Shuffle** - Shuffles a copy of the given list
  * **List.ShuffleInPlace** - Does as it says
  * **Dictionary.GetOrDefault** - Attempts to get value stored in key. If key doesn't exist, returns default for type of value
  
