
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    //start
    public static System.Array _teamA = GameObject.FindGameObjectsWithTag("teamA");//0-4
    public static System.Array _teamB = GameObject.FindGameObjectsWithTag("teamB");//5-9

    public static Dictionary<string, Player> players = new Dictionary<string, Player>();


    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one GameManager in scene.");
        }
        else
        {
            instance = this;
        }
    }

    public static void AddPlayer(string _playerID, Player _player)// playerA2 is in team A with num 2
    {
        players.Add(_playerID, _player);
    }

    public static void AddPlayers()// player A2 is in team A with num 2
    {
        Player Player;
        for (int i=0; i<_teamA.Length;i++)
        {
            Player = new Player();
            AddPlayer("PlayerA" + i, Player);
        }

        for (int j = 0; j < _teamB.Length; j++)
        {
            Player = new Player();
            AddPlayer("PlayerB" + j, Player);
        }

    }
    public static Player GetPlayer(string _playerID)
    {
        return players[_playerID];
    }

}


