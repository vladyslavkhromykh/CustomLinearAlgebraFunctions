using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class V3
{

    public static Vector3 Addition(Vector3 a, Vector3 b) {
        return new Vector3(a.x + b.x, a.y + b .y, a.z + b.z);
    }

    public static Vector3 Subtraction(Vector3 a, Vector3 b) {
        return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);
    }

    public static float Magnitude(Vector3 vector) {
       return Mathf.Pow((vector.x*vector.x + vector.y*vector.y + vector.z*vector.z), 2.0f);
    }

    public static Vector3 ScalarMultiplication(Vector3 vector, float scalar) {
        return new Vector3(vector.x * scalar, vector.y * scalar, vector.z * scalar);
    }

    public static Vector3 Normalized(Vector3 vector) {
        float magnitude = V3.Magnitude(vector);
        return new Vector3(vector.x / magnitude, vector.y / magnitude, vector.z / magnitude);
    }

    public static float DotProduct(Vector3 a, Vector3 b) {
        // can be calculated as:
        // V3.Magnitude(a)*V3.Magnitude(b)*Mathf.Cos(Mathf.Deg2Rad * Vector3.Angle(a, b));
        return (a.x*b.x + a.y*b.y + a.z*b.z);
    }

    // Dot products: a*b = |a||b|cosΘ, where Θ - angle between vectors, so angle:
    // angle = acos(a*b/|a||b|), if a and b normalized: angle = acos(a*b)
    public static float AngleBetweenVectors(Vector3 a, Vector3 b) {
        // if vector3 normalized, we can remove magnitudes:
        // return Mathf.Acos (DotProduct(a, b)/ (Magnitude(a)*V3.Magnitude(b)));
        return Mathf.Rad2Deg * Mathf.Acos (DotProduct(a, b));
    }

    public static Vector3 CrossProduct(Vector3 a, Vector3 b) {
        return new Vector3(a.y * b.z - a.z * b.y, a.z * b.x - a.x * b.z, a.x * b.y - a.y * b.x); 
    }
}
