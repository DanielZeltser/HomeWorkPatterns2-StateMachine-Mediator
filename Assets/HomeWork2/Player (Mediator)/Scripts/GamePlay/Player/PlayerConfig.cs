using UnityEngine;

namespace HomeWork2.MediatorPattern.GamePlay
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig")]

    public sealed class PlayerConfig : ScriptableObject
    {
        [field: SerializeField, Range(1, 100)] public int Health {  get; private set; }
        [field: SerializeField, Range(1, 10)] public int Level { get; private set; }
    }
}
