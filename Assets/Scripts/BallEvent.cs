using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class BallEvent : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Awake(){
        _score = 0;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Bonus")){
            _score++;
            _scoreText.text = _score.ToString();
        }
        if(collision.gameObject.CompareTag("Enemy")){
            _score--;
            _scoreText.text = _score.ToString();
        }
        if(collision.gameObject.CompareTag("Red")){
            PlayerPrefs.SetInt("score", _score);
            SceneManager.LoadScene(2);
            //_scoreText.text = _score.ToString();
        }
    }
}
