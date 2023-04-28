using UnityEngine;

namespace DT.UniUtils.View {
  public class ShakeBehaviour : MonoBehaviour {
    [Min(0)]
    public float range = 1;

    public float GetShakeValue(float initial) {
      return initial + Random.Range(-this.range, this.range);
    }
  }
}