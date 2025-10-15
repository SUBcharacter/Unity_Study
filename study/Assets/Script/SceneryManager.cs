using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] Slider progress;
    [SerializeField] GameObject screen;
    

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SceneMove(int buildIndex)
    {
        StartCoroutine(TransitionScene(buildIndex));
    }

    public IEnumerator TransitionScene(int index)
    {
        progress.value = 0;
        screen.SetActive(true);

        // <AsyncOperation>
        // - allowSceneActivaion
        // 장면이 준비된 즉시 장면이 활성화되는 것을 허용하는 변수

        AsyncOperation async = SceneManager.LoadSceneAsync(index);
        async.allowSceneActivation = false;

        // <AsyncOperation>
        // -isDone
        // 해당 동작이 완료되었는지 나타내는 변수(읽기 전용)
        while(async.isDone == false)
        {
            // <AsyncOperation>
            // - progress
            // 작업의 진행 상태를 나타내는 변수(읽기 전용)
            if(async.progress>= 0.9f)
            {
                progress.value = Mathf.Lerp(progress.value, 1.0f, Time.deltaTime);
                if(progress.value > 0.999f)
                {
                    async.allowSceneActivation = true;
                    screen.SetActive(false);
                    yield break;
                }
            }
            else
            {
                progress.value = async.progress * Time.deltaTime;
            }
                yield return null;
        }
    }
}
