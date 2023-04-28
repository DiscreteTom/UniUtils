using UnityEngine;

namespace DT.UniUtils.View {
  public class KickOut2D : MonoBehaviour {
    [Range(0, 360)]
    public float initAngle = 0;
    public bool randomInitAngle = true;
    public float initRotateSpeed = 1;
    public bool randomInitRotateSpeed = true;
    public Vector2 initSpeed = Vector2.up;
    public Vector2 randomInitSpeedRange = new Vector2(0, 0);
    public Vector2 gravityScale = Vector2.down * 9.8f;
    public bool destroyOnInvisible = true;

    protected virtual void Start() {
      if (this.randomInitAngle)
        this.initAngle = Random.Range(0, 360);
      this.transform.rotation = Quaternion.Euler(0, 0, this.initAngle);

      if (this.randomInitRotateSpeed)
        this.initRotateSpeed = Random.Range(-this.initRotateSpeed, this.initRotateSpeed);

      var randomX = Random.Range(-this.randomInitSpeedRange.x, this.randomInitSpeedRange.x);
      var randomY = Random.Range(-this.randomInitSpeedRange.y, this.randomInitSpeedRange.y);
      this.initSpeed += new Vector2(randomX, randomY);
    }

    protected virtual void Update() {
      // rotate
      this.transform.rotation = Quaternion.Euler(0, 0, this.transform.rotation.eulerAngles.z + this.initRotateSpeed * Time.deltaTime);
      // update speed with gravity
      this.initSpeed += this.gravityScale * Time.deltaTime;
      // update position
      this.transform.position += (Vector3)this.initSpeed * Time.deltaTime;
    }

    protected virtual void OnBecameInvisible() {
      if (this.destroyOnInvisible)
        Destroy(this.gameObject);
    }
  }
}