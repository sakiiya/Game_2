﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refillgel : MonoBehaviour
{
    
    
    
    
    public void gelrefillfuntion()
    {
        Gelfill.gelout.gelrefill = 100;
        money.pay.moneyhave -= 100;
    }
}
