using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

[InitializeOnLoad]
public static class AutoSave
{
    static AutoSave()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        // Сохраняем сцену перед переходом в режим Play
        if (state == PlayModeStateChange.ExitingEditMode)
        {
            EditorSceneManager.SaveOpenScenes();
            Debug.Log("Автосохранение сцены перед Play выполненено.");
        }
    }
}
