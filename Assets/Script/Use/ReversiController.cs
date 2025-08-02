using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReversiController : MonoBehaviour
{
    public GameObject cellPrefab; // セルのPrefab
    public GridLayoutGroup grid; // 盤面のグリッド
    public int gridRows = 8; // オセロの盤面の行数
    public int gridCols = 9; // オセロの盤面の列数
    private Cell[,] board; // 盤面の状態

    private int currentPlayer = 1; // 現在のプレイヤー (1: 黒, -1: 白)
    private int blackCount = 0; // 黒の石の個数
    private int whiteCount = 0; // 白の石の個数

    void Start()
    {
        InitializeBoard();
    }

    void InitializeBoard()
    {
        board = new Cell[gridRows, gridCols];

        for (int y = 0; y < gridRows; y++)
        {
            for (int x = 0; x < gridCols; x++)
            {
                // セルを生成
                GameObject cellObj = Instantiate(cellPrefab, grid.transform);
                Cell cell = cellObj.GetComponent<Cell>();
                cell.SetPosition(x, y);
                cell.SetController(this);
                board[y, x] = cell; // 修正：行（y）と列（x）の順序を正しく設定

                // 初期配置
                if ((x == 3 && y == 3) || (x == 4 && y == 4))
                    cell.SetState(-1); // 白
                else if ((x == 3 && y == 4) || (x == 4 && y == 3))
                    cell.SetState(1); // 黒
                else
                    cell.SetState(0); // 空
            }
        }

        UpdateCounts();
    }

    public void OnCellClicked(int x, int y)
    {
        if (board[y, x].GetState() != 0 || !CanPlacePiece(x, y, currentPlayer))
            return;

        PlacePiece(x, y, currentPlayer);
        UpdateCounts();

        if (IsGameOver())
        {
            AnnounceWinner();
            return;
        }

        currentPlayer *= -1; // プレイヤー交代
    }

    bool CanPlacePiece(int x, int y, int player)
    {
        foreach (var dir in GetDirections())
        {
            if (CheckDirection(x, y, dir.x, dir.y, player))
                return true;
        }
        return false;
    }

    void PlacePiece(int x, int y, int player)
    {
        board[y, x].SetState(player);

        foreach (var dir in GetDirections())
        {
            if (CheckDirection(x, y, dir.x, dir.y, player))
                FlipPieces(x, y, dir.x, dir.y, player);
        }
    }

    void FlipPieces(int x, int y, int dx, int dy, int player)
    {
        int nx = x + dx, ny = y + dy;
        List<Cell> toFlip = new List<Cell>();

        while (IsInBounds(nx, ny) && board[ny, nx].GetState() == -player)
        {
            toFlip.Add(board[ny, nx]);
            nx += dx;
            ny += dy;
        }

        if (IsInBounds(nx, ny) && board[ny, nx].GetState() == player)
        {
            foreach (var cell in toFlip)
            {
                cell.SetState(player);
            }
        }
    }

    bool CheckDirection(int x, int y, int dx, int dy, int player)
    {
        int nx = x + dx, ny = y + dy;
        bool foundOpponent = false;

        while (IsInBounds(nx, ny) && board[ny, nx].GetState() == -player)
        {
            foundOpponent = true;
            nx += dx;
            ny += dy;
        }

        return foundOpponent && IsInBounds(nx, ny) && board[ny, nx].GetState() == player;
    }

    bool IsInBounds(int x, int y)
    {
        return x >= 0 && x < gridCols && y >= 0 && y < gridRows;
    }

    List<(int x, int y)> GetDirections()
    {
        return new List<(int x, int y)>
        {
            (-1, -1), (0, -1), (1, -1),
            (-1, 0),         (1, 0),
            (-1, 1), (0, 1), (1, 1)
        };
    }

    void UpdateCounts()
    {
        blackCount = 0;
        whiteCount = 0;

        for (int y = 0; y < gridRows; y++)
        {
            for (int x = 0; x < gridCols; x++)
            {
                if (board[y, x].GetState() == 1)
                    blackCount++;
                else if (board[y, x].GetState() == -1)
                    whiteCount++;
            }
        }
    }

    bool IsGameOver()
    {
        for (int y = 0; y < gridRows; y++)
        {
            for (int x = 0; x < gridCols; x++)
            {
                if (board[y, x].GetState() == 0 && (CanPlacePiece(x, y, 1) || CanPlacePiece(x, y, -1)))
                    return false;
            }
        }
        return true;
    }

    void AnnounceWinner()
    {
        if (blackCount > whiteCount)
        {
            Debug.Log("Black wins!");
        }
        else if (whiteCount > blackCount)
        {
            Debug.Log("White wins!");
        }
        else
        {
            Debug.Log("It's a draw!");
        }
    }
}
