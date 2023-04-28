using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatZ : FloatBehaviour {
    protected new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.z;
    }

    protected void Update() {
      this.transform.SetPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected void OnDisable() {
      this.transform.SetPositionZ(this.offset);
    }
  }
}