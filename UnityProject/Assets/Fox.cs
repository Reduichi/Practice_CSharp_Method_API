using UnityEngine;

public class Fox : MonoBehaviour
{
    [Header("移動速度"), Range(0f, 50f)]
    public float speed;
    public Rigidbody2D Rig;
    public SpriteRenderer Sr ;

    /// <summary>
    /// 水平移動按鍵控制，並且增加剛體讓狐狸移動
    /// </summary>
    /// <param name="x"></param>
    private void OnAnimatorMove(float x)
    {
        x = Input.GetAxisRaw("Horizontal") * speed * 10;
        // transform.Translate(x * Time.deltaTime, 0, 0);
        // Time.deltaTime 一幀的時間

        Rig.AddForce(new Vector2(x, 0)); // 增加剛體
    }

    /// <summary>
    /// 判斷是否要轉向
    /// </summary>
    private void Turn() 
    {
        if (Input.GetKeyDown("a") )
        {
            Sr.flipX = true;
        }
        else if (Input.GetKeyDown("d"))
        {
            Sr.flipX = false;
        }
    }

    private void Update() 
    {
        OnAnimatorMove(20);
        Turn();
    }
}
