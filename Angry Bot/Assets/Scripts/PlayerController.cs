using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum PlayerState
{
    Idle,
    Walk,
    LeftWalk,
    RightWalk,
    Run,
    Attack,
    Dead,
}

public class PlayerController : MonoBehaviour
{
    public PlayerState playerState;
    public Vector3 lookDirection;
    public float speed;
    public float walkSpeed;
    public float runSpeed;

    private Animation anim;
    public AnimationClip idleAni;
    public AnimationClip walkAni;
    public AnimationClip leftWalkAni;
    public AnimationClip rightWalkAni;
    public AnimationClip runAni;


    private AudioSource audioSrc;
    public AudioClip shotSound;
    public GameObject bullet;
    public Transform shotPoint;
    public GameObject shotFx;

    public Slider lifeBar;
    public float maxHp;
    public float hp;

    private void Start()
    {
        anim = GetComponent<Animation>();
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (playerState != PlayerState.Dead)
        {
            KeyboardInput();
            LookUpdate(false);
        }

        AnimationUpdate();
    }

    void KeyboardInput()
    {
        float xx = Input.GetAxis("Horizontal");
        float zz = Input.GetAxis("Vertical");

        if (playerState != PlayerState.Attack)
        {
            if (xx != 0 || zz != 0)
            {
                lookDirection = (xx * Vector3.right) + (zz * Vector3.forward);

                if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
                {
                    speed = runSpeed;
                    playerState = PlayerState.Run;
                }
                else
                {
                    speed = walkSpeed;
                    playerState = PlayerState.Walk;
                }
            }
            else if (playerState != PlayerState.Idle)
            {
                playerState = PlayerState.Idle;
                speed = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && playerState != PlayerState.Dead)
            StartCoroutine(nameof(Shot));   // StartCoroutine(Shot());
    }

    public void LookUpdate(bool rightNow)
    {
        Quaternion r = Quaternion.LookRotation(lookDirection);
        if (rightNow)
            transform.rotation = r;
        else
            transform.rotation =
                Quaternion.RotateTowards(transform.rotation, r, 600f * Time.deltaTime);

        //4. Q, E 키를 눌렀을 때 각각 좌, 우로 이동하는 기능을 추가한다. (애니메이션 적용)
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * walkSpeed * Time.deltaTime);
            playerState = PlayerState.LeftWalk;
        }

        else if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.right * walkSpeed * Time.deltaTime);
            playerState = PlayerState.RightWalk;
        }

        else
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

    }

    void AnimationUpdate()
    {
        switch (playerState)
        {
            case PlayerState.Idle:
                anim.CrossFade(idleAni.name, 0.2f);
                break;
            case PlayerState.Walk:
                anim.CrossFade(walkAni.name, 0.2f);
                anim[walkAni.name].speed = 1f; //3. 쉬프트 키를 눌러 달려갈 때 애니메이션 속도를 증가 시킨다._속도 원상복구
                break;
            case PlayerState.LeftWalk:
                anim.CrossFade(leftWalkAni.name, 0.2f);               
                break;
            case PlayerState.RightWalk:
                anim.CrossFade(rightWalkAni.name, 0.2f);
                break;
            case PlayerState.Run:
                anim.CrossFade(runAni.name, 0.2f);
                anim[runAni.name].speed = 2f; //3. 쉬프트 키를 눌러 달려갈 때 애니메이션 속도를 증가 시킨다.
                break;
            case PlayerState.Attack:
                anim.CrossFade(idleAni.name, 0.2f);
                break;
            case PlayerState.Dead:
                anim.CrossFade(idleAni.name, 0.2f);
                break;
        }
    }

    public IEnumerator Shot()
    {
        GameObject bulletObj = Instantiate(
            bullet,
            shotPoint.position,
            Quaternion.LookRotation(shotPoint.forward));

        Physics.IgnoreCollision(
            bulletObj.GetComponent<Collider>(),
            GetComponent<Collider>());

        audioSrc.clip = shotSound;
        audioSrc.Play();

        shotFx.SetActive(true);

        playerState = PlayerState.Attack;
        speed = 0;

        yield return new WaitForSeconds(0.15f);
        shotFx.SetActive(false);

        yield return new WaitForSeconds(0.15f);
        playerState = PlayerState.Idle;
    }

    public void Hurt(float damage)
    {
        if (hp > 0)
        {
            hp -= damage;
            lifeBar.value = hp / maxHp;
        }

        if (hp <= 0)
        {
            speed = 0;
            playerState = PlayerState.Dead;

            PlayManager pm = GameObject.Find("PlayManager").GetComponent<PlayManager>();
            pm.GameOver();
        }
    }
}
