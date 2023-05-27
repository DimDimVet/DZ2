using UnityEngine;

public class ShootAbillity : MonoBehaviour, IAbility
{
    //public GameObject Bullet;
    public float ShootDelay;
    private float shootTime = float.MinValue;
    //
    [SerializeField] private ParticleSystem gunParticle;//система частиц
    [SerializeField] private ParticleSystem gunExitParticle;//система частиц

    public void Execute()
    {
        if (Time.time < shootTime + ShootDelay)
        {
            return;
        }
        else
        {
            shootTime = Time.time;
        }

        //if (Bullet!=null)
        if (gunParticle != null & gunExitParticle!=null)
        {
            //Transform outTransform = this.transform;
            //GameObject newBullet = Instantiate(Bullet, outTransform.position,outTransform.rotation);
            gunParticle.Play();//при нажатии вызываем включение системы частиц
            gunExitParticle.Play();
        }
        else
        {
            Debug.Log($"{gunParticle} и {gunExitParticle} не работает");
        }
    }
}
