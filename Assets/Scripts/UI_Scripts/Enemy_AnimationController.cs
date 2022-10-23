using UnityEngine;

public class Enemy_AnimationController: MonoBehaviour
{
    //[SerializeField]
    private Animator enemyAnimator;

    [Header("We control the animation state through these bool")]
    [SerializeField]
    [Range(0, 3)]
    private int animationID = 0;
    [Header("READ_ONLY")]
    [SerializeField]
    private bool isCalm, isParanoid, isScared, isAttacking;

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        SwitchAnimation();

        //Debug Button
        /*if (Input.GetKeyDown(KeyCode.R))
        {
            //SwitchAnimation();
        }*/
    }


    public void SwitchAnimation()
    {
        //First reset all bool value to false
        ResetBoolValue();
        switch (animationID)
        {
            case 0:
                isCalm = true;
                PlayCalmAnimation();
                break;
            case 1:
                isParanoid = true;
                PlayParanoidAnimation();
                break;
            case 2:
                isScared = true;
                PlayScaredAnimation();
                break;
            case 3:
                isScared = true;
                isAttacking = true;
                PlayAttackAnimation();
                break;
        }
    }

    //This method reset all bool values to false
    private void ResetBoolValue()
    {
        isCalm = false;
        isParanoid = false;
        isScared = false;
        isAttacking = false;
    }

    private void PlayCalmAnimation()
    {
        if (isCalm && !isParanoid & !isScared & !isAttacking)
        {
            enemyAnimator.SetBool("isCalm", true);
            enemyAnimator.SetBool("isParanoid", false);
            enemyAnimator.SetBool("isScared", false);
            enemyAnimator.SetBool("isAttacking", false);
        }
    }

    private void PlayParanoidAnimation()
    {
        if (!isCalm && isParanoid & !isScared & !isAttacking)
        {
            enemyAnimator.SetBool("isCalm", false);
            enemyAnimator.SetBool("isParanoid", true);
            enemyAnimator.SetBool("isScared", false);
            enemyAnimator.SetBool("isAttacking", false);
        }
    }

    private void PlayScaredAnimation()
    {
        if (!isCalm && !isParanoid & isScared & !isAttacking)
        {
            enemyAnimator.SetBool("isCalm", false);
            enemyAnimator.SetBool("isParanoid", false);
            enemyAnimator.SetBool("isScared", true);
            enemyAnimator.SetBool("isAttacking", false);
        }
    }

    private void PlayAttackAnimation()
    {
        if (!isCalm && !isParanoid & isScared & isAttacking)
        {
            enemyAnimator.SetBool("isCalm", false);
            enemyAnimator.SetBool("isParanoid", false);
            enemyAnimator.SetBool("isScared", true);
            enemyAnimator.SetBool("isAttacking", true);
        }
    }
}
