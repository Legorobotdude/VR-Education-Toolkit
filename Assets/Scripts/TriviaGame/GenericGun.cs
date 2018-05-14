using UnityEngine;
using VRTK;

public class GenericGun : VRTK_InteractableObject
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private float bulletSpeed =5000f;
    [SerializeField] private float bulletLife = 5f;
    [SerializeField] AudioSource audioSource;
    [SerializeField] ParticleSystem shot;

    public override void StartUsing(VRTK_InteractUse usingObject)
    {
        base.StartUsing(usingObject);
        FireBullet();
    }

    protected void Start()
    {
        //bullet = transform.Find("Bullet").gameObject;
        bullet.SetActive(false);
    }

    private void FireBullet()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        GameObject bulletClone =
            Instantiate(bullet, bullet.transform.position, bullet.transform.rotation) as GameObject;
        bulletClone.SetActive(true);
        Rigidbody rb = bulletClone.GetComponent<Rigidbody>();
        rb.AddForce(bullet.transform.up * bulletSpeed);
        Destroy(bulletClone, bulletLife);
    }
}