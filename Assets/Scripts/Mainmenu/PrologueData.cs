using UnityEngine;

[CreateAssetMenu(fileName = "New Prologue Data", menuName = "Prologue Data")]
public class PrologueData : ScriptableObject
{
    public Sprite image;
    [TextArea]
    public string text;
}
