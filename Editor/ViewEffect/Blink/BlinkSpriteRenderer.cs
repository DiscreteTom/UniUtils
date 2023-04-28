using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(SpriteRenderer))]
  public class BlinkSpriteRenderer : BlinkBehaviour<SpriteRenderer> {
    protected new void Start() {
      base.Start();
      if (this.startAlphaAsMax) this.maxAlpha = this.component.color.a;
      if (this.randomPhase) this.phase = Random.Range(0, this.maxAlpha - this.minAlpha);
    }

    protected void Update() {
      this.component.WithAlpha(this.GetAlpha());
    }

    protected void OnDisable() {
      this.component.WithAlpha(1);
    }
  }
}