using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAdder : MonoBehaviour
{
    public SpriteRenderer sprSky;
    public SpriteRenderer sprGround;
    public Sprite groundSprite;
    public Sprite skySprite;
    public SpriteMaskVisibility[] sprMaskObj;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        int count = 0;
        for (int i = 0; i < sprMaskObj.Length; i++)
        {
            if (sprMaskObj[i].isMaskEnabled)
            {
                count++;
            }
        }
        if (count == sprMaskObj.Length)
        {
            sprGround.sprite = groundSprite;
            sprSky.sprite = skySprite;
        }
    }
}
