using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalX : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.localPosition.x;
    }

    void Update() {
      this.transform.SetLocalPositionX(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}