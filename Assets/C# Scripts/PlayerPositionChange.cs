using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPositionChange : MonoBehaviour {

    bool alive = true;

    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    float horizontalMultiplier = 2;
    
    public float speedIncreasePerPoint = 0.1f;

    private void FixedUpdate ()
    {
        if (!alive) return; 

        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    private void Update () {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5) {
            Die();
        }
        transform.rotation =  new UnityEngine.Quaternion(0,0,0,0);
   }

    public void Die ()
    {
        alive = false;
        Invoke("Restart", 2);
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}