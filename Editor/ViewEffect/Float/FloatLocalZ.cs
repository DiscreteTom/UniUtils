using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalZ : FloatBehaviour {
    protected new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.z;
    }

    protected void Update() {
      this.transform.SetLocalPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected void OnDisable() {
      this.transform.SetLocalPositionZ(this.offset);
    }
  }
}