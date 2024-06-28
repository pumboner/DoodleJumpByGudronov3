using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtNearestEnemy : MonoBehaviour
{
    public float enemySearchRadius = 10f;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    private Transform nearestEnemy;

    void Update()
    {
        // Проверяем нажатие на экран
        if (Input.GetButtonDown("Fire1"))
        {
            // Находим ближайшего врага в радиусе
            FindNearestEnemy();

            // Если есть ближайший враг
            if (nearestEnemy != null)
            {
                // Поворачиваем игрока к врагу
                transform.LookAt(nearestEnemy);

                // Стреляем
                ShootBullet();
            }
        }
    }

    void FindNearestEnemy()
    {
        // Находим всех врагов в радиусе
        Collider[] colliders = Physics.OverlapSphere(transform.position, enemySearchRadius);

        float nearestDistance = float.MaxValue;
        nearestEnemy = null;

        // Ищем ближайшего врага
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                float distance = Vector3.Distance(transform.position, collider.transform.position);
                if (distance < nearestDistance)
                {
                    nearestDistance = distance;
                    nearestEnemy = collider.transform;
                }
            }
        }
    }

    void ShootBullet()
    {
        // Создаем пулю
        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);

        // Задаем направление и скорость пули
        bullet.GetComponent<Rigidbody>().velocity = transform.forward * bulletSpeed;

        // Уничтожаем пулю через некоторое время
        Destroy(bullet, 2f);
    }
}
