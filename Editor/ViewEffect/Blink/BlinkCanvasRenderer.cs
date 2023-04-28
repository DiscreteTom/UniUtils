using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(CanvasRenderer))]
  public class BlinkCanvasRenderer : BlinkBehaviour<CanvasRenderer> {
    new void Start() {
      base.Start();
      if (this.startAlphaAsMax) this.maxAlpha = this.component.GetAlpha();
      if (this.randomPhase) this.phase = Random.Range(0, this.maxAlpha - this.minAlpha);
    }

    void Update() {
      this.component.SetAlpha(this.GetAlpha());
    }

    void OnDisable() {
      this.component.SetAlpha(1);
    }
  }
}