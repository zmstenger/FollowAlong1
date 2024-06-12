using System;
using _app.Scripts.Manager;
using Unity.VisualScripting;
using UnityEngine;

namespace _app.Scripts.TriggerExamples
{
    public class TriggerBox : MonoBehaviour
    {
        [SerializeField] private int count;
        public void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                if (AudioManager.instance != null)
                {
                    AudioManager.instance.PlayAudio();
                }
                else
                {
                    Debug.Log("Player Entered Trigger, No AudioManager");
                }

            }
        }
        public void OnTriggerExit(Collider other)
        {
            Debug.Log(other.transform.name + " Exited Trigger");
        }
        
        public void OnCollisionEnter(Collision other)
        {
            Debug.Log("Collided With Object");
            CountUp();
        }
        
        public void OnCollisionExit(Collision other)
        {
            Debug.Log("No Longer Colliding With Object");
        }

        private void CountUp()
        {
            count++;
        }
    }
}