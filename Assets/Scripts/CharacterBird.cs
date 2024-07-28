using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBird : MonoBehaviour, IControllable
{
    private float speedFlyRight = 7f;
    private float speedFlyLeft = 5f;

    public void FlyRight()
    {
        transform.Translate(Vector2.right * speedFlyRight * Time.deltaTime);
    }
    public void FlyLeft()
    {
        transform.Translate(Vector2.left * speedFlyLeft * Time.deltaTime);
    }
}
