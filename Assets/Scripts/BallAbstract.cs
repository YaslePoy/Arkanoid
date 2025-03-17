using System;
using System.Linq;
using UnityEditor.VersionControl;
using UnityEngine;

namespace DefaultNamespace
{
    public class BallAbstract : MonoBehaviour
    {
        public GameObject[] AvalibleBalls;
        public int Lifes;
        public GameObject LifeFolder;
        private void Start()
        {
            var ball = Instantiate(AvalibleBalls.First(i => i.name == GameManager.Instance.CurrentUser.selectedSkin));
            var component = ball.GetComponent<Ball>();
            component.Lifes = Lifes;
            component.LifesHolder = LifeFolder;
        }
    }
}