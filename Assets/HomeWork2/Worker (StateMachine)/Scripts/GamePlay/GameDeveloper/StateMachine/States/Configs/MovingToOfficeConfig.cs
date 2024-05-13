using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{

    [CreateAssetMenu(fileName = "MovingToOfficeConfig", menuName = "Configs/GameDeveloperStates/MovingToOffice")]
    public sealed class MovingToOfficeConfig : ScriptableObject
    {
        [field: SerializeField, Range(0f, 10f)] public float MoveSpeed { get; private set; }
    }
}

