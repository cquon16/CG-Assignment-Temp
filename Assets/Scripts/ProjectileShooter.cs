using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the inspector
    public Transform shootPoint; // The point from which the projectile will be fired
    public float projectileSpeed = 20f; // Adjust speed as needed
    public float destroyDelay = 0.1f;

    public void Shoot()
    {
        // Instantiate the projectile
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);
        Destroy(projectile, destroyDelay);

        // Ensure it has a Rigidbody component
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Apply force to the projectile
            rb.velocity = shootPoint.forward * projectileSpeed;
        }
    }
}