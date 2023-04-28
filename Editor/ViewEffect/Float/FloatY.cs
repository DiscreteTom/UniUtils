using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatY : FloatBehaviour {
    new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.position.y;
    }

    void Update() {
      this.transform.SetPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    void OnDisable() {
      this.transform.SetPositionY(this.offset);
    }
  }
}