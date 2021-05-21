using System;
using TymurKoshel.Coordinator;

namespace Delegates
{
    public class GameDelegate : IDelegate
    {
        public Action OnLoad;
        public Action OnStartGameplay;
        public Action OnStopGameplay;
    }
}