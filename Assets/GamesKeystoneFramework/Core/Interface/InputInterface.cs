using System;
using System.Collections.Generic;

namespace GamesKeystoneFramework.Core
{
    public interface IInputInterface<T>
    {
        List<T> InputBuffer { get; set; }
        bool CanInput { get; set; }
        float TypeAhead { get; set; }
    }
}