using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class questionselector : MonoBehaviour {


	public Questions[] question;
	private static List<Questions> unanswered;
	private Questions currentquestion;

	void Start(){
	if ( unanswered==null|| unanswered.Count==0){
	
		    unanswered = question.ToList<Questions>;

	}


		GetRandomQuestion ();

}
	void GetRandomQuestion ()
	{

		int randomQuestionIndex = Random.Range(0, unanswered.Count);
		currentquestion = unanswered[randomQuestionIndex];
		unanswered.RemoveAt(randomQuestionIndex);

	}