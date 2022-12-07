using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

public class InBuildSample : IProcessSceneWithReport
{
	public int callbackOrder { get { return 0; } }
	public void OnProcessScene (UnityEngine.SceneManagement.Scene scene, BuildReport report) {

		// シーン内のサンプルコンポーネントを持つオブジェクトを検索して名前を出力
		foreach(GameObject obj in scene.GetRootGameObjects())
		{
			Sample[] samples =  obj.GetComponentsInChildren<Sample>();
			foreach(Sample sample in samples)
			{
				// Debug.Log(sample.gameObject.name);
				Debug.Log(sample.GetData().Str);
				Debug.Log(sample.GetData().Num);
			}
		}
		Debug.Log ($"IProcessSceneWithReport.OnProcessScene {scene.name} as {report.name}");
	}
}
