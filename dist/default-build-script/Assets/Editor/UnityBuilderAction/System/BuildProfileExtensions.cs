using UnityEditor;
using UnityEditor.Build.Profile;

public static class BuildProfileExtensions
{
    public static BuildTarget GetBuildTarget(this BuildProfile profile)
    {
        // The underlying serialized field name is m_BuildTarget
        var serializedObject = new SerializedObject(profile);
        var targetProp = serializedObject.FindProperty("m_BuildTarget");
        
        return (BuildTarget)targetProp.intValue;
    }
}
