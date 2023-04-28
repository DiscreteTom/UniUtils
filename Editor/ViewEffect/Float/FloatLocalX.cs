using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalX : FloatBehaviour {
    protected new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.x;
    }

    protected void Update() {
      this.transform.SetLocalPositionX(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected void OnDisable() {
      this.transform.SetLocalPositionX(this.offset);
    }
  }
}