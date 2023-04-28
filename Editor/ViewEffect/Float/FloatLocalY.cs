using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalY : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.localPosition.y;
    }

    void Update() {
      this.transform.SetLocalPositionY(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}