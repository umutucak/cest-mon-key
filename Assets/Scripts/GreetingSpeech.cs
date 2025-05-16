using UnityEngine;
using TMPro;

public class GreetingSpeech : MonoBehaviour
{
    private TMP_Text tmp;
    public GodImage godImage;
    public Announcer announcer;
    private bool doneTalking = false;
    // public TMP_Text tmp;
    private string[] dialogue = {
        "yo, my friends and I are having a dance-off\n\n (press E to continue)",
        "but i think they boogied themselves off the dance floor",
        "call me the king of the hill!",
        "maybe i'm king kong...",
        "anyway, can you find my friends? we need to decide on a winner after all",
        "winner gets a banana, and im getting hungry from all this dancing",
        "my friends like to get in all sorts of nook and cranies,you gotta search well!!",
        "press E to interact with nearby objects or monkeys",
        "press Left Click to reach out to them if they are really far"
    };

    private int dialogueCounter = 0;
    void Start()
    {
        tmp = gameObject.GetComponent<TMP_Text>();
    }
    
    public void ContinueDialogue()
    {
        if (doneTalking)
            return;

        if (dialogueCounter == dialogue.Length)
        {
            godImage.gameObject.SetActive(true);
            announcer.Play("init");
            doneTalking = true;
        }
        tmp.text = dialogue[dialogueCounter];
        if (dialogueCounter < dialogue.Length-1)
        {
            dialogueCounter++;
        }
        else
        {
            dialogueCounter++;
        }
    }
}