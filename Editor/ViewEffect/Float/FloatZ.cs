using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatZ : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.position.z;
    }

    void Update() {
      this.transform.SetPositionZ(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}