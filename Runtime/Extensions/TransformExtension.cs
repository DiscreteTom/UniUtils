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
    public static void SetLocalPositionX(this Transform t, float value) {
      t.localPosition = t.localPosition.WithX(value);
    }
    public static void SetLocalPositionY(this Transform t, float value) {
      t.localPosition = t.localPosition.WithY(value);
    }
    public static void SetLocalPositionZ(this Transform t, float value) {
      t.localPosition = t.localPosition.WithZ(value);
    }
    public static void SetLocalScaleX(this Transform t, float value) {
      t.localScale = t.localScale.WithX(value);
    }
    public static void SetLocalScaleY(this Transform t, float value) {
      t.localScale = t.localScale.WithY(value);
    }
    public static void SetLocalScaleZ(this Transform t, float value) {
      t.localScale = t.localScale.WithZ(value);
    }
    public static void SetRotationX(this Transform t, float value) {
      t.rotation = t.rotation.WithX(value);
    }
    public static void SetRotationY(this Transform t, float value) {
      t.rotation = t.rotation.WithY(value);
    }
    public static void SetRotationZ(this Transform t, float value) {
      t.rotation = t.rotation.WithZ(value);
    }
    public static void SetRotationW(this Transform t, float value) {
      t.rotation = t.rotation.WithW(value);
    }
    public static void SetLocalRotationX(this Transform t, float value) {
      t.localRotation = t.localRotation.WithX(value);
    }
    public static void SetLocalRotationY(this Transform t, float value) {
      t.localRotation = t.localRotation.WithY(value);
    }
    public static void SetLocalRotationZ(this Transform t, float value) {
      t.localRotation = t.localRotation.WithZ(value);
    }
    public static void SetLocalRotationW(this Transform t, float value) {
      t.localRotation = t.localRotation.WithW(value);
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