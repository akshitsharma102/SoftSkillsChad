using UnityEngine.UI;
using UnityEngine;

public class EnableMainUi : MonoBehaviour
{
    public Canvas canvas1;
    public Canvas canvas2;
    
    public void onClickableEventEnter()
    {
        canvas1.gameObject.SetActive(false);
        canvas2.gameObject.SetActive(true);
    }
}
