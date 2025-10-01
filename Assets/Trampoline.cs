using UnityEngine;

public class DirectionalTrampoline : MonoBehaviour
{
    public float launchForce = 100f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Rigidbody rb = collision.rigidbody;

            if (rb != null)
            {
                Vector3 incomingVelocity = rb.linearVelocity;

                // Costruiamo una direzione "riflessa" con componente verticale positiva
                Vector3 launchDirection = incomingVelocity.normalized;

                // Se la direzione è verso il basso, inverti la Y
                if (launchDirection.y < 0)
                {
                    launchDirection.y *= -1f;
                }

                // Aggiungi un po' di spinta extra verso l'alto
                launchDirection += Vector3.up * 2f;
                launchDirection.Normalize();

                // Reset della velocità
                rb.linearVelocity = Vector3.zero;

                // Lancio
                rb.AddForce(launchDirection * launchForce, ForceMode.Impulse);
            }
        }
    }
}
