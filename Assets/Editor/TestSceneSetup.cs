using UnityEditor;
using UnityEngine;

public static class TestSceneSetup
{
    [MenuItem("Tools/Setup Kick Test Scene")]
    public static void SetupScene()
    {
        GameObject ball = GameObject.Find("Ball") ?? GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.name = "Ball";
        ball.transform.position = new Vector3(0f, 1f, 0f);
        if (ball.GetComponent<Rigidbody>() == null) ball.AddComponent<Rigidbody>();
        if (ball.GetComponent<BallKicker>() == null) ball.AddComponent<BallKicker>();

        GameObject ground = GameObject.Find("Ground") ?? GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Ground";
        ground.transform.position = Vector3.zero;

        GameObject goal = GameObject.Find("Goal") ?? GameObject.CreatePrimitive(PrimitiveType.Cube);
        goal.name = "Goal";
        goal.transform.position = new Vector3(0f, 1f, 5f);
        goal.transform.localScale = new Vector3(3f, 2f, 0.2f);
        goal.GetComponent<BoxCollider>().isTrigger = true;
        if (goal.GetComponent<GoalTrigger>() == null) goal.AddComponent<GoalTrigger>();

        Selection.activeGameObject = ball;
        Debug.Log("Test sahnesi hazır. Play'e basip ekrana tikla.");
    }
}
