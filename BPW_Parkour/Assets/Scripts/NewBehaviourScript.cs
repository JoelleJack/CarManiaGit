using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
        public AudioSource Burp;
        public AudioSource Slurp;

        public void PlayBurp()
        {
            Burp.Play();

        }

        public void PlaySlurp()
        {
            Slurp.Play();
        }
    
}
