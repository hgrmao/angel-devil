using UnityEngine;
using TMPro;
using System.Collections;

public class MessageDisplay : MonoBehaviour
{
    public TextMeshProUGUI messageText; // 表示に使うTextMeshProUGUI

    /// <summary>
    /// ボタンから呼び出す汎用メソッド
    /// </summary>
    /// <param name="message">表示したいメッセージ</param>
    public void ShowMessage(string message)
    {
        messageText.text = message;
        messageText.gameObject.SetActive(true); // 念のためON
    }
}
