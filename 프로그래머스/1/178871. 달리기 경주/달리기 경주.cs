using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] players, string[] callings) {        
        return UpdatePlayers(players, callings);
    }
    
    static string[] UpdatePlayers(string[] players, string[] callings)
    {
        Dictionary<string, int> playerIndexMap = new Dictionary<string, int>();
        for (int i = 0; i < players.Length; i++)
        {
            playerIndexMap[players[i]] = i;
        }

        foreach (string call in callings)
        {
            int index = playerIndexMap[call];

            if (index > 0)
            {
                string firstStr = players[index - 1];
                string changeStr = players[index];

                players[index - 1] = changeStr;
                players[index] = firstStr;

                playerIndexMap[firstStr] = index;
                playerIndexMap[changeStr] = index - 1;
            }
        }

        return players;
    }
}