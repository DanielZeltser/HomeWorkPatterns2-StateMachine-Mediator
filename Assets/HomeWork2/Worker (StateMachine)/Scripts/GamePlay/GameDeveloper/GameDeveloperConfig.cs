using UnityEngine;

namespace HomeWork2.Worker.GamePlay
{

    [CreateAssetMenu(fileName = "GameDeveloperConfig", menuName = "Configs/GameDeveloper")]
    public sealed class GameDeveloperConfig : ScriptableObject
    {
        [field: SerializeField] public WatchingDemonSlayerStateConfig WatchingDemonSlayerStateConfig { get; private set; }
        [field: SerializeField] public GameDevelopingStateConfig GameDevelopingStateConfig { get; private set; }
        [field: SerializeField] public MovingToOfficeConfig MovingToOfficeConfig { get; private set; }
        [field: SerializeField] public RunningToHomeConfig RunningToHomeConfig { get; private set; }
    }
}
