using System;
using UnityEngine;

namespace DT.UniUtils {
  public static class TransformExtension {
    public static void SetPositionX(this Transform t, float value) {
      t.position = t.position.WithX(value);
    }
    public static void SetPositionY(this Transform t, float value) {
      t.position = t.position.WithY(value);
    }
    public static void SetPositionZ(this Transform t, float value) {
      t.position = t.position.WithZ(value);
    }

    public static void ForEachChild(this Transform t, Action<Transform, int> action) {
      for (int i = 0; i < t.childCount; i++) {
        action(t.GetChild(i), i);
      }
    }
    public static void ForEachChild(this Transform t, Action<Transform> action) {
      t.ForEachChild((t, i) => action(t));
    }
    public static T[] MapChildren<T>(this Transform t, Func<Transform, int, T> action) {
      T[] result = new T[t.childCount];
      for (int i = 0; i < t.childCount; i++) {
        result[i] = action(t.GetChild(i), i);
      }
      return result;
    }
    public static T[] MapChildren<T>(this Transform t, Func<Transform, T> action) {
      return t.MapChildren((t, i) => action(t));
    }
  }
}