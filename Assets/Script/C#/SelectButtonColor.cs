using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectButtonColor : MonoBehaviour
{
    public Button button;
    public Button[] otherButton;
    private Color onColor = new Color(0f, 1f, 1f, 1f); 
    private Color defaultColor = new Color(1f, 1f, 1f, 1f);

    public void PressStart()
    {
        Active main = button.GetComponent<Active>();
        main.isActive = true;
        
        for(int i = 0; i < otherButton.Length; i++)
        {
            Active other = otherButton[i].GetComponent<Active>();

            if(other.isActive)
            {
                other.isActive = false;
            }
        }

        ColorChange();
    }

    public void ColorChange()
    {
        button.image.color = onColor;

        for(int j = 0; j < otherButton.Length; j++)
        {
            otherButton[j].image.color = defaultColor;
        }
    }
}
