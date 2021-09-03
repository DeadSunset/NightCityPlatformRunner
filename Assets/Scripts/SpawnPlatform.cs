using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public PlatformsList platformsList;
    private float _timer;

    private void Start()
    {
        _timer = 0;
    }
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer % 5 == 0)
        {
            int _randomPlatform = System.Convert.ToInt32(Random.Range(0, platformsList.platforms.Count));
            GameObject _randomizedPlatform = platformsList.platforms[_randomPlatform];

            Instantiate(_randomizedPlatform, gameObject.transform);
        }

    }
}
