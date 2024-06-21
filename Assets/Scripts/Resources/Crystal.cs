using UnityEngine;

public class Crystal : MonoBehaviour
{
    private bool _isAssigned;
    private bool _isTransporting;

    private Transform _bot;

    public bool IsAssigned => _isAssigned;
    public bool IsTransporting => _isTransporting;

    private void Awake()
    {
        _isAssigned = false;
        _isTransporting = false;
    }
    private void Update()
    {
        if (_isTransporting == false || _bot == null)
            return;
        else
            transform.position = _bot.position;
    }

    public void Assign()
    {
        _isAssigned = true;
    }

    public void Transport()
    {
        _isTransporting = true;
    }

    public void SetBot(Transform bot)
    {
        _bot = bot;
    }
}