using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gamemanager : MonoBehaviour

 
{
    static public Gamemanager Instance;
    
    public GameObject wallPrefab;
    public float spawnTerm = 4;
    public TextMeshProUGUI scoreLabel; 
    //UI를 표시하기 위한 텍스트 프로는 이러한 타입명입니다.
    

    public float score;

    float spawnTimer;

    private void Awake()
    {
        Instance = this;
	}
    
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = 0;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       spawnTimer+= Time.deltaTime;
       score += Time.deltaTime;
       scoreLabel.text = ((int)score).ToString();
       
       if(spawnTimer> spawnTerm)
       {
        spawnTimer-= spawnTerm;

        GameObject obj= Instantiate(wallPrefab);
        obj.transform.position= new Vector2(10,Random.Range(-2.75f,2.75f));

	   }
    }
}
