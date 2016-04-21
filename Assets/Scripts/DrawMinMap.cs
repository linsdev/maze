using UnityEngine;
using System.Collections;

public class DrawMinMap : MonoBehaviour {

	public RenderTexture texture;
	public Material material;

	float offset = 10;
	int texSize;

	void Awake() {
		texSize = texture.width;
	}

	void OnGUI() {
		if (Event.current.type == EventType.Repaint) {
			Graphics.DrawTexture(new Rect(Screen.width-texSize-offset,offset,texSize,texSize), texture, material);
		}
	}
}
