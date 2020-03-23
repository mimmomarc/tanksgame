using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundFromButton : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlaySound(string name)
    {
        FindObjectOfType<AudioManager>().Play(name);
    }
}
