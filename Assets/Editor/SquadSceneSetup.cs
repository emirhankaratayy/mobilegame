using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public static class SquadSceneSetup
{
    [MenuItem("Tools/Setup Squad List Scene")]
    public static void SetupScene()
    {
        GameObject canvasGO = GameObject.Find("Canvas");
        if (canvasGO == null)
        {
            canvasGO = new GameObject("Canvas", typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
        }

        Canvas canvas = canvasGO.GetComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;

        CanvasScaler scaler = canvasGO.GetComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1080f, 1920f);

        GameObject textGO = GameObject.Find("SquadListText");
        if (textGO == null)
        {
            textGO = new GameObject("SquadListText", typeof(Text));
            textGO.transform.SetParent(canvasGO.transform, false);
        }

        RectTransform rt = textGO.GetComponent<RectTransform>();
        rt.anchorMin = new Vector2(0.05f, 0.05f);
        rt.anchorMax = new Vector2(0.95f, 0.95f);
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;

        Text text = textGO.GetComponent<Text>();
        text.font = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        text.fontSize = 32;
        text.color = Color.black;
        text.alignment = TextAnchor.UpperLeft;

        if (canvasGO.GetComponent<SquadListUI>() == null)
        {
            canvasGO.AddComponent<SquadListUI>();
        }

        SquadListUI ui = canvasGO.GetComponent<SquadListUI>();
        SerializedObject so = new SerializedObject(ui);
        so.FindProperty("listText").objectReferenceValue = text;
        so.ApplyModifiedProperties();

        Selection.activeGameObject = canvasGO;
        Debug.Log("Kadro ekrani hazir. Play'e bas.");
    }
}
