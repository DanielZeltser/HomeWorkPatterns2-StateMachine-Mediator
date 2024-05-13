using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{

    [CreateAssetMenu(fileName = "GameDevelopingStateConfig", menuName = "Configs/GameDeveloperStates/GameDeveloping")]
    public sealed class GameDevelopingStateConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 15f)] public float TimeDeveloping { get; private set; }
    }
}
