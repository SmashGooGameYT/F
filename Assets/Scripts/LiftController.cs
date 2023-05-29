using UnityEngine;

public class LiftController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float maxHeight = 5f;
    [SerializeField] float minHeight = 0f;

    private float targetHeight;

    private void Start()
    {
        targetHeight = transform.position.y;
    }

    private void Update()
    {
        float step = speed * Time.deltaTime;

        // Перемещаем лифт к целевой позиции
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, targetHeight, transform.position.z), step);

        // Если достигли целевой позиции
        if (transform.position.y == targetHeight)
        {
            // Если целевая позиция - максимальная, меняем на минимальную и наоборот
            if (targetHeight == maxHeight)
            {
                targetHeight = minHeight;
            }
            else
            {
                targetHeight = maxHeight;
            }
        }
    }
}
