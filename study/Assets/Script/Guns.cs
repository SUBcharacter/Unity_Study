using Unity.VisualScripting;
using UnityEngine;

public class Guns : MonoBehaviour
{
    Ability ability;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Start() : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Start");
    }

    private void Awake()
    {
        // Awake() : ��ü�� ������ �� ȣ��Ǵ� �Լ�, ��ü�� ��Ȱ��ȭ �Ǿ� ���� ������ ȣ��, �� �ѹ��� ȣ��Ǵ� �Լ�
        ability = new Ability();
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable() : ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnEnable");
    }

    private void FixedUpdate()
    {
        // FixedUpdate() : Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Fixed Update");
    }

    // Update is called once per frame
    void Update()
    {
        // Update() : ��ü�� Ȱ��ȭ�Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate() : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ
        Debug.Log("Late Update");
    }
}
