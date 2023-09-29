using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Test : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject cube;

    // Slider 오브젝트를 Inspector에서 연결합니다.
    public Slider slider;
    float sliderValue;
    public GameObject uiWindow; // UI 창을 가리키는 GameObject
    private bool isUIVisible = false; // UI가 현재 보이는지 여부를 나타내는 불리언 변수

    void Start()
    {
        sliderValue = slider.value;
        // 만약 큐브를 찾았다면
        if (cube != null)
        {
            // 큐브의 스케일을 조정하여 z축 방향으로만 길게 만듭니다.
            cube.transform.localScale = new Vector3(1f, sliderValue, 1f); // y 축으로 ?배로 늘립니다.
        }
    }


    private void Update()
    {
        // Slider의 값을 읽어옵니다.
        sliderValue = slider.value;
        print(sliderValue);
        // 큐브의 높이 값을 TMP 텍스트로 설정
        textMeshPro.text = "Height: " + sliderValue.ToString() + " m";
        
        // 만약 큐브를 찾았다면
        if (cube != null)
        {
            // 큐브의 스케일을 조정하여 z축 방향으로만 길게 만듭니다.
            cube.transform.localScale = new Vector3(1f, sliderValue, 1f); // y 축으로 ?배로 늘립니다.
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            // G 키를 눌렀을 때 UI 창을 토글(켜고 끕니다).
            isUIVisible = !isUIVisible; // 상태를 반전시킵니다.

            // UI 창의 상태를 반영합니다.
            uiWindow.SetActive(isUIVisible);

        }
    }
}