// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double3x4 : System.IEquatable<double3x4>, IFormattable
    {
        public double3 c0;
        public double3 c1;
        public double3 c2;
        public double3 c3;

        /// <summary>double3x4 zero value.</summary>
        public static readonly double3x4 zero = new double3x4(0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0);


        /// <summary>Constructs a double3x4 matrix from four double3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a double3x4 matrix from 12 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13,
                         double m20, double m21, double m22, double m23)
        { 
            this.c0 = new double3(m00, m10, m20);
            this.c1 = new double3(m01, m11, m21);
            this.c2 = new double3(m02, m12, m22);
            this.c3 = new double3(m03, m13, m23);
        }

        /// <summary>Constructs a double3x4 matrix from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double3x4 matrix from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(bool v)
        {
            this.c0 = math.select(new double3(0.0), new double3(1.0), v);
            this.c1 = math.select(new double3(0.0), new double3(1.0), v);
            this.c2 = math.select(new double3(0.0), new double3(1.0), v);
            this.c3 = math.select(new double3(0.0), new double3(1.0), v);
        }

        /// <summary>Constructs a double3x4 matrix from a bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(bool3x4 v)
        {
            this.c0 = math.select(new double3(0.0), new double3(1.0), v.c0);
            this.c1 = math.select(new double3(0.0), new double3(1.0), v.c1);
            this.c2 = math.select(new double3(0.0), new double3(1.0), v.c2);
            this.c3 = math.select(new double3(0.0), new double3(1.0), v.c3);
        }

        /// <summary>Constructs a double3x4 matrix from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double3x4 matrix from a int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(int3x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        /// <summary>Constructs a double3x4 matrix from a single uint value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double3x4 matrix from a uint3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(uint3x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        /// <summary>Constructs a double3x4 matrix from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        /// <summary>Constructs a double3x4 matrix from a float3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(float3x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }


        /// <summary>Implicitly converts a single double value to a double3x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(double v) { return new double3x4(v); }

        /// <summary>Explicitly converts a single bool value to a double3x4 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double3x4(bool v) { return new double3x4(v); }

        /// <summary>Explicitly converts a bool3x4 matrix to a double3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double3x4(bool3x4 v) { return new double3x4(v); }

        /// <summary>Implicitly converts a single int value to a double3x4 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(int v) { return new double3x4(v); }

        /// <summary>Implicitly converts a int3x4 matrix to a double3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(int3x4 v) { return new double3x4(v); }

        /// <summary>Implicitly converts a single uint value to a double3x4 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(uint v) { return new double3x4(v); }

        /// <summary>Implicitly converts a uint3x4 matrix to a double3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(uint3x4 v) { return new double3x4(v); }

        /// <summary>Implicitly converts a single float value to a double3x4 matrix by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(float v) { return new double3x4(v); }

        /// <summary>Implicitly converts a float3x4 matrix to a double3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(float3x4 v) { return new double3x4(v); }



        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double lhs, double3x4 rhs) { return new double3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double lhs, double3x4 rhs) { return new double3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double lhs, double3x4 rhs) { return new double3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double lhs, double3x4 rhs) { return new double3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double lhs, double3x4 rhs) { return new double3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator ++ (double3x4 val) { return new double3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator -- (double3x4 val) { return new double3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double lhs, double3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double lhs, double3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double lhs, double3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double lhs, double3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 val) { return new double3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 val) { return new double3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double lhs, double3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double lhs, double3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public double3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double3x4* array = &this) { return ((double3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double3x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double3x4 matrix constructed from four double3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3) { return new double3x4(c0, c1, c2, c3); }

        /// <summary>Returns a double3x4 matrix constructed from from 12 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double m00, double m01, double m02, double m03,
                                          double m10, double m11, double m12, double m13,
                                          double m20, double m21, double m22, double m23)
        {
            return new double3x4(m00, m01, m02, m03,
                                 m10, m11, m12, m13,
                                 m20, m21, m22, m23);
        }

        /// <summary>Returns a double3x4 matrix constructed from a single double value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double v) { return new double3x4(v); }

        /// <summary>Returns a double3x4 matrix constructed from a single bool value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(bool v) { return new double3x4(v); }

        /// <summary>Return a double3x4 matrix constructed from a bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(bool3x4 v) { return new double3x4(v); }

        /// <summary>Returns a double3x4 matrix constructed from a single int value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(int v) { return new double3x4(v); }

        /// <summary>Return a double3x4 matrix constructed from a int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(int3x4 v) { return new double3x4(v); }

        /// <summary>Returns a double3x4 matrix constructed from a single uint value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(uint v) { return new double3x4(v); }

        /// <summary>Return a double3x4 matrix constructed from a uint3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(uint3x4 v) { return new double3x4(v); }

        /// <summary>Returns a double3x4 matrix constructed from a single float value by converting it to double and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(float v) { return new double3x4(v); }

        /// <summary>Return a double3x4 matrix constructed from a float3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(float3x4 v) { return new double3x4(v); }

        /// <summary>Return the double4x3 transpose of a double3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 transpose(double3x4 v)
        {
            return double4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        // Fast matrix inverse for rigid transforms (Orthonormal basis and translation)
        public static double3x4 fastinverse(double3x4 m)
        {
            double3 c0 = m.c0;
            double3 c1 = m.c1;
            double3 c2 = m.c2;
            double3 pos = m.c3;

            double3 r0 = double3(c0.x, c1.x, c2.x);
            double3 r1 = double3(c0.y, c1.y, c2.y);
            double3 r2 = double3(c0.z, c1.z, c2.z);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);

            return double3x4(r0, r1, r2, pos);
        }

        /// <summary>Returns a uint hash code of a double3x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double3x4 v)
        {
            return csum(fold_to_uint(v.c0) * uint3(0xE7579997u, 0xEF7D56C7u, 0x66F38F0Bu) + 
                        fold_to_uint(v.c1) * uint3(0x624256A3u, 0x5292ADE1u, 0xD2E590E5u) + 
                        fold_to_uint(v.c2) * uint3(0xF25BE857u, 0x9BC17CE7u, 0xC8B86851u) + 
                        fold_to_uint(v.c3) * uint3(0x64095221u, 0xADF428FFu, 0xA3977109u)) + 0x745ED837u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a double3x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(double3x4 v)
        {
            return (fold_to_uint(v.c0) * uint3(0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu) + 
                    fold_to_uint(v.c1) * uint3(0x68EEE0F5u, 0xBC3B0A59u, 0x816EFB5Du) + 
                    fold_to_uint(v.c2) * uint3(0xA24E82B7u, 0x45A22087u, 0xFC104C3Bu) + 
                    fold_to_uint(v.c3) * uint3(0x5FFF6B19u, 0x5E6CBF3Bu, 0xB546F2A5u)) + 0xBBCF63E7u;
        }

    }
}
