# Air Traffic Control System written in ADA

## This Ada code is a simulation of an air traffic control system. It uses Ada's concurrency features to model the interactions between airplanes and an air traffic controller.

### Copilot Demo Walkthrough

This demo shows how Copilot can be used to convert Ada code to C#, generate unit tests, document unit tests, and generate a commit message.

Demo 1
----------------------------
Open file **AirTrafficControlSystemSimulation.adb**

Copilot: type **/Explain**

Speaker
This Ada code is a simulation of an air traffic control system. It uses Ada's concurrency features to model the interactions between airplanes and an air traffic controller.

Next, let's ask Copilot to convert this to C#.

Demo 2
----------------------------
Copilot: type **Please convert this to C#**

Speaker
Converting Ada to C# involves changing the syntax and semantics to match C#. Ada's tasking model doesn't have a direct equivalent in C#, but it can be emulated using threads and synchronization primitives.

Speaker
Copy to clipboard. Cntl-N, to create anew file. Cntrl-V, to paste in code. Cntl-S, to save to AirTrafficControlSystemSimulation.cs

You can create a new file in Visual Studio Code by clicking on the "New File" icon in the Explorer view or by using the shortcut Ctrl+N. Then, you can paste the above code into the new file. Next, save the file by using the shortcut Ctrl+S.

Demo 3
----------------------------
Speaker
This looks great, thank you Copilot!

Next I want to create unit tests.  I can hightlight one object and easily create a single unit test.

Using Copilot, you can type "write a unit test please" or use the shortcut key /tests.

Highlight "public void AssignAircraft(int id)"

Copilot Chat Window
Please write a unit test for this

Speaker
This will generate a unit test in the Copilot chat window. I can review this, copy it, create a new file, then simply paste in the code.

Another option is to generate all the unit tests for this file. First I'll highlight all the code and then use Copilots inline chat feature to write all my unit tests, let's go ahead and do that now.

Highlight all the lines, then use Copilots shortcut Ctrl+I.
 
Copilot will prompt me right inline and now I can use the shortcut key /tests or simply type "write a unit test for this"

Copilot
/tests, press <tab>, press <enter>

Speaker
To write unit tests for this method, we would need to mock the Runway object and verify that its AssignAircraft and ClearedRunway methods are called with the correct arguments.

Simply click "Create" to save to AirTrafficControlSystemSimulationTests.cs

Demo 3
----------------------------
Speaker
Next, let's go ahead and document all our unit tests.  This is easily done using Copilot.

There are two options to do this, one is to use the shortcut command /docs to add header comments to classes and object or ask Copilot to document everything.

Copilot
create comments for all my classes, press <enter>

Speaker
Scroll down to show comments above each class.

Demo 4

Speaker
Lastly, let's use Copilot to generate a good commit message before checking in my code.
Click button "Generate commit message using Copilot".
Click button "Commit and Push".
