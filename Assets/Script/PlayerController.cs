using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 6;
    public float speed = 50f;
    public float jumpPower = 900f;

    public bool grounded;
    public bool canDoubleJump;

    //stats
    public int curHealth;
    public int maxHealth = 5;

    private Rigidbody2D rb2d;
    private Animator anim;
    private GameMaster gm;

    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();

        curHealth = maxHealth;

        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();

    }

    [System.Obsolete]
    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetButtonDown("Jump"))
        {
            if(grounded)
            {
                rb2d.AddForce(Vector2.up * jumpPower);
                canDoubleJump = true;
                grounded = false;
            }
            else
            {
                if(canDoubleJump)
                {
                    canDoubleJump = false;
                    rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
                    rb2d.AddForce(Vector2.up * jumpPower);
                }
            }
        }

        if(curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if(curHealth <= 0)
        {
            Die();
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce((Vector2.right * speed) * h);

        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }

        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
    }

    [System.Obsolete]
    void Die()
    {
        //Restart
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Damage(int dmg)
    {
        curHealth -= dmg;
        //gameObject.GetComponent<Animation>().Play("Player_RedAnimation");
    }

    public IEnumerator Knockback(float knockDur, float knockbackPwr, Vector3 knockbackDir)
    {
        float timer = 0;

        while( knockDur > timer)
        {
            timer += Time.deltaTime;

            rb2d.AddForce(new Vector3(knockbackDir.x * 10, knockbackDir.y * knockbackPwr, transform.position.z));
        }
        yield return 0;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Coin"))
        {
            Destroy(col.gameObject);
            gm.score += 1;
        }

        if(col.CompareTag("InputTextYes"))
        {
            gm.score += 1;
        }

        if (col.CompareTag("InputTextNo"))
        {
            gm.score -= 1;
        }
    }

}
