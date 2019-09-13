using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputManager : MonoBehaviour
{
    [SerializeField]
    private Button StateBtn1;
    [SerializeField]
    private Button StateBtn2;
    [SerializeField]
    private Button StateBtn3;
    [SerializeField]
    private Button StateBtn4;

    [SerializeField]
    private Button StateBtn5;

    // Start is called before the first frame update
    void Start()
    {
        var context = new InputContext();
        var state1 = new InputState(context);
        var state2 = new InputState(context);
        var state3 = new InputState(context);
        var state4 = new InputState(context);
        var state5 = new InputState(context);

        StateBtn1.onClick.AddListener(context.onInput);

        state1.OnEnter += () => Debug.Log("State1 Enter");
        state1.OnExit += () => Debug.Log("State1 Exit");
        state1.InputEvent += () => state1.Context.transitState(state2);

        state2.OnEnter += () => Debug.Log("State2 Enter");
        state2.OnExit += () => Debug.Log("State2 Exit");
        state2.InputEvent += () => state2.Context.transitState(state3);

        state3.OnEnter += () => Debug.Log("State3 Enter");
        state3.OnExit += () => Debug.Log("State3 Exit");
        state3.InputEvent += () => state3.Context.transitState(state4);

        state4.OnEnter += () => Debug.Log("State4 Enter");
        state4.OnExit += () => Debug.Log("State4 Exit");
        state4.InputEvent += () => state4.Context.transitState(state5);

        state5.OnEnter += () => Debug.Log("State5 Enter");
        state5.OnExit += () => Debug.Log("State5 Exit");
        state5.InputEvent += () => state5.Context.transitState(state1);

        context.setCurrentState(state1);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
