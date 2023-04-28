using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalY : FloatBehaviour {
    protected new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.y;
    }

    protected void Update() {
      this.transform.SetLocalPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected void OnDisable() {
      this.transform.SetLocalPositionY(this.offset);
    }
  }
}