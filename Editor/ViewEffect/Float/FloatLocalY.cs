using UnityEngine;

namespace DT.UniUtils.View {
  public class FloatLocalY : FloatBehaviour {
    new void Start() {
      base.Start();
      if (this.useStartOffset) this.offset = this.transform.localPosition.y;
    }

    void Update() {
      this.transform.SetLocalPositionY(this.offset + Mathf.Sin(this.phase + Time.time * this.speed) * this.range);
    }

    void OnDisable() {
      this.transform.SetLocalPositionY(this.offset);
    }
  }
}