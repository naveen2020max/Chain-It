using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Naveen.Inputs;

public class Player : MonoBehaviour
{
    private Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        MobileInput.instance.ON_Swipe += OnSwipe;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UnSubscribeOnScript()
    {
        MobileInput.instance.ON_Swipe -= OnSwipe;
    }

    private void OnSwipe(MobileInput.SwipeDirection SwipeDir)
    {
        switch (SwipeDir)
        {
            case MobileInput.SwipeDirection.TOP:
                body.MovePosition(transform.position + Vector3.forward);
                break;
            case MobileInput.SwipeDirection.DOWN:
                body.MovePosition(transform.position - Vector3.forward);
                break;
            case MobileInput.SwipeDirection.LEFT:
                body.MovePosition(transform.position + Vector3.left);
                break;
            case MobileInput.SwipeDirection.RIGHT:
                body.MovePosition(transform.position + Vector3.right);
                break;


            default:
                break;
        }
    }

    public void StartGame()
    {
        UnSubscribeOnScript();
        GameManager.instance.StartGame();
    }

}
