using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public static class StateManager
{
    private static int scoreMult = 1;
    private static int ballVal = 1;
    private static int ballNumMult = 1;
    private static int playerScore = 0;

    public static void Score()
    {
        playerScore += ballVal * ballNumMult * scoreMult;
        Debug.Log(playerScore);
    }
}
