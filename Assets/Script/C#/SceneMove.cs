using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMove : MonoBehaviour
{
    public string SceneName; // インスペクターからシーン名を入れる
    private bool firstPush = false; // 複数回押しても１度だけの処理にするように

     public void PressStart()
     {
          Debug.Log("Press Start!");
          if (!firstPush)
          {
              Debug.Log("Go Next Scene!");
              SceneManager.LoadScene(SceneName);
              firstPush = true;
          }
     }
}
