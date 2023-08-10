using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class changeImage : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite oldSprite;
    public Sprite angleSprite;
    private Camera mainCamera;
    private bool isMouseOverObject;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (isMouseOverObject)
            {
                ChangeSprite();
            }
        }
        // old code
        if (Input.GetMouseButtonDown(0))
        {
            if (isMouseOverObject)
            {
                ChangeSprite();
            }
        }
        else if (Input.GetMouseButtonUp(1))
        {
            if (isMouseOverObject)
            {
                RemoveSprite();
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && spriteRenderer.sprite == newSprite || Input.GetKeyDown(KeyCode.R) && spriteRenderer.sprite == angleSprite)
        {
            if (isMouseOverObject)
            {
                spriteRenderer.transform.Rotate(Vector3.forward, 90f);
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (isMouseOverObject)
            {
                ChangeSpriteAngle();
            }
        }
    }

    void OnMouseEnter()
    {
        isMouseOverObject = true;
    }

    void OnMouseExit()
    {
        isMouseOverObject = false;
    }

    void ChangeSprite()
    {
        spriteRenderer.sprite = newSprite;
    }

    void ChangeSpriteAngle()
    {
        spriteRenderer.sprite = angleSprite;
    }

    void RemoveSprite()
    {
        spriteRenderer.sprite = oldSprite;
    }
}