using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextActive : MonoBehaviour
{
    public string SceneName;

    private string selected1 = null;
    private string selected2 = null;
    private string selected3 = null;

    // 各ボタンから呼ばれるメソッド
    public void SelectFromBox(int boxNumber, string value)
    {
        switch (boxNumber)
        {
            case 1:
                selected1 = value;
                break;
            case 2:
                selected2 = value;
                break;
            case 3:
                selected3 = value;
                break;
        }

        CheckSelections();
    }

    // 3つすべて選ばれたかチェック
    private void CheckSelections()
    {
        if (selected1 != null && selected2 != null && selected3 != null)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
