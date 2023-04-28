using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatY : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.position.y;
    }

    void Update() {
      this.transform.SetPositionY(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}