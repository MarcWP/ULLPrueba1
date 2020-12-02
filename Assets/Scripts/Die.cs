using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.current.onDeath += die;
    }

    // Reiniciamos escenas al no quedar vidas
    void die()
    {
        SceneManager.LoadScene("Escena1");
    }
}
