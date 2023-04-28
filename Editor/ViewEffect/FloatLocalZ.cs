using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalZ : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.localPosition.z;
    }

    void Update() {
      this.transform.SetLocalPositionZ(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}