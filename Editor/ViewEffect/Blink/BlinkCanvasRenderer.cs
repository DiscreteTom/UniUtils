using UnityEngine;

namespace DT.UniUtils.View {
  [RequireComponent(typeof(CanvasRenderer))]
  public class BlinkCanvasRenderer : BlinkBehaviour<CanvasRenderer> {
    protected virtual new void Start() {
      base.Start();
      if (this.startAlphaAsMax) this.maxAlpha = this.component.GetAlpha();
      if (this.randomPhase) this.phase = Random.Range(0, this.maxAlpha - this.minAlpha);
    }

    protected virtual void Update() {
      this.component.SetAlpha(this.GetAlpha());
    }

    protected virtual void OnDisable() {
      this.component.SetAlpha(1);
    }
  }
}