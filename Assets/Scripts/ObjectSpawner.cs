using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    [SerializeField] float _fireForce;
    [SerializeField] float _timer;
    [SerializeField] GameObject _prefab;
    [SerializeField] Transform _offset;

    private float _delay;

    private void Update()
    {
        if (_delay <= 0)
        {
            var GO = Instantiate(_prefab, _offset.position, _offset.rotation);
            GO.GetComponent<Rigidbody>().AddForce(GO.transform.forward * _fireForce, ForceMode.Impulse);
            _delay = _timer;
        }
        _delay -= Time.deltaTime;
    }
}
