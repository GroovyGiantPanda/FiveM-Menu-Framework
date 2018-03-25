using CitizenFX.Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;

static class Extensions
{
    public static T Clamp<T>(T value, T min, T max)
        where T : System.IComparable<T>
    {
        T result = value;
        if (value.CompareTo(max) > 0)
            result = max;
        if (value.CompareTo(min) < 0)
            result = min;
        return result;
    }

    public static bool NextBool(this Random r, int truePercentage = 50)
    {
        return r.NextDouble() < truePercentage / 100.0;
    }

    public static async Task ForEachAsync<T>(this List<T> list, Func<T, Task> func)
    {
        foreach (var value in list)
        {
            await func(value);
        }
    }

    public static PointF Add(this PointF c1, PointF c2)
    {
        return new PointF(c1.X + c2.X, c1.Y + c2.Y);
    }

    public static PointF Subtract(this PointF c1, PointF c2)
    {
        return new PointF(c1.X - c2.X, c1.Y - c2.Y);
    }

    public static List<T> Slice<T>(this List<T> list, int start, int end)
    {
        return list.Skip(start).Take(end - start + 1).ToList();
    }

    public static bool IsBetween<T>(this T value, T start, T end) where T : IComparable
    {
        return value.CompareTo(start) >= 0 && value.CompareTo(end) <= 0;
    }
    
    public static Color ToColor(this string color)
    {
        try
        {
            return Color.FromArgb(int.Parse(color.Replace("#", ""),
                         System.Globalization.NumberStyles.AllowHexSpecifier));
        }
        catch (Exception e)
        {
            Log.Error($"ToColor exception: {e}");
        }
        return Color.FromArgb(255, 255, 255, 255);
    }

    public static float[] ToArray(this Vector3 vector)
    {
        try
        {
            return new float[] { vector.X, vector.Y, vector.Z };
        }
        catch (Exception e)
        {
            Log.Error($"ToArray exception: {e}");
        }
        return null;
    }

    public static Vector3 ToVector3(this float[] xyzArray)
    {
        try
        {
            return new Vector3(xyzArray[0], xyzArray[1], xyzArray[2]);
        }
        catch (Exception e)
        {
            Log.Error($"ToVector3 exception: {e}");
        }
        return Vector3.Zero;
    }
}