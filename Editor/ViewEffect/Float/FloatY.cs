using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatY : FloatBehaviour {
    protected virtual new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.y;
    }

    protected virtual void Update() {
      this.transform.SetPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected virtual void OnDisable() {
      this.transform.SetPositionY(this.offset);
    }
  }
}