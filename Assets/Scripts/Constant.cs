using System.Collections.Generic;
using UnityEngine;

public class Constant
{
    //背景滚动速度
    public static readonly float BgScroll = 0.5f;

    //是否暂停游戏
    public static bool GameIsPause = false;

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
        else if ((y == 0) && (x < 0))
        {
            angle = 180;
        }
        return angle;
    }

}
