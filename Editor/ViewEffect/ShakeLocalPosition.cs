using UnityEngine;

namespace DT.UniUtils.View {
  public class ShakeLocalPosition : ShakeBehaviour {
    [SerializeField] bool shakeZ = false;
    public bool shake {
      get {
        return this.shaking;
      }
      set {
        if (value) {
          this.shaking = true;
          this.initPos = this.transform.localPosition;
        } else {
          this.shaking = false;
          this.transform.localPosition = this.initPos;
        }
      }
    }

    Vector3 initPos;

    void Start() {
      if (this.shakeAtStart) {
        this.shake = true;
      }
    }

    void Update() {
      if (!this.shaking) return;

      var x = this.GetShakeValue(this.initPos.x);
      var y = this.GetShakeValue(this.initPos.y);
      var z = this.shakeZ ? this.GetShakeValue(this.initPos.z) : this.initPos.z;
      this.transform.localPosition = new Vector3(x, y, z);
    }
  }
}