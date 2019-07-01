using UnityEngine;

public static class Matrices
{
    public static Matrix4x4 RotateX(float angleRad)
    {
        Matrix4x4 m = Matrix4x4.identity;     //  1   0   0   0 
        m.m11 = m.m22 = Mathf.Cos(angleRad);  //  0  cos -sin 0
        m.m21 = Mathf.Sin(angleRad);          //  0  sin  cos 0
        m.m12 = -m.m21;                       //  0   0   0   1
        return m;
    }
    public static Matrix4x4 RotateY(float angleRad)
    {
        Matrix4x4 m = Matrix4x4.identity;     // cos  0  sin  0
        m.m00 = m.m22 = Mathf.Cos(angleRad);  //  0   1   0   0
        m.m02 = Mathf.Sin(angleRad);          //-sin  0  cos  0
        m.m20 = -m.m02;                       //  0   0   0   1
        return m;
    }
    public static Matrix4x4 RotateZ(float angleRad)
    {
        Matrix4x4 m = Matrix4x4.identity;     // cos -sin 0   0
        m.m00 = m.m11 = Mathf.Cos(angleRad);  // sin  cos 0   0
        m.m10 = Mathf.Sin(angleRad);          //  0   0   0   0
        m.m01 = -m.m10;                       //  0   0   0   1
        return m;
    }
    public static Matrix4x4 Rotate(Vector3 eulerAngles)
    {
        var rad = eulerAngles * Mathf.Deg2Rad;
        return RotateY(rad.y) * RotateX(rad.x) * RotateZ(rad.z);
    }
    public static Matrix4x4 Scale(Vector3 scale)
    {
        var m = Matrix4x4.identity; //  sx   0   0   0
        m.m00 = scale.x;            //   0  sy   0   0
        m.m11 = scale.y;            //   0   0  sz   0
        m.m22 = scale.z;            //   0   0   0   1
        return m;
    }
    public static Matrix4x4 Translate(Vector3 position)
    {
        var m = Matrix4x4.identity; // 1   0   0   x
        m.m03 = position.x;         // 0   1   0   y
        m.m13 = position.y;         // 0   0   1   z
        m.m23 = position.z;         // 0   0   0   1
        return m;
    }
    public static Matrix4x4 TRS(Vector3 position, Vector3 euler, Vector3 scale)
    {
        return Translate(position) * Rotate(euler) * Scale(scale);
    }
}
