using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    private int state; // -1: 白, 1: 黒, 0: 空
    private int x, y;
    private ReversiController controller;
    private Button button;

    public void SetPosition(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void SetController(ReversiController controller)
    {
        this.controller = controller;
    }

    public void SetState(int state)
    {
        this.state = state;

        // UIを更新
        var img = GetComponent<Image>();
        if (state == 1)
            img.color = Color.black;
        else if (state == -1)
            img.color = Color.white;
        else
            img.color = Color.green; // 空マスの色
    }

    public int GetState()
    {
        return state;
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        controller.OnCellClicked(x, y);
    }
}
