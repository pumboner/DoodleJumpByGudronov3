using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPoint : MonoBehaviour
{
    [SerializeField] public Transform _target;
        public void Update()
    {
        if(_target.position.y < transform.position.y)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
