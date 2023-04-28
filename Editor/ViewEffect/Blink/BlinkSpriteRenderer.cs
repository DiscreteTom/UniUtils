using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(SpriteRenderer))]
  public class BlinkSpriteRenderer : BlinkBehaviour<SpriteRenderer> {
    new void Start() {
      base.Start();
      if (this.startAlphaAsMax) this.maxAlpha = this.component.color.a;
      if (this.randomPhase) this.phase = Random.Range(0, this.maxAlpha - this.minAlpha);
    }

    void Update() {
      this.component.WithAlpha(this.GetAlpha());
    }

    void OnDisable() {
      this.component.WithAlpha(1);
    }
  }
}