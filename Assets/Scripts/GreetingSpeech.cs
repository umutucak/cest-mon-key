using UnityEngine;
using TMPro;

public class GreetingSpeech : MonoBehaviour
{
    public GameObject me;
    private TMP_Text tmp;
    // public TMP_Text tmp;
    private string[] dialogue = {
        "yo, my friends and I are having a dance-off\n\n (press E to continue",
        "but i think they boogied themselves off the dance floor",
        "call me the king of the hill!",
        "maybe i'm king kong...",
        "anyway, can you find my friends? we need to decide on a winner after all",
        "winner gets a banana, and im getting hungry from all this dancing",
        "press E to interact with objects, my friends like to get in all sorts of nook and cranies, you gotta search well!!",
        "press Left Click to yell at them if they are really far"
    };

    private int dialogueCounter = 0;
    void Start()
    {
        tmp = me.GetComponent<TMP_Text>();
    }
    
    public void ContinueDialogue()
    {
        tmp.text = dialogue[dialogueCounter];
        if (dialogueCounter < dialogue.Length-1)
        {
            dialogueCounter++;
        }
    }
}