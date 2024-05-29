//Script made by Federico Bellucci 
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using System.Collections;

public class HandlerScript : MonoBehaviour
{

    //The circle that shows us the overall progress
    public Image fillImage;
    //Holder of the entire button, used to change its scale
    public RectTransform holderRect;

    //Start scale of the holder
    Vector2 startHolderScale;
    //The desired scale we want when we complete the input, i.e. the input percentage is 1
    public Vector2 targetHoldercale = new Vector2(1.2f, 1.2f);

    private void Awake()
    {
        //Assures we don't have null references
        Assert.IsNotNull(fillImage);
        Assert.IsNotNull(holderRect);

        startHolderScale = holderRect.localScale;
        fillImage.fillAmount = 0;
    }

    //Start called before the first frame update

    public void Start()
    {
        StartCoroutine(LoadLevel1());
    }

    IEnumerator LoadLevel1()
    {
        //replace ## with the seconds of the animation
        yield return new WaitForSeconds(3326f);
        SceneManager.LoadScene("Level1");
    }

    //The key we want to press
    public KeyCode keyCode = KeyCode.RightArrow;

    //Speed that increases the progress if we press
    public float activeSpeed = .5f;

    //How fast the progress decreases if we don't press the desired key
    float cooldownSpeed = .6f;

    //Prevents the function to be executed more than once
    bool functionTriggered = false;
    private string Level1;

    void FixedUpdate()
    {
       
            //Increases or decreases our progress based on our input (and if we didn't already trigger the function)
            //No need to clamp, since fillAmount is already clamped by Unity in the [0,1] range
            fillImage.fillAmount +=
            ((Input.GetKey(keyCode) && !functionTriggered) ?
                   activeSpeed : -cooldownSpeed) * Time.deltaTime;


            //Changes the size of the button based on our progress
            holderRect.localScale = Vector2.Lerp(
                startHolderScale,
                targetHoldercale,
                fillImage.fillAmount * fillImage.fillAmount //you can apply an interpolation there, I applied EaseIn
                );
       

        //Triggers the function if we didn't already, and the progress/percentage is 1
        if (!functionTriggered && fillImage.fillAmount == 1)
        {
            functionTriggered = true;

            Debug.Log("Button pressed completely");

            //Do something here
            //Skip cutscene or similar
            //[...]
            SceneManager.LoadScene("Level1");
        }
        else
        {
            functionTriggered = false;
        }
    }
}
