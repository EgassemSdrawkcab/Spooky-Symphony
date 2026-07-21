using UnityEngine;
using UnityEngine.SceneManagement; //we're managing scenes, so... we need this to give us those options!

public class ClickToChangeScene : MonoBehaviour
{


    //Update() is called every frame - basically it's always checking to see if this "function"(AKA this bit of code) 
    // has been called yet.
    // Because the "void" is "public," you can see and edit it in the Inspector tab of Unity properS!
    public void LoadScene(string levelName)
    {
        //Full EXACT name of next level goes in levelName. Capitalization and spacing matter!
        //this is the line that actually kicks you to the next scene!
        SceneManager.LoadScene(levelName, LoadSceneMode.Single);
    }

    //Steps for setting it up in Unity:
    /*
    1. Make a Canvas, and add a TextMeshPro Button (For clarity, I'll call this the buzzer)
    
    2. Add this code to the buzzer in the Inspector (by dragging it in from the Project window, 
    or by using the Add Component button on the buzzer)

    3. Under the "Button" part of the buzzer's Inspector, click the plus sign below "On Click ()"

    4. Drag the script you put onto the buzzer into the open On Click() section you just made

    5. Where it says "No Function" (next to "Runtime Only"), select ClickToChangeScene > LoadScene(string) and
    then type out the exact name of the level you want the buzzer to send you to. This means the 
    function above only plays when you click the buzzer!

    [if someone has already done steps 7 & 6 on this project, no need to do it again]

    6. Now to make Unity realize what levels we need in our game. Waaaay at the top left of the screen, click 
    Files > Build Profiles, then Open Scene List.

    7. Start dragging in scenes (the levels) from the Project tab into this Scene List tab 
    (and make sure they're checked on the left!)

    Have fun with your buzzers! -Brynn Fields
    */
    
}
