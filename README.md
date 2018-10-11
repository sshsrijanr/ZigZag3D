# ZigZag3D
[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://www.github.com/srijan-ramavat/ZigZag3D)
## **Step 1:**
Create a Scene if not there and place it in scene folder<br>
Create a 
- GameObject-3D-cube
- GameObject-3D-sphere

Set cube's Scale as 
```
x=10 y=1 z=10
```
Create a Folder in Assets as Material then inside of it create two materials <br>
- Material for Cube
    - Update Color in Albedo in Inspector
- Material for Sphere 
    - Update Color in Albedo in Inspector
## **Step 2:**
Drag and drop the Material on the respective GameObject<br>
On the GameObject Sphere add `Physics-Rigidbody` in Inspector<br>
Now in the Component in `Constraints` <br>
Freeze
position in y   
rotation in x, y, z  
Set position of sphere as 
```
x=0 y=1 z=0
```
Now in the Inspector of go to Add Component and add  New Script to it. Name it as `ballController.cs` and <br>
#### Copy the code from the above ballController C# script in Repo and Add to this file
## **Step 3:**
Create A folder in Assets as Physics Material Open it and Inside of it create a `PhysicsMaterial` and Name it as Friction<br>
Set the Static and Dynamic Friction in Inspector of that element as Zero
#### Now drag and drop this element in both platform (Cube) and Ball(Sphere)

Now For the Camera to Follow the Ball At the click on the GameObject MainCamera and at Inspector add component Script `cameraFollow.cs`
#### Copy the code from the above cameraFollow C# script in Repo and Add to this file
## **Step 4:**
Now Add
<img src="img.png"></img>
