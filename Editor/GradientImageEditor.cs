using Gilzoide.GradientRect;
using UnityEditor;
using UnityEditor.UI;

[CustomEditor(typeof(GradientImage))]
public class GradientImageEditor : GraphicEditor
{
    private GradientImage _target;

    protected override void OnEnable()
    {
        base.OnEnable();
        _target = (GradientImage)target;
    }
}