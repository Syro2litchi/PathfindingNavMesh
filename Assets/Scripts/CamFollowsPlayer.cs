using UnityEngine;

public class CamFollowsPlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(transform.position.x, _player.transform.position.y + 10.17f, _player.transform.position.z - 3.71f);
    }
}
