using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Test : MonoBehaviour
{
    private ActionBasedController xrController;

    private void Start()
    {
        // XR Controller (Action-based) 컴포넌트를 가져옵니다.
        xrController = GetComponent<ActionBasedController>();
    }

    // 이제 xrController를 사용하여 XR Controller (Action-based)를 조작할 수 있습니다.
    private void Update()
    {
        // VR 콘트롤러 버튼 입력을 감지합니다.
        if (xrController)
        {
            // 버튼이 눌렸을 때 123을 콘솔에 출력합니다.
            Debug.Log(xrController);
        }
    }
}