using UnityEngine;
using UnityEngine.UI;

public class Test2 : MonoBehaviour
{
    public GameObject uiWindow; // UI 창을 가리키는 GameObject
    private bool isUIVisible = false; // UI가 현재 보이는지 여부를 나타내는 불리언 변수

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            // G 키를 눌렀을 때 UI 창을 토글(켜고 끕니다).
            isUIVisible = !isUIVisible; // 상태를 반전시킵니다.

            // UI 창의 상태를 반영합니다.
            uiWindow.SetActive(isUIVisible);


            // 큐브 게임 오브젝트를 찾습니다.
            GameObject cube = GameObject.Find("Cube");

            // 만약 큐브를 찾았다면
            if (cube != null)
            {
                // 큐브의 스케일을 조정하여 z축 방향으로만 길게 만듭니다.
                cube.transform.localScale = new Vector3(1f, 10f, 1f); // Z 축으로 2배로 늘립니다.
            }
        }
    }
}