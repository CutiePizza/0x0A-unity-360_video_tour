using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFade : MonoBehaviour
{
    public Animator anim;
    
    public void play()
    {
        anim.SetTrigger("fadingout");
    }
}
