using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatY : FloatBehaviour {
    protected new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.y;
    }

    protected void Update() {
      this.transform.SetPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected void OnDisable() {
      this.transform.SetPositionY(this.offset);
    }
  }
}