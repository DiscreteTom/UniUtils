using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalZ : FloatBehaviour {
    new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.z;
    }

    void Update() {
      this.transform.SetLocalPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    void OnDisable() {
      this.transform.SetLocalPositionZ(this.offset);
    }
  }
}