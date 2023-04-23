using System;
using System.Collections;
using UnityEngine;

namespace DT.UniUtils {
  public static class MonoBehaviourExtension {
    public static void Invoke(this MonoBehaviour mb, Action f, float delay) {
      static IEnumerator InvokeRoutine(Action f, float delay) {
        yield return new WaitForSeconds(delay);
        f();
      }
      mb.StartCoroutine(InvokeRoutine(f, delay));
    }

    public static void InvokeRepeating(this MonoBehaviour mb, Action f, float delay, float interval) {
      static IEnumerator InvokeRepeatingRoutine(Action f, float delay, float interval) {
        yield return new WaitForSeconds(delay);
        while (true) {
          f();
          yield return new WaitForSeconds(interval);
        }
      }
      mb.StartCoroutine(InvokeRepeatingRoutine(f, delay, interval));
    }

    public static void ExitGame(this MonoBehaviour mb) {
#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
#else
      UnityEngine.Application.Quit();
#endif
    }
  }
}