using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatX : FloatBehaviour {
    new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.x;
    }

    void Update() {
      this.transform.SetPositionX(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    void OnDisable() {
      this.transform.SetPositionX(this.offset);
    }
  }
}