using UnityEngine;

namespace CodeBase
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private float _rotationSpeed;
        [SerializeField] private Renderer _coinRenderer;

        private void Update()
        {
            transform.Rotate(Vector3.back, _rotationSpeed * Time.deltaTime);
        }

        private void OnMouseDown()
        {
            _coinRenderer.material.color = Random.ColorHSV();
        }
    }
}