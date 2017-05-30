# Dizzy_Unity5-4-5
This is the version of [Dizzy](https://github.com/BerniceChua/Dizzy) made with an older version (Unity 5.4.5), because I found out from a forum post that using `Input.location.Start()`, which is needed for Android's Compass to work, will crash the game, and it's a known issue.  <https://forum.unity3d.com/threads/input-location-start-causes-android-build-to-crash-directly-after-startup.443920/>

Unfortunately, using an older version of Unity did not solve the problem.  Instead, I just used this to try out the [different methods/functions](http://answers.unity3d.com/questions/464042/detect-android-device-movment.html) to see which one does what I need to access the Android sensors that gather [inputs](https://docs.unity3d.com/ScriptReference/Input.html) for [movement](http://answers.unity3d.com/questions/464042/detect-android-device-movment.html), then I will use what I've learned back to the [original version of this project](https://github.com/BerniceChua/Dizzy):
- <https://docs.unity3d.com/ScriptReference/Gyroscope.html>
- <https://docs.unity3d.com/ScriptReference/Input-acceleration.html>

### Technologies Used
- Unity3D
- C#
- git
- GitHub

### Contributor List (in alphabetical order) - Who Made This?
- Bernice Anne W. Chua (game developer)
  - [GitHub](https://github.com/BerniceChua)
  - [LinkedIn](https://linkedin.com/in/bernicechua415)
  - [Twitter](https://twitter.com/ChuaBernice)
- Niko Korolog (musician and idea-originator)
  - [LinkedIn](https://www.linkedin.com/in/niko-korolog-64699834/)
  - [Twitter](https://twitter.com/nikokorolog)
