using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteResume : MonoBehaviour
{
    private bool index = false;
    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
        {
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1
        }
    }

    void Update()
    {
         ChangeTheDamnSpriteResume();
    }

    public void ChangeTheDamnSpriteResume()
    {
        if ( index == false) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = sprite1;
        }
        if ( index == true)
        {
            spriteRenderer.sprite = sprite2; // otherwise change it back to sprite1
        }
    }

    private void ChoicesButton()
    {
        index = !index;
        Debug.Log(index);
    }
}
