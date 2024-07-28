using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerBird : MonoBehaviour
{
    private IControllable characterBird;

    void Awake()
    {
        characterBird = GetComponent<IControllable>();

        if (characterBird == null)
        {
            Debug.Log("Пошёл нахуй");
        }
    }

    // Update is called once per frame
    void Update()
    {
        ReadFly();
    }

    public void ReadFly()
    {
        characterBird.FlyRight();
    }
}
