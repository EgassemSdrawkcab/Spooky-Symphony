using UnityEngine;

public class EscToQuit : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //if you press escape at any point
        {
            Application.Quit(); // quit da game (only works when exported)
        }
    }
}
