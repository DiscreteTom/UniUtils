using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatZ : FloatBehaviour {
    protected virtual new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.z;
    }

    protected virtual void Update() {
      this.transform.SetPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected virtual void OnDisable() {
      this.transform.SetPositionZ(this.offset);
    }
  }
}