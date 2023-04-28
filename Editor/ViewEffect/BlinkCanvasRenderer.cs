using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(CanvasRenderer))]
  public class BlinkCanvasRenderer : BlinkBehaviour<CanvasRenderer> {
    void Update() {
      if (this.blinking)
        this.component.SetAlpha(this.GetAlpha());
    }

    public void StopBlink() {
      base.StopBlink();
      this.component.SetAlpha(1);
    }
  }
}