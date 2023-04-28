using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(SpriteRenderer))]
  public class BlinkSpriteRenderer : BlinkBehaviour<SpriteRenderer> {
    void Update() {
      if (this.blinking)
        this.component.WithAlpha(this.GetAlpha());
    }

    public override void StopBlink() {
      base.StopBlink();
      this.component.WithAlpha(1);
    }
  }
}