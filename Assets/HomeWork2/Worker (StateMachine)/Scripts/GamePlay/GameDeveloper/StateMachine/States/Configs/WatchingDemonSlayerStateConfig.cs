using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{

    [CreateAssetMenu(fileName = "WatchingDemonSlayerStateConfig", menuName = "Configs/GameDeveloperStates/WatchingDemonSlayer")]
    public sealed class WatchingDemonSlayerStateConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 100f)] public float TimeWatching { get; private set; }
    }
}
