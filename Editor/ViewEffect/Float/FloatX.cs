using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatX : FloatBehaviour {
    protected virtual new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.x;
    }

    protected virtual void Update() {
      this.transform.SetPositionX(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    protected virtual void OnDisable() {
      this.transform.SetPositionX(this.offset);
    }
  }
}