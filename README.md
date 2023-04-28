# SimpleTimer
This is a simple timer source code that does not rely on Unity's coroutine processing.
## Overview
Simple source code that works inside the update function.<br>
It is divided into for inheritance, for overriding, and static that can be used from anywhere in the project.<br>
A specific example of use is summarized in "SampleScript.cs".<br>
## Class and function
### Timer
SetTimer(float time) -> Set the timer time.<br>
Count() -> Count the timer based on the set time. Returns a bool value when the timer expires.<br>
Reset() -> Reset the timer.
### WrapTimer
It is the same as the timer class, but it can be overridden.
### StaticTimer
It's just like the Timer class, but it can be called from anywhere in the project. Place it in any folder and use it.
## Version
Unity 2021.3.8f1
