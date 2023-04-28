using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatX : FloatBehaviour {
    void Start() {
      if (this.useInitPosition) this.offset = this.transform.position.x;
    }

    void Update() {
      this.transform.SetPositionX(this.offset + Mathf.Sin(this.timeOffset + Time.time * this.speed) * this.range);
    }
  }
}