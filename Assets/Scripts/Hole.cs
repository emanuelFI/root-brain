﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    private void OnMouseDown()
    {
        FindObjectOfType<GamePlay>().loseLife();
    }
}