using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{

    [CreateAssetMenu(fileName = "RunningToHomeConfig", menuName = "Configs/GameDeveloperStates/RunningToHome")]
    public sealed class RunningToHomeConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 15f)] public float MoveSpeed { get; private set; }
    }
}

