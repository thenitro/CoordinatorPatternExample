using System;
using TymurKoshel.Coordinator;

namespace Delegates
{
    public class GameplayDelegate : IDelegate
    {
        public Action OnExit;
    }
}