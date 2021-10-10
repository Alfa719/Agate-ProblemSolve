using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SpawnScript : MonoBehaviour
{
    public GameObject pinkObject, yellowObject, gameOver, player;
    private Text scoreText, timeText;

    float randVert, randHoriz;

    void Start()
    {

        //Set awal score dan waktu
        ScoreScript.score = 0;
        TimeManager.time = 0;
        TimeManager.duration = 3;

        //Init
        scoreText = GameObject.Find("Score Text"). GetComponent<Text>();
        timeText = GameObject.Find("Timer Text"). GetComponent<Text>();

        //Spawn acak pink
        for (int i = 0; i < 5; i++)
        {
            randVert = Random.Range(3.37f, -3.37f);
            randHoriz = Random.Range(6.32f, -6.32f);
            Instantiate(pinkObject, new Vector2(randHoriz, randVert), Quaternion.identity);
        }
        //Spawn acak yellow
        for (int i = 0; i < 2; i++)
        {
            randVert = Random.Range(3.37f, -3.37f);
            randHoriz = Random.Range(6.32f, -6.32f);
            Instantiate(yellowObject, new Vector2(randHoriz, randVert), Quaternion.identity);
        }
    }
    void Update()
    {
        //Config Waktu
        TimeManager.time += Time.deltaTime;

        timeText.text = "Time : " + GetTimeString((TimeManager.duration - TimeManager.time) +1 );

        //Waktu Habis
        TimeOut(TimeManager.duration, TimeManager.time);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PinkItem"))
        {
            ScoreScript.AddScore(1);
            TimeManager.AddDuration(1);
            scoreText.text = "Score : " + ScoreScript.score;
            Destroy(collision.gameObject);

            StartCoroutine(SpawnPink(pinkObject));
        }
        if (collision.gameObject.CompareTag("YellowItem"))
        {
            ScoreScript.AddScore(5);
            TimeManager.AddDuration(5);
            scoreText.text = "Score : " + ScoreScript.score;
            Destroy(collision.gameObject);

            StartCoroutine(SpawnYellow(yellowObject));
        }
    }
    IEnumerator SpawnPink(GameObject pink)
    {
        yield return new WaitForSeconds(3);
        Instantiate(pink, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
    IEnumerator SpawnYellow(GameObject yellow)
    {
        yield return new WaitForSeconds(10);
        Instantiate(yellow, new Vector2(Random.Range(6.32f, -6.32f), Random.Range(3.37f, -3.37f)), Quaternion.identity);
    }
    //Format waktu
    private string GetTimeString(float timeRemaining)
    {
        int minute = Mathf.FloorToInt(timeRemaining / 60);
        int second = Mathf.FloorToInt(timeRemaining % 60);

        return string.Format("{0} : {1}", minute.ToString(), second.ToString());
    }
    void TimeOut(int duration, float time)
    {
        if (time >= duration)
        {
            time = duration;
            player.SetActive(false);
            gameOver.SetActive(true);
        }
    }
}
