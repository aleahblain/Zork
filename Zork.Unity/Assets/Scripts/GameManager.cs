using Zork;
using UnityEngine;
using Newtonsoft.Json;
using TMPro;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    private UnityInputService InputService;

    [SerializeField]
    private UnityOutputService OutputService;

    [SerializeField]
    private TextMeshProUGUI CurrentLocationText;

    [SerializeField]
    private TextMeshProUGUI CurrentMovesText;

    [SerializeField]
    private TextMeshProUGUI CurrentScoreText;

    private Game _game;                                                                                                                                                                     

    void Start()
    {
        TextAsset gameJsonAsset = Resources.Load<TextAsset>("Zork");
        _game = JsonConvert.DeserializeObject<Game>(gameJsonAsset.text);
        _game.Player.LocationChanged += (sender, newLocation) => CurrentLocationText.text = newLocation.ToString();
        _game.Player.MovesChanged += (sender, newMoves) => CurrentMovesText.text = newMoves.ToString();
        _game.Player.ScoreChanged += (sender, newScore) => CurrentScoreText.text = newScore.ToString();
        _game.Start(InputService, OutputService);
    }

}
