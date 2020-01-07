using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector4
    {
        public float x, y, z, w;

        public Vector4()
        {
            x = 0;
            y = 0;
            z = 0;
            w = 0;
        }

        public Vector4(float a, float b, float c, float d)
        {
            x = a;
            y = b;
            z = c;
            w = d;
        }
        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z,
                lhs.w + rhs.w);
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z,
                lhs.w - rhs.w);
        }

        public static Vector4 operator *(Matrix4 m, Vector4 v)
        {
            return new Vector4(
                m.m1 * v.x + m.m2 * v.y + m.m3 * v.z + m.m4 * v.w,
                m.m5 * v.x + m.m6 * v.y + m.m7 * v.z + m.m8 * v.w,
                m.m9 * v.x + m.m10 * v.y + m.m11 * v.z + m.m12 * v.w,
                m.m13 * v.x + m.m14 * v.y + m.m15 * v.z + m.m16 * v.w);
        }

        public static Vector4 operator *(float lhs, Vector4 rhs)
        {
            return new Vector4(
                lhs * rhs.x,
                lhs * rhs.y,
                lhs * rhs.z,
                lhs * rhs.w);
        }

        public static Vector4 operator *(Vector4 lhs, float rhs)
        {
            return new Vector4(
                lhs.x * rhs,
                lhs.y * rhs,
                lhs.z * rhs,
                lhs.w * rhs);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((double)x * x + y * y + z * z + w * w);
        }

        public void Normalize()
        {
            float m = Magnitude();

            x /= m;
            y /= m;
            z /= m;
            w /= m;
        }

        public float Dot(Vector4 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z + w * rhs.w;
        }

        public Vector4 Cross(Vector4 rhs)
        {
            return new Vector4(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x,
                0);
        }
    }
}
