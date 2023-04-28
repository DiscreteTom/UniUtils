using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalZ : FloatBehaviour {
    protected virtual new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.z;
    }

    protected virtual void Update() {
      this.transform.SetLocalPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected virtual void OnDisable() {
      this.transform.SetLocalPositionZ(this.offset);
    }
  }
}