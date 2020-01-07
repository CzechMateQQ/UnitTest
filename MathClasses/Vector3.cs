using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Vector3
    {
        public float x, y, z;

        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Vector3(float a, float b, float c)
        {
            x = a;
            y = b;
            z = c;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                lhs.x + rhs.x,
                lhs.y + rhs.y,
                lhs.z + rhs.z);
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(
                lhs.x - rhs.x,
                lhs.y - rhs.y,
                lhs.z - rhs.z);
        }

        public static Vector3 operator *(Matrix3 m, Vector3 v)
        {
            return new Vector3(
                m.m1 * v.x + m.m2 * v.y + m.m3 * v.z,
                m.m4 * v.x + m.m5 * v.y + m.m6 * v.z,
                m.m7 * v.x + m.m8 * v.y + m.m9 * v.z);
        }

        public static Vector3 operator *(float lhs, Vector3 rhs)
        {
            return new Vector3(
                lhs * rhs.x,
                lhs * rhs.y,
                lhs * rhs.z);
        }

        public static Vector3 operator *(Vector3 lhs, float rhs)
        {
            return new Vector3(
                lhs.x * rhs,
                lhs.y * rhs,
                lhs.z * rhs);
        }

        public float Dot(Vector3 rhs)
        {
            return x * rhs.x + y * rhs.y + z * rhs.z;
        }

        public Vector3 Cross(Vector3 rhs)
        {
            return new Vector3(
                y * rhs.z - z * rhs.y,
                z * rhs.x - x * rhs.z,
                x * rhs.y - y * rhs.x);
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt((double)x * x + y * y + z * z);
        }

        public void Normalize()
        {
            float m = Magnitude();

            x /= m;
            y /= m;
            z /= m;
        }
    }
}
