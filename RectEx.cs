using UnityEngine;

public static class RectEx
{
    public static void Left(this RectTransform rTrans, int value)
    {
        rTrans.offsetMin = new Vector2(value, rTrans.offsetMin.y);
    }

    public static void Right(this RectTransform rTrans, int value)
    {
        rTrans.offsetMax = new Vector2(-value, rTrans.offsetMax.y);
    }

    public static void Bottom(this RectTransform rTrans, int value)
    {
        rTrans.offsetMin = new Vector2(rTrans.offsetMin.x, value);
    }

    public static void Top(this RectTransform rTrans, int value)
    {
        rTrans.offsetMax = new Vector2(rTrans.offsetMax.x, -value);
    }
}