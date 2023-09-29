using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject cube;

    // Slider 오브젝트를 Inspector에서 연결합니다.
    public Slider slider;
    float sliderValue;

    void Start()
    {
        // Slider의 값을 읽어옵니다.
        sliderValue = slider.value;
    }

    void Update()
    {
        // 큐브의 높이 값을 TMP 텍스트로 설정
        textMeshPro.text = "Height: " + sliderValue.ToString();
    }
}