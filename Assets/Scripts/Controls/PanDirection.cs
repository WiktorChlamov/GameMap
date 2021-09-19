using UnityEngine;

public class PanDirection
{
    public Vector2 GetDirection(float x,float y)
    {
        Vector2 direction = Vector2.zero;
        if (y >= Screen.height * 0.95f)
        {
            direction.y += 1;
        }
        if (y <= Screen.height * 0.05f)
        {
            direction.y -= 1;
        }
        if (x >= Screen.width * 0.95f)
        {
            direction.x += 1;
        }
        if (x <= Screen.width * 0.05f)
        {
            direction.x -= 1;
        }
        return direction;
    }
}
