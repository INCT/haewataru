using UnityEngine;
using System.Collections;

public class Acceleration : MonoBehaviour
{
	
	/// <summary>加速度？傾き？</summary>
	private Vector3 acceleration;
	/// <summary>フォント</summary>
	private GUIStyle labelStyle;
	
	// Use this for initialization
	void Start()
	{/*
		if(SystemInfo.supportsGyroscope)
		{
			Input.gyro.enabled = true;
		}*/
		//フォント生成
		this.labelStyle = new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 22;
		this.labelStyle.normal.textColor = Color.white;
	}
	
	// Update is called once per frame
	void Update()
	{
		/*
		if (Input.gyro.attitude.x < -0.5) {
			x = 0.5f;
		}
		if (Input.gyro.attitude.x > 0.5) {
			x = -0.5f;
		}
*/
		// Input.gyro.attitude.y;
		this.acceleration = Input.acceleration;

		transform.Rotate(0,this.acceleration.x*2,0);
		transform.Rotate(-3*this.acceleration.z, 0, 0);

		transform.Translate (0,0,1.4f);
	}

	void OnGUI()
	{
		if (acceleration != null)
		{
			float x = Screen.width / 10;
			float y = 0;
			float w = Screen.width * 8 / 10;
			float h = Screen.height / 20;

			for (int i = 0; i < 3; i++)
			{
				y = Screen.height / 10 + h * i;
				string text = string.Empty;
				
				switch (i)
				{
				case 0://X
					text = string.Format("accel-X:{0}", this.acceleration.x);
					break;
				case 1://Y
					text = string.Format("accel-Y:{0}", this.acceleration.y);
					break;
				case 2://Z
					text = string.Format("accel-Z:{0}", this.acceleration.z);
					break;
				default:
					throw new System.InvalidOperationException();



				}
				
				GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
			}
		}
	}
}