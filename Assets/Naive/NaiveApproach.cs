using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class NaiveApproach : MonoBehaviour
{
	[SerializeField] private TextAsset	mr_WallOfText;

	private void Start()
	{
		GetComponent<Text>().text = mr_WallOfText.text;
	}
}
