using UnityEditor;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/Scenes/SampleScene.unity" };  // Замените на ваши сцены
        string buildPath = "Builds/MyGame.exe";  // Путь для выхода сборки

        BuildPipeline.BuildPlayer(scenes, buildPath, BuildTarget.StandaloneWindows64, BuildOptions.None);
    }
}

