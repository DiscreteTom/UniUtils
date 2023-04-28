using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(CanvasRenderer))]
  public class BlinkCanvasRenderer : BlinkBehaviour<CanvasRenderer> {
    void Update() {
      this.component.SetAlpha(this.GetAlpha());
    }

    void OnDisable() {
      this.component.SetAlpha(1);
    }
  }
}