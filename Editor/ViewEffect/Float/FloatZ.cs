using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatZ : FloatBehaviour {
    new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.z;
    }

    void Update() {
      this.transform.SetPositionZ(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    void OnDisable() {
      this.transform.SetPositionZ(this.offset);
    }
  }
}