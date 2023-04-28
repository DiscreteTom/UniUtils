using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(SpriteRenderer))]
  public class BlinkSpriteRenderer : BlinkBehaviour<SpriteRenderer> {
    void Update() {
      this.component.WithAlpha(this.GetAlpha());
    }

    public void OnDisable() {
      this.component.WithAlpha(1);
    }
  }
}