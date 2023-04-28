using UnityEngine;

namespace DT.UniUtils.View {
  public class ShakePosition : ShakeBehaviour {
    public bool shakeZ = false;

    Vector3 initPos;

    void Start() {
      this.initPos = this.transform.position;
    }

    void Update() {
      var x = this.GetShakeValue(this.initPos.x);
      var y = this.GetShakeValue(this.initPos.y);
      var z = this.shakeZ ? this.GetShakeValue(this.initPos.z) : this.initPos.z;
      this.transform.position = new Vector3(x, y, z);
    }

    void OnDisable() {
      this.transform.position = this.initPos;
    }
  }
}