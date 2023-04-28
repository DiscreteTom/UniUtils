using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalY : FloatBehaviour {
    protected virtual new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.y;
    }

    protected virtual void Update() {
      this.transform.SetLocalPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected virtual void OnDisable() {
      this.transform.SetLocalPositionY(this.offset);
    }
  }
}