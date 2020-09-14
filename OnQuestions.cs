
using UnityEngine;

using UnityEngine.UI;

public class OnQuestions : MonoBehaviour
{
    
    public int option;
    public int correctoption;
    public GameObject b1; public GameObject b2; public GameObject b3;
    public GameObject correct;
    public GameObject question;
    public Text TectBox;
   
    
    public void OnButtonClick1()
    {
        option = 1;
    }
    public void OnButtonClick2()
    {
        option = 2;
    }
    public void OnButtonClick3()
    {
        option = 3;
    }
    private void Update()
    {
        if (option != 0)
        {
            if (correctoption == option)
            {
                correct.SetActive(true);
                b1.SetActive(false);
                b2.SetActive(false);
                b3.SetActive(false);
                question.SetActive(false);
                TectBox.GetComponent<Text>().text = "Your answer was correct";
            }
            else if (correctoption != option )
            {
                correct.SetActive(true);
                b1.SetActive(false);
                b2.SetActive(false);
                b3.SetActive(false);
                question.SetActive(false);
                TectBox.GetComponent<Text>().text = "Your answer was incorrect";

            }
        }
    }
}
