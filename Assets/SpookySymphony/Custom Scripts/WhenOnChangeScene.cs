using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WhenOnChangeScene : MonoBehaviour
{
    [SerializeField] public string SceneToGo = "Scene to go to when this panel appears. Be EXACT in the naming!";
    
    
    public void Update()
    {
        //Full EXACT name of next level goes in levelName. Capitalization and spacing matter!
        //this is the line that actually kicks you to the next scene!
        SceneManager.LoadScene(SceneToGo, LoadSceneMode.Single);
    }
}
