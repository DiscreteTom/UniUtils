using System;
using UnityEngine;

namespace DT.UniUtils {
  public static class TransformExtension {
    public static void SetPositionX(this Transform original, float value) {
      original.position = original.position.WithX(value);
    }
    public static void SetPositionY(this Transform original, float value) {
      original.position = original.position.WithY(value);
    }
    public static void SetPositionZ(this Transform original, float value) {
      original.position = original.position.WithZ(value);
    }

    public static void ForEachChild(this Transform original, Action<Transform, int> action) {
      for (int i = 0; i < original.childCount; i++) {
        action(original.GetChild(i), i);
      }
    }
    public static void ForEachChild(this Transform original, Action<Transform> action) {
      original.ForEachChild((t, i) => action(t));
    }
    public static T[] MapChildren<T>(this Transform original, Func<Transform, int, T> action) {
      T[] result = new T[original.childCount];
      for (int i = 0; i < original.childCount; i++) {
        result[i] = action(original.GetChild(i), i);
      }
      return result;
    }
    public static T[] MapChildren<T>(this Transform original, Func<Transform, T> action) {
      return original.MapChildren((t, i) => action(t));
    }
  }
}