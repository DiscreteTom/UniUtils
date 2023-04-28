using UnityEngine;

namespace DT.UniUtils.View {
  public class ShakePosition : MonoBehaviour {
    [Min(0)]
    public float range = 1;
    [SerializeField] bool shakeAtStart = true;
    [SerializeField] bool shakeZ = false;
    public bool shake {
      get {
        return this.shaking;
      }
      set {
        if (value) {
          this.shaking = true;
          this.initPos = this.transform.position;
        } else {
          this.shaking = false;
          this.transform.position = this.initPos;
        }
      }
    }

    bool shaking = false;
    Vector3 initPos;

    void Start() {
      if (this.shakeAtStart) {
        this.shake = true;
      }
    }

    void Update() {
      var randomX = Random.Range(-this.range, this.range);
      var randomY = Random.Range(-this.range, this.range);
      var randomZ = this.shakeZ ? Random.Range(-this.range, this.range) : 0;
      this.transform.position = this.initPos + new Vector3(randomX, randomY, randomZ);
    }
  }
}