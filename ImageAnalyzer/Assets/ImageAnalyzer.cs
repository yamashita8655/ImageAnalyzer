using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageAnalyzer : MonoBehaviour {

	[SerializeField]Image AnalyzerImage = null;

	class Position {
		public int x;
		public int y;
	}

	public void OnClickAnalyze() {
		Sprite sprite = AnalyzerImage.sprite;
		Texture2D tex = sprite.texture;
		List<Position> positionList = new List<Position>();

		// Unityは、画像のピクセルを左下から検索しているので、それを考慮する
		for (int i = 0; i < tex.width; i++) {
			for (int j = 0; j < tex.height; j++) {
				Color color = tex.GetPixel(i, j);
				if (color.b <= 0.2f) {
					Position pos = new Position();
					pos.x = i;
					pos.y = j;
					positionList.Add(pos);
				}
			}
		}
	}
}
