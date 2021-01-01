using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Sprite字符串，用字符映射到对应的Sprite，对应FHSpriteText.prefab。
 * 设置Sprite集合的时候，每个Sprite的大小尽可能一致，如果没法一致尽量接近第1个sprite的大小，因为计算总长度的时候会根据第1个sprite来计算的。
*/
public class FHSpriteText : MonoBehaviour
{
    public string SpritesNamePrefix = ""; //字符对应的精灵的name属性的前缀
    public string StringContent = ""; //要显示的字符串
    public AlignmentMode Alignment = AlignmentMode.Left; //对齐模式，如果是居右和IsVerticalMode = true的情况下，字符将会由下往上排
    public Vector2 CharScale = Vector2.one; //放缩
    public float CharCpacing = 0f; //字符之间的间距
    public bool IsVerticalMode = false; //垂直排列模式，false就是水平排列
    public Sprite[] Sprites = { };  //字符对应的精灵

    IDictionary<string, Sprite> SpriteData;

    public enum AlignmentMode
    {
        Left,
        Center,
        Right
    }

    private void Awake()
    {
        SpriteData = new Dictionary<string, Sprite>();
        foreach (var v in Sprites)
        {
            SpriteData[v.name] = v;
        }

        //Debug.Log("FHSpriteText初始化");
    }

    // Start is called before the first frame update
    void Start()
    {
        UpdateStringContent(StringContent);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        SpriteData.Clear();

        //Debug.Log("FHSpriteText释放");
    }

    /// <summary>
    /// 设置字符串
    /// </summary>
    /// <param name="string_content">需要设置的字符串</param>
    public void SetStringContent(string string_content)
    {
        StringContent = string_content;
        UpdateStringContent(StringContent);
    }
    void UpdateStringContent(string string_content)
    {
        Transform string_layer = transform.Find("StringLayer");

        //清理旧的内容
        for (int i = 0; i < string_layer.childCount; i++)
        {
            Destroy(string_layer.GetChild(i).gameObject);
        }

        /*if (string_content.Length == 0 || Sprites.Length == 0)
        {
            Debug.Log("没有设置字符串内容或字符对应的精灵");
            return;
        }*/
        if (Sprites.Length == 0)
        {
            Debug.Log("没有设置字符对应的精灵");
            return;
        }

        float offset_val = 0f;
        if (Alignment == AlignmentMode.Left)
        {
            offset_val = 0f;
        }
        else
        {
            //居中和居右走这里
            //居中是总字符串的Sprite加起来的长度除2，居右就是总长度

            float a = string_content.Length - 1; //sprite的个数，用来乘后面的sprite实际大小的，这样就得出总长度了

            float b = 0f;
            if (!IsVerticalMode)
            {
                //因为第1个字符开始需要往左，所以a必须是负数
                a = -a;

                //水平排列字符
                b = Sprites[0].rect.size.x / Sprites[0].pixelsPerUnit + CharCpacing; //sprite的大小转换为unity单位后+间隔
                b *= CharScale.x; //乘放缩得出每个sprite的实际大小
            }
            else
            {
                //垂直排列字符
                b = Sprites[0].rect.size.y / Sprites[0].pixelsPerUnit + CharCpacing; //sprite的大小转换为unity单位后+间隔
                b *= CharScale.y; //乘放缩得出每个sprite的实际大小
            }
            offset_val = a * b;

            if (Alignment == AlignmentMode.Center)
            {
                offset_val /= 2f;
            }
        }

        foreach (var s in string_content)
        {
            string sprite_name = SpritesNamePrefix + s;
            if (SpriteData.ContainsKey(sprite_name))
            {
                Transform char_sprite = Instantiate(transform.Find("CharSprite"));
                char_sprite.SetParent(string_layer);
                char_sprite.localScale = CharScale;

                SpriteRenderer char_sprite_renderer = char_sprite.GetComponent<SpriteRenderer>();
                char_sprite_renderer.sprite = SpriteData[sprite_name];

                if (!IsVerticalMode)
                {
                    //水平排列字符
                    char_sprite.localPosition = new Vector3(offset_val, 0, 0);
                    offset_val += (char_sprite_renderer.size.x + CharCpacing) * CharScale.x;
                }
                else
                {
                    //垂直排列字符
                    char_sprite.localPosition = new Vector3(0, offset_val, 0);
                    offset_val -= (char_sprite_renderer.size.y + CharCpacing) * CharScale.y;
                }
            }
            else
            {
                Debug.Log("FHSpriteText找不到Sprite的前缀名或Sprite的名称，请正确设置NamePrefix属性和Sprites里面的元素名称");
                break;
            }
        }
    }
}
