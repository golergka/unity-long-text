using UnityEngine;
using UnityEngine.UI;

public class CutText : MonoBehaviour
{
	[SerializeField] private TextAsset		mr_WallOfText;
	[SerializeField] private Text			mr_ParagraphPrefab;

	private void Start()
	{
		var wallOfText = mr_WallOfText.text;

		/* Be carefull with what symbol are you splitting the text in: it's \n in Unix systems and
		 * \n\r in Windows. System.Envrionment.Newline might sound like a good idea, but it's not,
		 * because it changes dynamically depending on what platform are you running the code, and
		 * instead, you want it to be tied to the platform on which you edited the text.
		 *
		 * In my case, I know it's \n.
		 */
		var paragraphs = wallOfText.Split('\n');
		foreach(var p in paragraphs)
		{
			var pText = Instantiate(mr_ParagraphPrefab) as Text;
			pText.transform.SetParent(transform, false);
			pText.text = p;
		}
	}
}

