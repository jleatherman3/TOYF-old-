using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

	//Start called before the first frame update

	public void Start()
	{
		StartCoroutine(Opening());

	}

	IEnumerator Opening()
	{
		//replace ## with the seconds of the animation
		yield return new WaitForSeconds(5f);
		SceneManager.LoadScene("Opening");
	}
}
