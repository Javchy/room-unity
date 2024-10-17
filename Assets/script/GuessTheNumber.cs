using UnityEngine;
using TMPro;
public class GuessTheNumber : MonoBehaviour
{
    public TMP_Text messageText;
    public TMP_InputField numberinput;

    private int randomNumber;

    private void Start()
    {
        ResetGame();
        
    }

    public void Guess()
    {
        if (string.IsNullOrWhiteSpace(numberinput.text) == true)
        {
            messageText.text = "not a number, goofy ahhh.";
            numberinput.text = "";
            return;
        }
        if (int.TryParse(numberinput.text, out int playernumber))
        {
            if (playernumber == randomNumber)
            {
                messageText.text = "GG goofball";
            }
            else if (playernumber > randomNumber)
            {
                messageText.text = "lower";
            }
            else if (playernumber < randomNumber)
            {
                messageText.text = "higher";
            }
            else
            {
                messageText.text = "not the good one you smell really bad u should kys";
                numberinput.text = "";
                
            }
            numberinput.text = "";
        }



    }

    public void ResetGame()
    {
        randomNumber = Random.Range(1, 100 + 1);
        Debug.Log("generated number: " + randomNumber);
        messageText.text = "guess the number...";
    }

}