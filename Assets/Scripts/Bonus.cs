using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public BonusType BonusType;
    public IBonusHandle Handle;

    public void Start()
    {
        switch (BonusType)
        {
            case BonusType.SpeedBonus:
                Handle = new SpeedBonus();
                break;
            case BonusType.ReproductionBonus:
                Handle = new ReproductionBonus();
                break;
            case BonusType.BallBiggerBonus:
                Handle = new BallBiggerBonus();
                break;
            case BonusType.BallSmallerBonus:
                Handle = new BallSmallerBonus();
                break;
            case BonusType.PlatformUpBonus:
                Handle = new PlatformBiggerBonus();
                break;
            case BonusType.PlatformDownBonus:
                Handle = new PlatformSmallerBonus();
                break;
        }
    }

    public interface IBonusHandle
    {
        void Apply();
    }

    public class SpeedBonus : IBonusHandle
    {
        public void Apply()
        {
            var balls = FindObjectsOfType<Ball>();
            foreach (var ball in balls)
            {
                var ballRb = ball.gameObject.GetComponent<Rigidbody2D>();
                ballRb.velocity *= 1.5f;
            }
        }
    }

    public class ReproductionBonus : IBonusHandle
    {
        public void Apply()
        {
            var balls = FindObjectsOfType<Ball>();
            foreach (var ball in balls)
            {
                var ballRb = ball.gameObject.GetComponent<Rigidbody2D>();
                var created = Instantiate(ball.gameObject, ball.transform.position, Quaternion.identity);
                var rb = created.GetComponent<Rigidbody2D>();
                rb.velocity = new Vector2(Random.value, Random.value).normalized * ballRb.velocity.magnitude;
            }
        }
    }

    public class BallBiggerBonus : IBonusHandle
    {
        public void Apply()
        {
            var balls = FindObjectsOfType<Ball>();
            foreach (var ball in balls)
            {
                var ballRb = ball.gameObject.GetComponent<Transform>();
                ballRb.localScale *= 2f;
            }
        }
    }
    
    public class BallSmallerBonus : IBonusHandle
    {
        public void Apply()
        {
            var balls = FindObjectsOfType<Ball>();
            foreach (var ball in balls)
            {
                var ballRb = ball.gameObject.GetComponent<Transform>();
                ballRb.localScale /= 1.7f;
            }
        }
    }
    
    public class PlatformBiggerBonus : IBonusHandle
    {
        public void Apply()
        {
            var platform = FindObjectsOfType<Platform>().FirstOrDefault();
            
            platform.transform.localScale += new Vector3(0.5f, 0, 0);
            
        }
    }
    
    public class PlatformSmallerBonus : IBonusHandle
    {
        public void Apply()
        {
            var platform = FindObjectsOfType<Platform>().FirstOrDefault();
            
            platform.transform.localScale -= new Vector3(0.5f, 0, 0);
            
        }
    }
}

public enum BonusType
{
    SpeedBonus,
    ReproductionBonus,
    BallBiggerBonus,
    BallSmallerBonus,
    PlatformUpBonus,
    PlatformDownBonus,
}