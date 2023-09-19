using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledSpawner : MonoBehaviour
{
    // TODO: create pool with two lists and use it
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Speed _rideSpeed;
    [SerializeField] private float _distanceBetween;
    [SerializeField] private Transform _container;
    [SerializeField] private Transform _fromPoint; // TODO: separate random position choosing
    [SerializeField] private Transform _toPoint;

    private IEnumerator Start()
    {
        while (enabled)
        {
            // TODO: separate spawning?
            Vector2 newObjectPosition = ChoosePosition();
            Instantiate(_prefab, newObjectPosition, Quaternion.identity, _container);
            yield return new WaitForSeconds(_distanceBetween / _rideSpeed.Value);
        }
    }

    private Vector2 ChoosePosition()
    {
        return _fromPoint.position + ((_toPoint.position - _fromPoint.position) * Random.Range(0f, 1f));
    }
}
