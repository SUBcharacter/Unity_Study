using UnityEngine;

public class Smelter : MonoBehaviour
{
    float progress;
    int level;

    public void Success()
    {
        Debug.Log("성공");
    }

    public void Process(float Progress)
    {
        progress += Progress;

        Debug.Log($"{progress}% 완료");
        if (progress >= 100.0f)
        {
            progress = 0.0f;
        }
    }

    public void Enchant(int count)
    {
        level += count;
        Debug.Log($"강화 +{level}");
    }
}


