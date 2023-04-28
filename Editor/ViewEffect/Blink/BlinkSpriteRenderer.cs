using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(SpriteRenderer))]
  public class BlinkSpriteRenderer : BlinkBehaviour<SpriteRenderer> {
    new void Start() {
      base.Start();
      if (this.startAlphaAsMax) this.maxAlpha = this.component.color.a;
    }

    void Update() {
      this.component.WithAlpha(this.GetAlpha());
    }

    void OnDisable() {
      this.component.WithAlpha(1);
    }
  }
}