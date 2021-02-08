using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// FunnyHippoStudio公用文件，v20210110
/// </summary>
public class FHUtility
{
    /// <summary>
    /// 判断点是否在矩形内部（屏幕坐标）
    /// </summary>
    /// <param name="pos">点</param>
    /// <param name="rect">矩形</param>
    /// <returns></returns>
    public static bool ScreenPostionInWorldRect2D(Vector2 pos, Rect rect)
    {
        //ScreenToWorldPoint是把屏幕坐标转为unity世界坐标
        return WorldPostionInWorldRect2D(Camera.main.ScreenToWorldPoint(pos), rect);
    }

    /// <summary>
    /// 判断点是否在矩形内部（unity世界坐标）
    /// </summary>
    /// <param name="pos">点</param>
    /// <param name="rect">矩形</param>
    /// <returns></returns>
    public static bool WorldPostionInWorldRect2D(Vector2 pos, Rect rect)
    {
        if (pos.x >= rect.x && pos.x <= (rect.x + rect.width) && pos.y >= rect.y && pos.y <= (rect.y + rect.height))
        {
            return true;
        }
        return false;
    }

    /// <summary>
    /// 把精灵的坐标和大小转换为Rect
    /// </summary>
    /// <param name="sprite_renderer">精灵</param>
    /// <returns></returns>
    public static Rect SpriteToWorldRect2D(SpriteRenderer sprite_renderer)
    {
        Vector2 pos = sprite_renderer.gameObject.transform.position;

        Rect rect = Rect.zero;
        rect.x = pos.x - (sprite_renderer.size.x * sprite_renderer.gameObject.transform.localScale.x / 2f);
        rect.y = pos.y - (sprite_renderer.size.y * sprite_renderer.gameObject.transform.localScale.y / 2f);
        rect.width = sprite_renderer.size.x * sprite_renderer.gameObject.transform.localScale.x;
        rect.height = sprite_renderer.size.y * sprite_renderer.gameObject.transform.localScale.y;

        return rect;
    }

    /// <summary>
    /// 计算两个点的角度
    /// </summary>
    /// <param name="a">点a</param>
    /// <param name="b">点b</param>
    /// <returns></returns>
    public static float Angle360(Vector3 a, Vector3 b)
    {
        //两点的x、y值
        float x = a.x - b.x;
        float y = a.y - b.y;

        //斜边长度
        float hypotenuse = Mathf.Sqrt(Mathf.Pow(x, 2f) + Mathf.Pow(y, 2f));

        //求出弧度
        float cos = x / hypotenuse;
        float radian = Mathf.Acos(cos);

        //用弧度算出角度    
        float angle = 180 / (Mathf.PI / radian);

        if (y < 0)
        {
            angle = -angle;
        }
        else if (y == 0 && x < 0)
        {
            angle = 180;
        }
        return angle;
    }

    /// <summary>
    ///  已知斜边长度和角度计算xy坐标，例如2D STG中朝某个方向发射子弹会用到
    /// </summary>
    /// <param name="z">斜边长度</param>
    /// <param name="angle">角度（欧拉角）</param>
    /// <returns></returns>
    public static Vector2 HypotenuseAngle2Position(float z, float angle)
    {
        //获得弧度
        float radian = 2f * Mathf.PI / 360f * angle;

        //原版
        /*float x = Mathf.Sin(radian) * z;
        float y = Mathf.Cos(radian) * z; */

        float x = Mathf.Cos(radian) * z;
        float y = Mathf.Sin(radian) * z;

        return new Vector2(x, y);
    }

}
