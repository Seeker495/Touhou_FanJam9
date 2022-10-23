using System.Collections;
using DG.Tweening;
using UnityEngine;

public class UI_ButtonTween: MonoBehaviour
{
    [Header("UI_SO to access Tween value")]
    [SerializeField]
    private UI_ElementsScriptableObject _UI_ElementsScriptableObject;

    [Header("Objects to be tween")]
    [SerializeField]
    private RectTransform myUI_Rect;
    [SerializeField]
    private bool isMovingDown;
    private float currentTweenDelay;

    [Header("QuickTutorial Buttons -> Only going Down")]
    [SerializeField]
    private GameObject[] tutorialButton_UIs;

    //[Header("_READ_ONLY")]
    //[SerializeField]
    private RectTransform myGoal_Rect;
    //[SerializeField]
    private Vector2 myUI_OGPos;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i < tutorialButton_UIs.Length;i++)
        {
            //tutorialButton_UIs[i].gameObject.SetActive(false);
        }

        myUI_OGPos = myUI_Rect.anchoredPosition;
        myGoal_Rect = this.GetComponent<RectTransform>();
        currentTweenDelay = _UI_ElementsScriptableObject.TweenDelaySeconds;

        if (isMovingDown)
        {
            StartCoroutine(DelayTween_MoveUIDown());
        }
        else
        {
            StartCoroutine(DelayTween_MoveUIUp());
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

    private IEnumerator DelayTween_MoveUIUp()
    {
        //Check for delay first then Tween
        yield return new WaitForSeconds(currentTweenDelay);
        myUI_Rect.DOAnchorPosY(myGoal_Rect.anchoredPosition.y,
            _UI_ElementsScriptableObject.TweenDuration,
            _UI_ElementsScriptableObject.TweenSnapping);
    }

    private IEnumerator DelayTween_MoveUIDown()
    {
        //Check for delay first then Tween
        yield return new WaitForSeconds(currentTweenDelay);
        myUI_Rect.DOAnchorPosY(myGoal_Rect.anchoredPosition.y,
            _UI_ElementsScriptableObject.TweenDuration,
            _UI_ElementsScriptableObject.TweenSnapping).OnComplete(OnTweenFinished);
    }

    void OnTweenFinished()
    {
        for (int i = 0;i < tutorialButton_UIs.Length;i++)
        {
            //tutorialButton_UIs[i].gameObject.SetActive(true);
        }
    }
}
